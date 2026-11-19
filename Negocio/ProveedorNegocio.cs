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

        public List<Proveedor> ListarActivos()
        {
            return objProveedorDatos.ListarProveedoresActivos();
        }
        
        public int Registrar(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrEmpty(obj.RazonSocial))
            {
                mensaje = "Debe ingresar la Razón Social del proveedor.";
                return 0;
            }
            if (string.IsNullOrEmpty(obj.Cuit))
            {
                mensaje = "Debe ingresar el CUIT del proveedor.";
                return 0;
            }

            return objProveedorDatos.Registrar(obj, out mensaje);
        }
        public bool Modificar(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.IdProveedor == 0)
            {
                mensaje = "Debe seleccionar un proveedor de la lista para modificar.";
                return false;
            }
            if (string.IsNullOrEmpty(obj.RazonSocial))
            {
                mensaje = "Debe ingresar la Razón Social del proveedor.";
                return false;
            }
            if (string.IsNullOrEmpty(obj.Cuit))
            {
                mensaje = "Debe ingresar el CUIT del proveedor.";
                return false;
            }

            return objProveedorDatos.Modificar(obj, out mensaje);
        }
        public bool BajaLogica(int idProveedor, out string mensaje)
        {
            // Aquí puedes agregar reglas de negocio adicionales si lo necesitas en el futuro 
            // (por ejemplo, verificar si tiene compras pendientes antes de darlo de baja).
            return new ProveedorDatos().BajaLogica(idProveedor, out mensaje);
        }
    }
}