using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    using System;
    using System.Data;
    using Entidades;
    using MySqlConnector;

    namespace Datos
    {
        public class ProductoDatos
        {
            // 1. Obtener toda la lista de productos con su stock
            public DataTable ListarStock()
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();
                    string query = @"SELECT 
                                    p.id AS 'ID', 
                                    p.codigoBarra AS 'Código', 
                                    p.nombre AS 'Producto', 
                                    p.precioLista AS 'Precio Lista ($)', 
                                    p.precioVenta AS 'Precio Venta ($)', 
                                    s.cantidad AS 'Stock'
                                 FROM Producto p
                                 INNER JOIN Stock s ON p.id = s.idProducto";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conexion))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }

            // 2. Buscar por coincidencia en nombre o código
            public DataTable BuscarStock(string filtro)
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();
                    string query = @"SELECT 
                                    p.id AS 'ID', 
                                    p.codigoBarra AS 'Código', 
                                    p.nombre AS 'Producto', 
                                    p.precioLista AS 'Precio Lista ($)', 
                                    p.precioVenta AS 'Precio Venta ($)', 
                                    s.cantidad AS 'Stock'
                                 FROM Producto p
                                 INNER JOIN Stock s ON p.id = s.idProducto
                                 WHERE p.nombre LIKE @filtro OR p.codigoBarra LIKE @filtro";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                return dt;
            }

            // 3. Insertar producto y su stock inicial
            public void Insertar(Producto prod)
            {
                using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    string queryProd = @"INSERT INTO Producto (nombre, precioLista, codigoBarra, precioVenta) 
                                     VALUES (@nombre, @precioLista, @codigoBarra, @precioVenta);
                                     SELECT LAST_INSERT_ID();";

                    MySqlCommand cmdProd = new MySqlCommand(queryProd, conexion);
                    cmdProd.Parameters.AddWithValue("@nombre", prod.Nombre);
                    cmdProd.Parameters.AddWithValue("@precioLista", prod.PrecioLista);
                    cmdProd.Parameters.AddWithValue("@codigoBarra", prod.CodigoBarra ?? string.Empty);
                    cmdProd.Parameters.AddWithValue("@precioVenta", prod.PrecioVenta);

                    int idGenerado = Convert.ToInt32(cmdProd.ExecuteScalar());

                    string queryStock = "INSERT INTO Stock (idProducto, cantidad) VALUES (@idProducto, @cantidad);";
                    MySqlCommand cmdStock = new MySqlCommand(queryStock, conexion);
                    cmdStock.Parameters.AddWithValue("@idProducto", idGenerado);
                    cmdStock.Parameters.AddWithValue("@cantidad", prod.CantidadStock);

                    cmdStock.ExecuteNonQuery();
                }
            }

            // 4. Modificar producto existente
            public void Modificar(Producto prod)
            {
                using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    string query = @"UPDATE Producto 
                                 SET nombre = @nombre, 
                                     precioLista = @precioLista, 
                                     codigoBarra = @codigoBarra, 
                                     precioVenta = @precioVenta
                                 WHERE id = @id;";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
                    cmd.Parameters.AddWithValue("@precioLista", prod.PrecioLista);
                    cmd.Parameters.AddWithValue("@codigoBarra", prod.CodigoBarra ?? string.Empty);
                    cmd.Parameters.AddWithValue("@precioVenta", prod.PrecioVenta);
                    cmd.Parameters.AddWithValue("@id", prod.Id);

                    cmd.ExecuteNonQuery();
                }
            }

            // 5. Eliminar producto y su stock
            public void Eliminar(int idProducto)
            {
                using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    string queryStock = "DELETE FROM Stock WHERE idProducto = @id;";
                    MySqlCommand cmdStock = new MySqlCommand(queryStock, conexion);
                    cmdStock.Parameters.AddWithValue("@id", idProducto);
                    cmdStock.ExecuteNonQuery();

                    string queryProd = "DELETE FROM Producto WHERE id = @id;";
                    MySqlCommand cmdProd = new MySqlCommand(queryProd, conexion);
                    cmdProd.Parameters.AddWithValue("@id", idProducto);
                    cmdProd.ExecuteNonQuery();
                }
            }
        }
    }
}
