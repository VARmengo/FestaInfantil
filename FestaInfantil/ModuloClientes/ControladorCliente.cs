using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloTema;

namespace FestaInfantil.ModuloClientes
{
    public class ControladorCliente : ControladorBase
    {
        private RepositorioCliente repositorioCliente;
        private TabelaClienteControl tabelaClientes;

        public ControladorCliente(RepositorioCliente repositorioCliente) 
        {
            this.repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir {get { return "Inserir novo Cliente"; } }

        public override string ToolTipEditar { get { return "Editar Cliente"; } }

        public override string ToolTipExcluir { get { return "Excluir Cliente"; } }

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = telaCliente.ObterCliente();

                repositorioCliente.Inserir(cliente);

                CarregarClientes();

                MessageBox.Show("Cliente cadastrado com Sucesso!");
            }
        }
        public override void Editar()
        {
            Cliente clienteSelecionado = ObterClienteSelecionado();

            if(clienteSelecionado == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Edicação de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaClienteForm telaCliente = new TelaClienteForm();

            telaCliente.ConfigurarTela(clienteSelecionado);

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = telaCliente.ObterCliente();
                repositorioCliente.Editar(cliente.id, cliente);

                CarregarClientes();

                MessageBox.Show("Cliente editado com Sucesso!");
            }
        }
        public override void Excluir()
        {
            Cliente clienteSelecionado = ObterClienteSelecionado();

            if(clienteSelecionado == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                   "Exclusão de Clientes",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o cliente: {clienteSelecionado.nome}?", "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Excluir(clienteSelecionado);

                CarregarClientes();

                MessageBox.Show("Cliente excluído com Sucesso!");
            }
        }

        private Cliente ObterClienteSelecionado()
        {
            int id = tabelaClientes.ObterIdSelecionado();
            return repositorioCliente.SelecionarPorId(id);
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();
            tabelaClientes.AtualizarRegistros(clientes);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaClientes == null)
                tabelaClientes = new TabelaClienteControl();

            CarregarClientes();

            return tabelaClientes;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Clientes";
        }

    }
}
