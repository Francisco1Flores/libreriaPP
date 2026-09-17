using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySqlConnector;

namespace Datos
{
    public class ClienteDatos
    {
        public void AgregarCliente(Cliente cliente)
        {
            string consulta = $"INSERT INTO cliente (nombre, DNI, tel, email, direccion) VALUES ()";
            MySqlConnection conexion = ConexionDB.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();
        }

        public List<Cliente> listarClientes() 
        {
            List<Cliente> clientes = new List<Cliente>();


            return clientes;
        }

    }
}
