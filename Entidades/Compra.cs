using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        // Atributos o propiedades que corresponden a la tabla 'Compra' de tu base de datos
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int IdProveedor { get; set; }
        public int IdFormaPago { get; set; }
    }
}
