using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                // Iniciamos una transacción de MySQL para asegurar la integridad de los datos
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

                        // Obtenemos automáticamente el ID con el que se creó esta compra
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
                    }

                    // Si todo salió bien, confirmamos la transacción en la base de datos
                    transaccion.Commit();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    // Si algo falla, deshacemos todo para no corromper datos
                    transaccion.Rollback();
                    respuesta = false;
                    mensaje = "Error al registrar la compra: " + ex.Message;
                }
            }

            return respuesta;
        }
    }
}