using System;
using System.Data;
using MySqlConnector;

namespace Datos
{
    public class RubroDatos
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT id, nombre FROM Rubro ORDER BY nombre ASC;";
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conexion))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}