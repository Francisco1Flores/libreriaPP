using Datos;
using Entidades;

namespace Negocio;

public class ProductoNegocio_
{
    public List<Producto_> Listar()
    {
        return new ProductoDatos_().Listar();
    }
    
    public Producto_ BuscarPorCodigoDeBarras(string codigo)
    {
        return new ProductoDatos_().BuscarPorCodigoDeBarras(codigo);
    }
}