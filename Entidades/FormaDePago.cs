namespace Entidades;

public class FormaDePago
{
    public int    Id     { get; set; }
    public string Metodo { get; set; }

    public override string ToString()
    {
        return  Metodo;
    }
}