using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Entidades;

namespace Datos
{
    public class CompraDatos
    {
        public bool RegistrarCompra(Compra objCompra, List<DetalleCompra> listaDetalle, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (MySqlConnection conexion = new MySqlConnection(ConexionDB.cadenaConexion))
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    // 1. Insertar la Cabecera de la Compra
                    string queryCompra = "INSERT INTO Compra (fecha, total, idProveedor, idFormaPago) VALUES (NOW(), @total, @idProveedor, @idFormaPago);";
                    long idCompraGenerado = 0;

                    using (MySqlCommand cmdCompra = new MySqlCommand(queryCompra, conexion, transaccion))
                    {
                        cmdCompra.Parameters.AddWithValue("@total", objCompra.Total);
                        cmdCompra.Parameters.AddWithValue("@idProveedor", objCompra.IdProveedor);
                        cmdCompra.Parameters.AddWithValue("@idFormaPago", objCompra.IdFormaPago);
                        cmdCompra.CommandType = CommandType.Text;

                        cmdCompra.ExecuteNonQuery();
                        idCompraGenerado = cmdCompra.LastInsertedId;
                    }

                    // 2. Insertar cada Detalle de la Compra asociado al ID generado
                    foreach (DetalleCompra item in listaDetalle)
                    {
                        string queryDetalle = "INSERT INTO DetalleCompra (idCompra, idProducto, cantidad, subTotal) VALUES (@idCompra, @idProducto, @cantidad, @subTotal);";

                        using (MySqlCommand cmdDetalle = new MySqlCommand(queryDetalle, conexion, transaccion))
                        {
                            cmdDetalle.Parameters.AddWithValue("@idCompra", Convert.ToInt32(idCompraGenerado));
                            cmdDetalle.Parameters.AddWithValue("@idProducto", item.IdProducto);
                            cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                            cmdDetalle.Parameters.AddWithValue("@subTotal", item.SubTotal);
                            cmdDetalle.CommandType = CommandType.Text;

                            cmdDetalle.ExecuteNonQuery();
                        }

                        // OPCIONAL: Descomentar cuando confirmemos el nombre de la columna de stock en la tabla Producto
                        /*
                        string queryStock = "UPDATE Producto SET stock = stock + @cantidad WHERE id = @idProducto;";
                        using (MySqlCommand cmdStock = new MySqlCommand(queryStock, conexion, transaccion))
                        {
                            cmdStock.Parameters.AddWithValue("@cantidad", item.Cantidad);
                            cmdStock.Parameters.AddWithValue("@idProducto", item.IdProducto);
                            cmdStock.ExecuteNonQuery();
                        }
                        */
                    }

                    transaccion.Commit();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    respuesta = false;
                    mensaje = "Error al registrar la compra: " + ex.Message;
                }
            }

            return respuesta;
        }
    }
}