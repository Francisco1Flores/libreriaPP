using System;
using System.Data;
using Entidades;
using MySqlConnector;

namespace Datos
{
    public class ProveedorDatos
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT id AS 'ID', nombre AS 'Nombre', cuil AS 'CUIL', tel AS 'Teléfono', email AS 'Email' FROM Proveedor ORDER BY nombre ASC;";
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conexion))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable Buscar(string filtro)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                conexion.Open();
                string query = @"SELECT id AS 'ID', nombre AS 'Nombre', cuil AS 'CUIL', tel AS 'Teléfono', email AS 'Email' 
                                 FROM Proveedor 
                                 WHERE nombre LIKE @filtro OR cuil LIKE @filtro;";
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

        public void Insertar(Proveedor p)
        {
            using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO Proveedor (nombre, cuil, tel, email) VALUES (@nombre, @cuil, @tel, @email);";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@cuil", string.IsNullOrEmpty(p.Cuil) ? DBNull.Value : (object)p.Cuil);
                    cmd.Parameters.AddWithValue("@tel", string.IsNullOrEmpty(p.Tel) ? DBNull.Value : (object)p.Tel);
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(p.Email) ? DBNull.Value : (object)p.Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(Proveedor p)
        {
            using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                conexion.Open();
                string query = "UPDATE Proveedor SET nombre = @nombre, cuil = @cuil, tel = @tel, email = @email WHERE id = @id;";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", p.Id);
                    cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@cuil", string.IsNullOrEmpty(p.Cuil) ? DBNull.Value : (object)p.Cuil);
                    cmd.Parameters.AddWithValue("@tel", string.IsNullOrEmpty(p.Tel) ? DBNull.Value : (object)p.Tel);
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(p.Email) ? DBNull.Value : (object)p.Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                conexion.Open();
                string query = "DELETE FROM Proveedor WHERE id = @id;";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}