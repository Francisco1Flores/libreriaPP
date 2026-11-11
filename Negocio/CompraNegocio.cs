using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class CompraNegocio
    {
        private CompraDatos objCompraDatos = new CompraDatos();

        public bool RegistrarCompra(Compra objCompra, List<DetalleCompra> listaDetalle, out string mensaje)
        {
            mensaje = string.Empty;

            // 1. Validaciones de Negocio
            if (objCompra.IdProveedor <= 0)
            {
                mensaje = "Debe seleccionar un proveedor válido.";
                return false;
            }

            if (objCompra.IdFormaPago <= 0)
            {
                mensaje = "Debe seleccionar una forma de pago.";
                return false;
            }

            if (listaDetalle == null || listaDetalle.Count == 0)
            {
                mensaje = "Debe agregar al menos un producto a la compra.";
                return false;
            }

            if (objCompra.Total <= 0)
            {
                mensaje = "El total de la compra debe ser mayor a cero.";
                return false;
            }

            // 2. Si pasa las validaciones, enviamos a la Capa de Datos
            return objCompraDatos.RegistrarCompra(objCompra, listaDetalle, out mensaje);
        }
    }
}