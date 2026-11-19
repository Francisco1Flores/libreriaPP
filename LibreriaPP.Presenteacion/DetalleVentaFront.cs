namespace Presentacion;

public class DetalleVentaFront
{
    public string CodigoBarra    { get; set; }
    public string NombreProducto { get; set; }
    public double Precio         { get; set; }
    public int    Cantidad       { get; set; }
    public double SubTotal       { get; set; }
    
    public string[] GetStringArray()
    {
        return new[] {CodigoBarra, NombreProducto, Precio.ToString(), Cantidad.ToString(), SubTotal.ToString()};
    }
    public static DetalleVentaFront DesdeDgvFila(DataGridViewRow fila)
    {
        DetalleVentaFront detalleVenta = new DetalleVentaFront();
        try
        {
            detalleVenta.CodigoBarra = fila.Cells["C1"].Value.ToString();
            detalleVenta.NombreProducto = fila.Cells["C2"].Value.ToString();
            detalleVenta.Precio = double.Parse(fila.Cells["C3"].Value.ToString());
            detalleVenta.Cantidad = int.Parse(fila.Cells["C4"].Value.ToString());
            detalleVenta.SubTotal = double.Parse(fila.Cells["C5"].Value.ToString());
        }
        catch (Exception ex)
        {
            return null;
        }
        
        return detalleVenta;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        
        if (obj == this)
        {
            return true;
        }
        
        if (obj is DetalleVentaFront d)
        {
            return d.CodigoBarra.Equals(CodigoBarra) &&
                   d.NombreProducto.Equals(NombreProducto) &&
                   d.Precio.Equals(Precio) &&
                   d.Cantidad == Cantidad &&
                   d.SubTotal.Equals(SubTotal);
        }

        return false;
    }
}