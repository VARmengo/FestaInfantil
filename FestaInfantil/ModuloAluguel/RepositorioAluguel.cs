using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloTema;

namespace FestaInfantil.ModuloAluguel
{
    public class RepositorioAluguel : RepositorioBase<Aluguel>
    {
        public RepositorioAluguel(List<Aluguel> alugueis)
        {
            this.listaRegistros = alugueis;
        }
    }
}
