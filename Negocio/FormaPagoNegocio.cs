using Datos;
using Entidades;

namespace Negocio;

public class FormaPagoNegocio
{
    public List<FormaDePago> Listar()
    {
        return new FormaPagoDatos().Listar();
    }
}