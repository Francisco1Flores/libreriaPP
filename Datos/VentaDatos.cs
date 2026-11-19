using Entidades;
using MySqlConnector;

namespace Datos;

public class VentaDatos
{

    public Venta ObtenerUltimaVenta()
    {
        Venta venta = null;
        MySqlConnection conexion = ConexionDB.ObtenerConexion();
        conexion.Open();
        string consulta = $"SELECT * FROM factura WHERE id = (SELECT MAX(id) FROM factura);";
        
        MySqlCommand cmd = new MySqlCommand(consulta, conexion);
        MySqlDataReader lector = cmd.ExecuteReader();
        if (lector.Read())
        {
            venta = new Venta();
            venta.Id = lector.GetInt32("id");
            venta.Total = lector.GetDouble("total");
            if (venta.Total != 0) // venta realizada
            {
                //venta.idCliente = lector.GetInt32("idCliente");
                //venta.idFormaPago = lector.GetInt32("idFormaPago");
                venta.Fecha = lector.GetDateTime("fecha");
            }
        }
        lector.Close();
        conexion.Close();
        return venta ;
    }

    public int ObtenerIdParaNuevaVenta()
    {
        ConexionDB.EjecutarQuery("INSERT INTO factura(total) VALUES (0.0)");;

        int idParaNuevaVenta = -1;
        MySqlConnection conexion = ConexionDB.ObtenerConexion();
        conexion.Open();

        MySqlTransaction transaction = conexion.BeginTransaction();
        
        string consulta1 = "INSERT INTO factura(total) VALUES (0.0)";
        MySqlCommand cmd = new MySqlCommand(consulta1, conexion);
        cmd.ExecuteNonQuery();
        
        string consulta2 = $"SELECT LAST_INSERT_ID() AS ultimoId";
        cmd = new MySqlCommand(consulta2, conexion);
        MySqlDataReader lector = cmd.ExecuteReader();
        if (lector.Read())
        {
            idParaNuevaVenta = lector.GetInt32("ultimoId");
        }
        lector.Close();
        transaction.Commit();
        conexion.Close();
        return idParaNuevaVenta ;
    }

    public void ModificarVentaSinDetalles(Venta venta)
    {
        string sql = $"UPDATE factura SET fecha = '{venta.Fecha.ToString("yyyy-MM-dd H:mm:ss")}', " +
                     $"total = {venta.Total}, idFormaPago = {venta.FormaDePago.Id}, " +
                     $"idCliente = {venta.Cliente.Id} " +
                     $"WHERE id = {venta.Id}";
        ConexionDB.EjecutarQuery(sql);
    }

    public Venta ObtenerPorId(int id)
    {
        MySqlConnection conexion = ConexionDB.ObtenerConexion();
        conexion.Open();
        string consulta = $"SELECT * FROM factura;";
        MySqlCommand cmd = new MySqlCommand(consulta, conexion);
        MySqlDataReader lector = cmd.ExecuteReader();
        
        Venta venta = null;
        if (lector.Read())
        {
            venta = new Venta();
            venta.Id = lector.GetInt32("id");
            venta.Total = lector.GetDouble("total");

            venta.Cliente = null;
            if (!lector.IsDBNull(4))
            {
                venta.Cliente = new ClienteDatos().ObtenerCliente(lector.GetInt32("idCliente"));
            }

            venta.FormaDePago = null;
            if (!lector.IsDBNull(3))
            {
                venta.FormaDePago = new FormaPagoDatos().ObtenerPorId(lector.GetInt32("idFormaPago"));
            }
            
            // TODO obtener lista de detalles de venta
            venta.DetallesVenta = null;
        }
        lector.Close();
        conexion.Close();

        return venta;
    }

    public void GuardarVentaSinDetalles(Venta venta)
    {
        string fecha = venta.Fecha.ToString("yyyy-MM-dd H:mm:ss");
        Console.WriteLine(fecha);
        string sql = $"INSERT INTO factura (fecha, total, idFormaPago, idCliente) VALUES('{fecha}', {venta.Total}, {venta.FormaDePago.Id}, {venta.Cliente.Id}); ";
        ConexionDB.EjecutarQuery(sql);
    }
    
    public bool ActualizarOGuardarVenta(Venta venta)
    {
        if (ObtenerPorId(venta.Id).Total.Equals(0.0))
        {
            ModificarVentaSinDetalles(venta);
        }
        else
        {
            GuardarVentaSinDetalles(venta);
        }

        MySqlConnection conexion = ConexionDB.ObtenerConexion();
        conexion.Open();
        MySqlTransaction transaccion = conexion.BeginTransaction();
        
        try
        {
            foreach (var detalle in venta.DetallesVenta)
            {
                string queryDetalle = "INSERT INTO detallefactura (idFactura, idProducto, precio, cantidad, subTotal) VALUES (@idFactura, @idProducto, @precio, @cantidad, @subtotal)";        
            
                using (MySqlCommand cmdDetalle = new MySqlCommand(queryDetalle, conexion, transaccion))
                {
                    cmdDetalle.Parameters.AddWithValue("@idFactura", venta.Id);
                    cmdDetalle.Parameters.AddWithValue("@idProducto", detalle.Producto.Id);
                    cmdDetalle.Parameters.AddWithValue("@precio", detalle.Precio);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@subtotal", detalle.SubTotal);

                    cmdDetalle.ExecuteNonQuery();
                }        
                
                string queryStock = "UPDATE Stock SET cantidad = cantidad - @cantidad WHERE idProducto = @idProducto";
                    
                using (MySqlCommand cmdStock = new MySqlCommand(queryStock, conexion, transaccion))
                {
                    cmdStock.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdStock.Parameters.AddWithValue("@idProducto", detalle.Producto.Id);
                    cmdStock.ExecuteNonQuery();
                } 
            }
            transaccion.Commit();
            return true;
        }
        catch (Exception e)
        {
            transaccion.Rollback();
            return false;
        }
    }
}