using Datos;
using Entidades;
using MySqlConnector;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {
        public void AgregarCliente(Cliente cliente)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            clienteDatos.AgregarCliente(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            ClienteDatos clieteDatos = new ClienteDatos();
            List<Cliente> clientes = clieteDatos.ListarClientes();
            return clientes;
        }
        public void ModificarCliente(Cliente cliente)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            clienteDatos.ModificarCliente(cliente);            
        }

        public void EliminarCliente(int id)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            clienteDatos.EliminarCliente(id);            
        }
    }
}
