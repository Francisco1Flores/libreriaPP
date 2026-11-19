namespace Entidades;

public class ClienteDTO
{
    public Cliente? Cliente { get; set; }
    public bool Estado { get;}

    public ClienteDTO(Cliente cliente, bool estado)
    {
        Cliente = cliente;
        Estado = estado;
    }
}