using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    using Datos;
    using Datos.Datos;
    using Entidades;
    using System;
    using System.Data;

    namespace Negocio
    {
        public class ProductoNegocio
        {
            private ProductoDatos datos = new ProductoDatos();

            public DataTable ObtenerStock()
            {
                return datos.ListarStock();
            }

            public DataTable BuscarStock(string filtro)
            {
                return datos.BuscarStock(filtro);
            }

            public void RegistrarProducto(Producto producto)
            {
                if (string.IsNullOrWhiteSpace(producto.Nombre))
                    throw new Exception("El nombre del producto no puede estar vacío.");

                if (producto.PrecioVenta <= 0)
                    throw new Exception("El precio de venta debe ser mayor a 0.");

                if (producto.CantidadStock < 0)
                    throw new Exception("El stock inicial no puede ser negativo.");

                datos.Insertar(producto);
            }

            public void ModificarProducto(Producto producto)
            {
                if (producto.Id <= 0)
                    throw new Exception("Debe seleccionar un producto válido de la tabla.");

                if (string.IsNullOrWhiteSpace(producto.Nombre))
                    throw new Exception("El nombre del producto no puede estar vacío.");

                if (producto.PrecioVenta <= 0)
                    throw new Exception("El precio de venta debe ser mayor a 0.");

                datos.Modificar(producto);
            }

            public void EliminarProducto(int idProducto)
            {
                if (idProducto <= 0)
                    throw new Exception("Debe seleccionar un producto para eliminar.");

                datos.Eliminar(idProducto);
            }
        }
    }
}
