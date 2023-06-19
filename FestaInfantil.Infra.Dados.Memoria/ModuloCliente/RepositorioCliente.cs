using FestaInfantil.Dominio.ModuloClientes;

namespace FestaInfantil.Infra.Dados.ModuloClientes
{
    public class RepositorioCliente : RepositorioBase<Cliente>
    {
        public RepositorioCliente(List<Cliente> clientes)
        {
            this.listaRegistros = clientes;
        }
    }
}
