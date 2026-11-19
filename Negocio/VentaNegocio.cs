using Entidades;
using Datos;

namespace Negocio;

public class VentaNegocio
{
    private VentaDatos ventaDatos;

    public VentaNegocio()
    {
        ventaDatos = new VentaDatos();
    }
    
    public int ObtenerIdParaNuevaVenta()
    {
        Venta venta = ventaDatos.ObtenerUltimaVenta();
        if (venta.Total == 0.0)
        {
            return venta.Id;
        }

        return ventaDatos.ObtenerIdParaNuevaVenta();
    }

    public bool GuardarVenta(Venta venta)
    {
        return ventaDatos.ActualizarOGuardarVenta(venta); 
    }
}