using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloClientes;

namespace FestaInfantil.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private RepositorioTema repositorioTema;
        public TabelaTemaControl tabelaTemas;

        public ControladorTema(RepositorioTema repositorioTema)
        {
            this.repositorioTema = repositorioTema;
        }
        public override string ToolTipInserir { get { return "Inserir novo Tema"; } }

        public override string ToolTipEditar { get { return "Editar Tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tema existente"; } }

        public override void Inserir()
        {
            TelaTemaForm telaTema = new TelaTemaForm();

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();
                telaTema.ConfigurarCheckBoxSelecionados(tema.itemsDeTema);

                repositorioTema.Inserir(tema);

                CarregarTemas();
            }

        }

        public override void Editar()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Edicação de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTemaForm telaTema = new TelaTemaForm();

            telaTema.ConfigurarTela(temaSelecionado, temaSelecionado.itemsDeTema);

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();
                tema.itemsDeTema.Clear();
                telaTema.ConfigurarCheckBoxSelecionados(tema.itemsDeTema);

                repositorioTema.Editar(tema.id, tema);

                CarregarTemas();
            }
        }

        public override void Excluir()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

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
            if (tabelaTemas == null)
            {
                tabelaTemas = new TabelaTemaControl();
            }

            CarregarTemas();

            return tabelaTemas;
        }

        private Tema ObterTemaSelecionado()
        {
            int id = tabelaTemas.ObterIdSelecionado();
            return repositorioTema.SelecionarPorId(id);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }

        private void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();

            tabelaTemas.AtualizarRegistros(temas);
        }
    }
}
