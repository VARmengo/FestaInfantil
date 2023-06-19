using FestaInfantil.Dominio.ModuloFest;

namespace FestaInfantil.Infra.Dados.ModuloFest
{
    public class RepositorioFesta : RepositorioBase<Festa>
    {
        public RepositorioFesta(List<Festa> festas)
        {
            this.listaRegistros = festas;
        }
    }
}
