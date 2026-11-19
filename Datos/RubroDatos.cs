using System.Data;
using MySqlConnector;
using Entidades;

namespace Datos
{
    public class RubroDatos
    {
        public List<Rubro> Listar()
        {
            List<Rubro> rubros = new List<Rubro>();
            using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                conexion.Open();
                
                string query = "SELECT id, nombre FROM rubro ORDER BY nombre ASC;";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    Rubro rubro = new Rubro();
                    rubro.Id = lector.GetInt32("id");
                    rubro.Nombre = lector.GetString("nombre");
                    rubros.Add(rubro);
                }
                lector.Close();
            }
            return rubros;
        }

        public void Guardar(string rubro)
        {
            using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO rubro(nombre) VALUES('" + rubro + "');";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        public bool Existe(string rubro)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                conexion.Open();
                string query = $"SELECT * FROM rubro r WHERE r.nombre = '{rubro}';";
                
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conexion))
                {
                    da.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}