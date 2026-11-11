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
            return char.IsLetter(c);            
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

            if (texto.Length < 7 || texto.Length > 15)
            {
                return false;
            }

            foreach(char c in texto)
            {
                if (!(EsDigito(c) || c == '+'))
                {
                    return false;
                }
            }
            return true;
        }

        private bool EsDigito(char c)
        {
            return char.IsDigit(c);
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
            bool contieneLetra = false;
            bool contieneNumero = false;
            bool contieneEspacio = false;            

            foreach (char c in texto)
            {
                if (!(c == ' ' || EsDigito(c) || EsLetra(c)))
                {
                    return false;
                }
                if (c == ' ') contieneEspacio = true;
                if (EsDigito(c)) contieneNumero = true;
                if (EsLetra(c)) contieneLetra = true;
            }

            return contieneEspacio && contieneNumero && contieneLetra;
        }
    }
}
