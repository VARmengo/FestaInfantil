using FestaInfantil.Compartilhado;
using FestaInfantil.Dominio.ModuloAluguel;
using FestaInfantil.Dominio.ModuloClientes;
using FestaInfantil.Dominio.ModuloFest;
using FestaInfantil.Dominio.ModuloTema;
using FestaInfantil.Infra.Dados.Memoria.ModuloAluguel;
using FestaInfantil.Infra.Dados.ModuloClientes;
using FestaInfantil.Infra.Dados.ModuloFest;
using FestaInfantil.Infra.Dados.ModuloTema;

namespace FestaInfantil.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private TabelaAluguelControl tabelaAluguel;
        private RepositorioAluguel repositorioAluguel;
        private RepositorioCliente repositorioCliente;
        private RepositorioTema repositorioTema;
        private RepositorioFesta repositorioFesta;

        public ControladorAluguel(RepositorioAluguel repositorioAluguel, RepositorioCliente repositorioCliente, RepositorioTema repositorioTema, RepositorioFesta repositorioFesta)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioFesta = repositorioFesta;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir => "Inserir um novo Aluguel";

        public override string ToolTipEditar => "Editar um Aluguel existente";

        public override string ToolTipExcluir => "Excluir um Aluguel existente";
        
        public override void Inserir()
        {
            List<Festa> festas = repositorioFesta.SelecionarTodos();
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();
            List<Tema> temas = repositorioTema.SelecionarTodos();

            TelaAluguelForm telaAluguel = new TelaAluguelForm(festas, clientes, temas);

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();
                repositorioAluguel.Inserir(aluguel);

                CarregarAluguel();

                MessageBox.Show("Aluguel cadastrado com Sucesso!");
            }
        }

        public override void Editar()
        {           
            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione uma aluguel primeiro!",
                    "Edicação de Aluguel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Festa> festas = repositorioFesta.SelecionarTodos();
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();
            List<Tema> temas = repositorioTema.SelecionarTodos();
            TelaAluguelForm telaAluguel = new (festas, clientes, temas);

            telaAluguel.ConfigurarTela(aluguelSelecionado);

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                repositorioAluguel.Editar(telaAluguel.ObterAluguel().id, telaAluguel.ObterAluguel());

                CarregarAluguel();

                MessageBox.Show("Aluguel editado com Sucesso!");
            }
        }        

        public override void Excluir()
        {
            Aluguel aluguel = ObterAluguelSelecionado();

            if(aluguel == null)
            {
                MessageBox.Show("Escolha uma Aluguel Primeiro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir este Aluguel?", "Exclusão de Aluguel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioAluguel.Excluir(aluguel);

                CarregarAluguel();

                MessageBox.Show("Aluguel Excluído com Sucesso!");
            }
        }              

        public override UserControl ObterListagem()
        {
            if(tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAluguel();

            return tabelaAluguel;
        }
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Aluguel";
        }

        private void CarregarAluguel()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);
        }
        private Aluguel ObterAluguelSelecionado()
        {
            int id = tabelaAluguel.ObterIdSelecionado();
            return repositorioAluguel.SelecionarPorId(id);
        }        
    }
}
