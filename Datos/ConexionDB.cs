using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Datos
{
    public class ConexionDB
    {        
        private static string cadenaConexion = "Server=localhost;Port=3307;Database=libreriadb;UserID=root;Password=root;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}
