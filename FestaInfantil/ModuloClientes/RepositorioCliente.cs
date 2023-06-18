using FestaInfantil.Compartilhado;

namespace FestaInfantil.ModuloClientes
{
    public class RepositorioCliente : RepositorioBase<Cliente>
    {
        public RepositorioCliente(List<Cliente> clientes)
        {
            this.listaRegistros = clientes;
        }
    }
}
