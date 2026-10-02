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
        public Cliente AgregarCliente(Cliente cliente)
        {            
            MySqlConnection conexion = ConexionDB.ObtenerConexion();
            conexion.Open();

            string consulta = $"INSERT INTO cliente (nombre, DNI, tel, email, direccion) VALUES ('{cliente.nombre}', {cliente.dni}, {cliente.tel}, '{cliente.email}', '{cliente.direccion}');";
            MySqlCommand cmdAgregar = new MySqlCommand(consulta, conexion);
            int resultado = cmdAgregar.ExecuteNonQuery();

            Cliente clienteAgregado = null;

            if (resultado == 1)
            {
                consulta = "SELECT LAST_INSERT_ID() AS id;";
                MySqlCommand cmdObtenerUltimo = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = cmdObtenerUltimo.ExecuteReader();

                lector.Read();
                int id = lector.GetInt32("id");
                clienteAgregado = new Cliente(id, cliente);
                lector.Close();
            }
            conexion.Close();
            return clienteAgregado;
        }

        public List<Cliente> ListarClientes() 
        {
            List<Cliente> clientes = new List<Cliente>();

            MySqlConnection conexion = ConexionDB.ObtenerConexion();
            conexion.Open();

            string consulta = "SELECT * FROM cliente;";
            MySqlCommand cmd = new MySqlCommand(consulta, conexion);

            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                Cliente cliente = new Cliente();
                cliente.id = lector.GetInt32("id");
                cliente.nombre = lector.GetString("nombre");
                cliente.dni = lector.GetInt32("dni");
                cliente.tel = lector.GetInt32("tel");
                cliente.email = lector.GetString("email");
                cliente.direccion = lector.GetString("direccion");

                clientes.Add(cliente);
            }
            lector.Close();
            conexion.Close();            
            return clientes;
        }
        public void ModificarCliente(Cliente cliente)
        {
            string sql = $"UPDATE cliente SET nombre = '{cliente.nombre}', tel = {cliente.tel}, email = '{cliente.email}', direccion = '{cliente.direccion}' WHERE id = {cliente.id}";
            ConexionDB.EjecutarQuery(sql);
        }

        public void EliminarCliente(int id)
        {           
            string sql = $"DELETE FROM cliente WHERE id = {id};";
            ConexionDB.EjecutarQuery(sql);
        }
    }
}
