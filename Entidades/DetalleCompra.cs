using System;

namespace Entidades
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }

        // Propiedades auxiliares para mostrar limpio en la grilla sin cálculos en el Form
        public string NombreProducto { get; set; }
        public decimal PrecioUnitario => Cantidad > 0 ? SubTotal / Cantidad : 0;
    }
}