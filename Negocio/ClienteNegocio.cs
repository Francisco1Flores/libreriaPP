using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    internal class ClienteNegocio
    {
        public void AgregarCliente(Cliente cliente)
        {
            ClienteDatos.AgregarCliente(cliente);
        }
    }
}
