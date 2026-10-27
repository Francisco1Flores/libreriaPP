using Datos;
using Entidades;
using System.Net.Mail;

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

        public bool NombreValido(string texto)
        {
            bool Resultado = true;
            texto = texto.Trim();

            if (string.IsNullOrEmpty(texto) || string.IsNullOrWhiteSpace(texto))
            {
                Resultado = false;
                return Resultado;
            }            

            foreach(char c in texto)
            {
                if (c != ' ' && !EsLetra(c))
                {
                    Resultado = false;
                    break;
                }                                
            }            
            return Resultado;
        }

        private bool EsLetra(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public bool DniValido(string texto)
        {
            texto = texto.Trim();
            if (string.IsNullOrEmpty(texto) || string.IsNullOrWhiteSpace(texto))
            {
                return false;
            }
            if (texto.Length < 7 ||  texto.Length > 11)
            {
                return false;
            }
            return int.TryParse(texto, out int dni);
        }

        public bool DniExiste(int dni)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            if (clienteDatos.ObtenerCliente(dni) != null)
            {
                return true;
            }
            return false;
        }

        public bool TelValido(string texto)
        {
            if (string.IsNullOrEmpty(texto) ||
                string.IsNullOrWhiteSpace(texto))
            {
                return true;
            }

            bool Resultado = true;
            if (texto.Length < 7)
            {
                Resultado = false;
                return Resultado;
            }

            foreach(char c in texto)
            {
                if (!(EsDigito(c) || c == '+'))
                {
                    Resultado = false;
                    break;
                }
            }
            return Resultado;
        }

        private bool EsDigito(char c)
        {
            return c >= '0' && c <= '9';
        }

        public bool EmailValido(string texto)
        {
            if (string.IsNullOrEmpty(texto) ||
                string.IsNullOrWhiteSpace(texto))
            {
                return true;
            }
            texto = texto.Trim();
            bool Resultado = true;
            if(texto.Contains(' '))
            {
                Resultado = false;
            }
            Resultado = MailAddress.TryCreate(texto, out _);
            return Resultado;
        }

        public bool DireccionValido(string texto)
        {            
            if (string.IsNullOrEmpty(texto) ||
                string.IsNullOrWhiteSpace(texto))
            {
                return true;
            }
            
            texto = texto.Trim();
            int NumeroDeEspacios = 0;
            foreach(char c in texto)
            {
                if (c == ' ')
                {
                    ++NumeroDeEspacios;
                }                
            }
            if (NumeroDeEspacios != 1)
            {                
                return false;
            }

            string[] Partes = texto.Split(' ');
            if (!int.TryParse(Partes[1],out _))
            {                
                return false;
            }
            return true;
        }
    }
}
