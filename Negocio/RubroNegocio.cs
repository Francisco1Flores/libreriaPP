using Datos;
using Entidades;

namespace Negocio
{
    public class RubroNegocio
    {
        public void Guardar(string rubro)
        {
            new RubroDatos().Guardar(rubro);
        }

        public List<Rubro> Listar()
        {
            return new RubroDatos().Listar();
        }

        public bool Existe(string rubro)
        {
            return new RubroDatos().Existe(rubro);
        }
    }
}
