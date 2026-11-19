using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioLista { get; set; }
        public string CodigoBarra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int? IdRubro { get; set; }
        public int? IdProveedor { get; set; }
        public int CantidadStock { get; set; }
    }
}
