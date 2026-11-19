using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class ProveedorDatos
    {
        // Método para obtener la lista de proveedores activos desde SQL Server
        public List<Proveedor> ListarProveedoresActivos()
        {
            List<Proveedor> proveedores = ListarProveedores();
            List<Proveedor> proveedoresActivos = new List<Proveedor>();
            foreach (var proveedor in proveedores)
            {
                if (proveedor.Estado)
                {
                    proveedoresActivos.Add(proveedor);
                }
            }

            return proveedoresActivos;
        }
        
        public List<Proveedor> ListarProveedores()
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();

            try
            {
                // Usamos la cadena de conexión centralizada que configuraron en ConexionDB
                using (MySqlConnection conexion = new MySqlConnection(ConexionDB.cadenaConexion))
                {
                    string query = "SELECT id, nombre, cuil, tel, email, estado FROM proveedor";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    conexion.Open();

                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            listaProveedores.Add(new Proveedor()
                            {
                                IdProveedor = Convert.ToInt32(lector["id"]),
                                RazonSocial = lector["nombre"].ToString(),
                                Cuit = lector["cuil"].ToString(),
                                Telefono = lector["tel"].ToString(),
                                Email = lector["email"].ToString(),
                                Estado = Convert.ToBoolean(lector["estado"]),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                listaProveedores = new List<Proveedor>();
            }

            return listaProveedores;
        }
        public int Registrar(Proveedor obj, out string mensaje)
        {
            int idProveedorGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(ConexionDB.cadenaConexion))
                {
                    string query = "INSERT INTO Proveedor (nombre, cuil, tel, email) VALUES (@nombre, @cuil, @tel, @email)";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", obj.RazonSocial);
                    cmd.Parameters.AddWithValue("@cuil", obj.Cuit);
                    cmd.Parameters.AddWithValue("@tel", obj.Telefono);
                    cmd.Parameters.AddWithValue("@email", obj.Email);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    idProveedorGenerado = 1;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                idProveedorGenerado = 0;
            }

            return idProveedorGenerado;
        }
        public bool Modificar(Proveedor obj, out string mensaje)
        {
            bool exito = false;
            mensaje = string.Empty;

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(ConexionDB.cadenaConexion))
                {
                    string query = "UPDATE Proveedor SET nombre = @nombre, cuil = @cuil, tel = @tel, email = @email WHERE id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", obj.RazonSocial);
                    cmd.Parameters.AddWithValue("@cuil", obj.Cuit);
                    cmd.Parameters.AddWithValue("@tel", obj.Telefono);
                    cmd.Parameters.AddWithValue("@email", obj.Email);
                    cmd.Parameters.AddWithValue("@id", obj.IdProveedor);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    exito = true;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                exito = false;
            }

            return exito;
        }
        public bool BajaLogica(int idProveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(ConexionDB.cadenaConexion)) // O tu variable de conexión
                {
                    conexion.Open();

                    // Ojo aquí: usamos 'id' que es como se llama en la BD de tus compañeros
                    string query = "UPDATE Proveedor SET estado = 0 WHERE id = @idProveedor";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                        cmd.CommandType = CommandType.Text;

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            respuesta = true;
                        }
                        else
                        {
                            mensaje = "No se pudo actualizar el estado del proveedor.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;
        }
    }
}