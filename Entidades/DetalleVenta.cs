namespace Entidades;

public class DetalleVenta
{
    public int    Id         { get; set; }
    public int    IdVenta    { get; set; }
    public int    IdProducto { get; set; }
    public double Precio     { get; set; }
    public int    Cantidad   { get; set; }
    public double SubTotal   { get; set; }
}