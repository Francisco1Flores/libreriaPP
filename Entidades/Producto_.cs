namespace Entidades;


public class Producto_
{
    public int    Id          {get; set;}
    public string Nombre      {get; set;}
    public double PrecioLista {get; set;}
    public string CodigoBarra {get; set;}
    public double PrecioVenta {get; set;}
    public int    Stock       {get; set;}

    public Producto toProducto()
    {
        Producto prod = new Producto();
        prod.Id = Id;
        prod.Nombre = Nombre;
        prod.PrecioLista = Convert.ToDecimal(PrecioLista);
        prod.PrecioVenta = Convert.ToDecimal(PrecioVenta);
        prod.CodigoBarra = CodigoBarra;
        prod.CantidadStock = Stock;

        return prod;
    }
}