using FestaInfantil.Dominio.ModuloAluguel;

namespace FestaInfantil.Infra.Dados.Memoria.ModuloAluguel
{
    public class RepositorioAluguel : RepositorioBase<Aluguel>
    {
        public RepositorioAluguel(List<Aluguel> alugueis)
        {
            this.listaRegistros = alugueis;
        }
    }
}
