using Entidades;
using MySqlConnector;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDatos
    {
        public Cliente AgregarCliente(Cliente cliente)
        {            
            MySqlConnection conexion = ConexionDB.ObtenerConexion();
            conexion.Open();

            string consulta = $"INSERT INTO cliente (nombre, DNI, tel, email, direccion) VALUES ('{cliente.Nombre}', {cliente.Dni}, '{cliente.Telefono}', '{cliente.Email}', '{cliente.Direccion}');";
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

        public Cliente ObtenerCliente(int dni)
        {
            Cliente cliente = null;
            MySqlConnection conexion = ConexionDB.ObtenerConexion();
            conexion.Open();

            string consulta = $"SELECT * FROM cliente WHERE dni = {dni};";
            MySqlCommand cmd = new MySqlCommand(consulta, conexion);

            MySqlDataReader lector = cmd.ExecuteReader();
            
            if (lector.Read())
            {
                cliente = new Cliente();
                cliente.Id = lector.GetInt32("id");
                cliente.Nombre = lector.GetString("nombre");
                cliente.Dni = lector.GetInt32("dni");
                cliente.Telefono = lector.GetString("tel");
                cliente.Email = lector.GetString("email");
                cliente.Direccion = lector.GetString("direccion");
            }
            lector.Close();
            conexion.Close();
            return cliente;
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
                cliente.Id = lector.GetInt32("id");
                cliente.Nombre = lector.GetString("nombre");
                cliente.Dni = lector.GetInt32("dni");
                cliente.Telefono = lector.GetString("tel");
                cliente.Email = lector.GetString("email");
                cliente.Direccion = lector.GetString("direccion");

                clientes.Add(cliente);
            }
            lector.Close();
            conexion.Close();            
            return clientes;
        }
        public void ModificarCliente(Cliente cliente)
        {
            string sql = $"UPDATE cliente SET nombre = '{cliente.Nombre}', tel = '{cliente.Telefono}', email = '{cliente.Email}', direccion = '{cliente.Direccion}' WHERE id = {cliente.Id}";
            ConexionDB.EjecutarQuery(sql);
        }

        public void EliminarCliente(int id)
        {           
            string sql = $"DELETE FROM cliente WHERE id = {id};";
            ConexionDB.EjecutarQuery(sql);
        }
    }
}
