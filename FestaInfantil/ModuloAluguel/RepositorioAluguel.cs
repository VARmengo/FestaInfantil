using FestaInfantil.Compartilhado;

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
