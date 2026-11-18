
namespace Entidades
{
    public class Cliente
    {
        public int    Id        { get; set;}
        public string Nombre    { get; set; }
        public int    Dni       { get; set; }
        public string Telefono  { get; set; }
        public string Email     { get; set; }
        public string Direccion { get; set; }

        public Cliente(string nombre, int dni, string tel, string email, string direccion)
        {            
            this.Nombre    = nombre;
            this.Dni       = dni;
            this.Telefono  = tel;
            this.Email     = email;
            this.Direccion = direccion;
        }
        public Cliente(int id, Cliente cliente)
        {
            this.Id        = id;
            this.Nombre    = cliente.Nombre;
            this.Dni       = cliente.Dni;
            this.Telefono  = cliente.Telefono;
            this.Email     = cliente.Email;
            this.Direccion = cliente.Direccion;
        }
        public Cliente() {}       
    }

}
