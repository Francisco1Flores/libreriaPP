using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Entidades;

namespace Negocio
{
    public class CompraNegocio
    {
        private CompraDatos objCompraDatos = new CompraDatos();

        public DetalleCompra CrearDetalle(int idProducto, string nombreProducto, int cantidad, decimal precioUnitario)
        {
            return new DetalleCompra()
            {
                IdProducto = idProducto,
                NombreProducto = nombreProducto,
                Cantidad = cantidad,
                SubTotal = cantidad * precioUnitario
            };
        }

        public decimal CalcularTotal(List<DetalleCompra> listaDetalle)
        {
            if (listaDetalle == null || listaDetalle.Count == 0)
                return 0;

            return listaDetalle.Sum(item => item.SubTotal);
        }

        public bool RegistrarCompra(Compra objCompra, List<DetalleCompra> listaDetalle, out string mensaje)
        {
            mensaje = string.Empty;

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

            return objCompraDatos.RegistrarCompra(objCompra, listaDetalle, out mensaje);
        }
    }
}