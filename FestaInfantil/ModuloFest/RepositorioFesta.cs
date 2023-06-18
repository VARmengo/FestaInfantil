using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloClientes;
namespace FestaInfantil.ModuloFest
{
    public class RepositorioFesta : RepositorioBase<Festa>
    {
        public RepositorioFesta(List<Festa> festas)
        {
            this.listaRegistros = festas;
        }
    }
}
