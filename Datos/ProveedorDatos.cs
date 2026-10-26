using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    // OJO AQUÍ: Debe ser 'public class' para que la capa Negocio pueda verla
    public class ProveedorDatos
    {
        // Método para obtener la lista de proveedores activos desde SQL Server
        public List<Proveedor> ListarProveedores()
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();

            try
            {
                // Usamos la cadena de conexión centralizada que configuraron en ConexionDB
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadenaConexion))
                {
                    string query = "SELECT IdProveedor, RazonSocial, Cuit, Telefono, Email, Estado FROM Proveedor WHERE Estado = 1";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            listaProveedores.Add(new Proveedor()
                            {
                                IdProveedor = Convert.ToInt32(lector["IdProveedor"]),
                                RazonSocial = lector["RazonSocial"].ToString(),
                                Cuit = lector["Cuit"].ToString(),
                                Telefono = lector["Telefono"].ToString(),
                                Email = lector["Email"].ToString(),
                                Estado = Convert.ToBoolean(lector["Estado"])
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
    }
}