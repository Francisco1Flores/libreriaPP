using System;
using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    public class ProveedorNegocio
    {
        private ProveedorDatos datos = new ProveedorDatos();

        public DataTable ListarProveedores()
        {
            return datos.Listar();
        }

        public DataTable BuscarProveedores(string filtro)
        {
            return datos.Buscar(filtro);
        }

        public void Registrar(Proveedor p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("El nombre o razón social del proveedor es obligatorio.");

            datos.Insertar(p);
        }

        public void Modificar(Proveedor p)
        {
            if (p.Id <= 0)
                throw new Exception("Seleccione un proveedor válido para modificar.");

            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("El nombre del proveedor no puede quedar vacío.");

            datos.Modificar(p);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("Seleccione un proveedor para eliminar.");

            datos.Eliminar(id);
        }
    }
}