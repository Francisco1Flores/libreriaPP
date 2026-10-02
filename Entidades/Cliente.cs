using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int    id { get; set;}
        public string nombre { get; set; }
        public int    dni { get; set; }
        public int    tel { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }

        public Cliente(string nombre, int dni, int tel, string email, string direccion)
        {            
            this.nombre    = nombre;
            this.dni       = dni;
            this.tel       = tel;
            this.email     = email;
            this.direccion = direccion;
        }
        public Cliente(int id, Cliente cliente)
        {
            this.id = id;
            this.nombre = cliente.nombre;
            this.dni = cliente.dni;
            this.tel = cliente.tel;
            this.email = cliente.email;
            this.direccion = cliente.direccion;
        }
        public Cliente() {}
    }

}
