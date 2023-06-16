using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloClientes;

namespace FestaInfantil.ModuloFest
{
    public class ControladorFesta : ControladorBase
    {
        private RepositorioFesta repositorioFesta;
        private TabelaFestaControl tabelaFesta;
        private RepositorioCliente repositorioCliente;

      
        public ControladorFesta(RepositorioFesta repositorioFesta, RepositorioCliente repositorioCliente)
        {
            this.repositorioFesta = repositorioFesta;
            this.repositorioCliente = repositorioCliente;
        }
        public override string ToolTipInserir { get { return "Inserir nova Festa"; } }

        public override string ToolTipEditar { get { return "Editar Festa"; } }

        public override string ToolTipExcluir { get { return "Excluir Festa"; } }

        public override void Inserir()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            FormFesta formFesta = new FormFesta(clientes);

            DialogResult opcaoEscolhida = formFesta.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Festa festa = formFesta.Festa;
                repositorioFesta.Inserir(festa);

                CarregarFesta();

                MessageBox.Show("Informações Gravadas com Sucesso!");
            }
        }
        public override void Editar()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            FormFesta formFestas = new FormFesta(clientes);

            formFestas.Festa = ObterFestaSelecionada();

            DialogResult opcaoEscolhida = formFestas.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Festa festas = formFestas.Festa;
                repositorioFesta.Editar(festas);

                CarregarFesta();

                MessageBox.Show("Informações Editadas com Sucesso!");
            }
        }

        public override void Excluir()
        {
            Festa festaSelecionada = ObterFestaSelecionada();

            if (festaSelecionada == null)
            {
                MessageBox.Show("Escolha uma Festa Primeiro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a festa?", "Exclusão de Festas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioFesta.Excluir(festaSelecionada);

                CarregarFesta();

                MessageBox.Show("Festa Excluída com Sucesso!");
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaFesta == null)
                tabelaFesta = new TabelaFestaControl();

            CarregarFesta();

            return tabelaFesta;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Festas";
        }

        private void CarregarFesta()
        {
            List<Festa> festas = repositorioFesta.GetFestas();
            tabelaFesta.AtualizarRegistros(festas);
        }

        private Festa ObterFestaSelecionada()
        {
            int id = tabelaFesta.ObterIdSelecionado();
            return repositorioFesta.SelecionarPorId(id);
        }
    }
}
