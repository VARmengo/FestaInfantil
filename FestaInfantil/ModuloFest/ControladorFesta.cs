using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloClientes;
using FestaInfantil.ModuloTema;

namespace FestaInfantil.ModuloFest
{
    public class ControladorFesta : ControladorBase
    {
        private RepositorioFesta repositorioFesta;
        private TabelaFestaControl tabelaFesta;
        private RepositorioCliente repositorioCliente;
        private RepositorioTema repositorioTema;
              
        public ControladorFesta(RepositorioFesta repositorioFesta, RepositorioCliente repositorioCliente, RepositorioTema repositorioTema)
        {
            this.repositorioFesta = repositorioFesta;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
        }
        public override string ToolTipInserir { get { return "Inserir nova Festa"; } }

        public override string ToolTipEditar { get { return "Editar Festa"; } }

        public override string ToolTipExcluir { get { return "Excluir Festa"; } }

        public override void Inserir()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();
            List<Tema> temas = repositorioTema.SelecionarTodos();

            TelaFestaForm telaFesta = new TelaFestaForm(clientes, temas);

            DialogResult opcaoEscolhida = telaFesta.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Festa festa = telaFesta.ObterFesta();

                repositorioFesta.Inserir(festa);

                CarregarFesta();

                MessageBox.Show("Festa cadastrada com Sucesso!");
            }
        }

        public override void Editar()
        {         
            Festa festaSelecionada = ObterFestaSelecionada();

            if(festaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma festa primeiro!",
                    "Edicação de Festas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Cliente> clientes = repositorioCliente.SelecionarTodos();
            List<Tema> temas = repositorioTema.SelecionarTodos();
            TelaFestaForm telaFesta = new TelaFestaForm(clientes, temas);

            telaFesta.ConfigurarTela(festaSelecionada);

            DialogResult opcaoEscolhida = telaFesta.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Festa festa = telaFesta.ObterFesta();

                repositorioFesta.Editar(festa.id, festa);

                CarregarFesta();

                MessageBox.Show("Festa editada com Sucesso!");
            }
        }

        public override void Excluir()
        {
            Festa festa = ObterFestaSelecionada();

            if (festa == null)
            {
                MessageBox.Show("Escolha uma Festa Primeiro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir esta festa?", "Exclusão de Festas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioFesta.Excluir(festa);

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
            List<Festa> festas = repositorioFesta.SelecionarTodos();

            tabelaFesta.AtualizarRegistros(festas);
        }

        private Festa ObterFestaSelecionada()
        {
            int id = tabelaFesta.ObterIdSelecionado();
            return repositorioFesta.SelecionarPorId(id);
        }
    }
}
