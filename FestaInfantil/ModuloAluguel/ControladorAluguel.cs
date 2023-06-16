using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloTema;

namespace FestaInfantil.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private RepositorioTema repositorioFesta;
        //private RepositorioFesta repositorioFesta;
        private RepositorioAluguel repositorioAluguel;
        listAlugueis listagemAluguel;

        public ControladorAluguel(RepositorioTema repositorioFesta)
        {
            this.repositorioFesta = repositorioFesta;
        }

        public override string ToolTipInserir { get { return "Inserir novo Aluguel"; } }

        public override string ToolTipEditar { get { return "Editar Aluguel existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Aluguel existente"; } }

        public override void Inserir()
        {
            List<Tema> festas = repositorioFesta.SelecionarTodos();

            FormAluguel telaAluguel = new FormAluguel(festas);

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();

                repositorioAluguel.Inserir(aluguel);

                CarregarAluguel();
            }
        }

        private void CarregarAluguel()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            listagemAluguel.AtualizarRegistros(alugueis);
        }

        public override void Editar()
        {
            Aluguel aluguelSelecionado = listagemAluguel.ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Edicação de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            //List<Contato> contatos = repositorioContato.SelecionarTodos();
            //TelaCompromissoForm telaCompromisso = new TelaCompromissoForm(contatos);

            //telaCompromisso.ConfigurarTela(aluguelSelecionado);

            //DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            //if (opcaoEscolhida == DialogResult.OK)
            //{
            //    Compromisso compromisso = telaCompromisso.ObterCompromisso();

            //    repositorioCompromisso.Editar(compromisso.id, compromisso);

            //    CarregarCompromissos();
            //}
        }

        public override void Excluir()
        {
            Aluguel aluguelSelecionado = listagemAluguel.ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Edicação de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
        }              

        public override UserControl ObterListagem()
        {
            if(listagemAluguel == null)
            {
                listagemAluguel = new listAlugueis();
            }
            return listagemAluguel;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Aluguel";
        }
    }
}
