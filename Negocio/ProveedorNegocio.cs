using System.Collections.Generic;
using Datos;
using Entidades;

namespace Negocio
{
    public class ProveedorNegocio
    {
        // Instanciamos la capa de Datos para comunicarnos con SQL Server
        private ProveedorDatos objProveedorDatos = new ProveedorDatos();

        // Método que llama el formulario para obtener la lista de proveedores
        public List<Proveedor> Listar()
        {
            return objProveedorDatos.ListarProveedores();
        }
    }
}