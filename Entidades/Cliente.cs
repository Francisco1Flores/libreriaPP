using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int id {get; set;}
        string nombre;
        int dni;
        int tel;
        string email;
        string direccion;

        public Cliente(string nombre, int dni, int tel, string email, string direccion)
        {            
            this.nombre = nombre;
            this.dni = dni;
            this.tel = tel;
            this.email = email;
            this.direccion = direccion;
        }
    }

}
