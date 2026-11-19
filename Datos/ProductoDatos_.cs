using Entidades;
using MySqlConnector;

namespace Datos;

public class ProductoDatos_
{
    public List<Producto_> Listar()
    {
        List<Producto_> productos = new List<Producto_>();

        MySqlConnection conexion = ConexionDB.ObtenerConexion();
        conexion.Open();

        //string consulta = "SELECT * FROM producto;";
        string consulta = $"SELECT p.id AS 'id'," +
                          "p.codigoBarra AS 'codigoBarra'," +
                          "p.nombre AS 'nombre'," +
                          "p.precioVenta AS 'precioVenta'," +
                          "p.precioLista AS 'precioLista'," +
                          "s.cantidad AS 'stock'" +
                          "FROM Producto p " +
                          "INNER JOIN Stock s ON p.id = s.idProducto;";
        
        MySqlCommand cmd = new MySqlCommand(consulta, conexion);

        MySqlDataReader lector = cmd.ExecuteReader();
        while (lector.Read())
        {
            Producto_ producto = new Producto_();
            producto.Id          = lector.GetInt32("id");
            producto.Nombre      = lector.GetString("nombre");
            producto.CodigoBarra = lector.GetString("codigoBarra");
            producto.PrecioVenta = lector.GetDouble("precioVenta");
            producto.PrecioLista = lector.GetDouble("precioLista");
            producto.Stock       = lector.GetInt32("stock");

            productos.Add(producto);
        }
        lector.Close();
        conexion.Close();            
        return productos;
    }

    public Producto_ BuscarPorCodigoDeBarras(string codigo)
    {
        MySqlConnection conexion = ConexionDB.ObtenerConexion();
        conexion.Open();
        
        string consulta = "SELECT p.id AS 'id'," +
                          "p.codigoBarra AS 'codigoBarra'," +
                          "p.nombre AS 'nombre'," +
                          "p.precioVenta AS 'precioVenta'," +
                          "s.cantidad AS 'stock' " + 
                          "FROM Producto p " +
                          "INNER JOIN Stock s ON p.id = s.idProducto " +
                          $"WHERE p.codigoBarra = '{codigo}'";
                          ;
        MySqlCommand cmd = new MySqlCommand(consulta, conexion);

        MySqlDataReader lector = cmd.ExecuteReader();
        Producto_ producto = null;
        if (lector.Read())
        {
            producto = new Producto_();

            producto.Id          = lector.GetInt32("id");
            producto.Nombre      = lector.GetString("nombre");
            producto.CodigoBarra = lector.GetString("codigoBarra");
            producto.PrecioVenta = lector.GetDouble("precioVenta");
            producto.Stock       = lector.GetInt32("stock");
        }
        return producto;
    }
}