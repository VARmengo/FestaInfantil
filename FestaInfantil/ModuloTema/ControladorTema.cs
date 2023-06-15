using FestaInfantil.Compartilhado;

namespace FestaInfantil.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private RepositorioTema repositorioTema;
        ListagemTemaControl listagemTema;

        public ControladorTema(RepositorioTema repositorioTema)
        {
            this.repositorioTema = repositorioTema;
        }
        public override string ToolTipInserir { get { return "Inserir novo Tema"; } }

        public override string ToolTipEditar { get { return "Editar Tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tema existente"; } }

        public override void Inserir()
        {
            FormTema telaTema = new FormTema();

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();

                repositorioTema.Inserir(tema);

                CarregarTemas();
            }

        }

        public override void Editar()
        {
            Tema temaSelecionado = listagemTema.ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Edicação de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            FormTema telaTema = new FormTema();

            telaTema.ConfigurarTela(temaSelecionado);

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();

                repositorioTema.Editar(tema.id, tema);

                CarregarTemas();
            }
        }

        public override void Excluir()
        {
            Tema temaSelecionado = listagemTema.ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Exclusão de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show(
               $"Deseja excluir o tema {temaSelecionado.tema} ?",
               "Exclusão de Temas",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema.Excluir(temaSelecionado);

                CarregarTemas();
            }
        }


        public override UserControl ObterListagem()
        {
            if (listagemTema == null)
            {
                listagemTema = new ListagemTemaControl();
            }

            CarregarTemas();

            return listagemTema;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }

        private void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();

            listagemTema.AtualizarRegistros(temas);
        }
    }
}
