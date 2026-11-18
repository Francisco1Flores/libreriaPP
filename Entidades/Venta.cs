namespace Entidades;

public class Venta
{
    public int         Id        { get; set; }
    public DateTime    Fecha     { get; set; }
    public double      Total     { get; set; }
    public FormaDePago FormaPago { get; set; }
    public Cliente     Cliente   { get; set; }
}