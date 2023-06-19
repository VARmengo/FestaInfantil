using FestaInfantil.Dominio.ModuloTema;
using FestaInfantil.ModuloTema;

namespace FestaInfantil
{
    public partial class TelaTemaForm : Form
    {
        public TelaTemaForm()
        {
            InitializeComponent();
            controlBotoes.btnSair.Click += btnSair_Click;
            controlBotoes.btnSalvar.Click += btnSalvar_Click;
            controlBotoes.btnSalvar.DialogResult = DialogResult.OK;
        }

        private void btnSalvar_Click(object? sender, EventArgs e)
        {
            TelaPrincipalForm principal = TelaPrincipalForm.Principal;

            Tema tema = ObterTema();

            ConfigurarCheckBoxSelecionados(tema.itemsDeTema);

            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Principal.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                return;
            }

            if (DialogResult == DialogResult.OK)
                principal.AtualizarRodape("Cadastro de Temas");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTema_Load(object sender, EventArgs e)
        {

        }

        public Tema ObterTema()
        {
            int id = Convert.ToInt32(txtId.Text);
            string tituloTema = txtTema.Text;

            Tema tema = new Tema(tituloTema);

            if (id > 0)
                tema.id = id;

            return tema;
        }

        public void ConfigurarTela(Tema temaSelecionado, List<ItemTema> itensSelecionados)
        {
            txtId.Text = temaSelecionado.id.ToString();
            txtTema.Text = temaSelecionado.tema;

            chbConfeitaria.Checked = itensSelecionados.Any(item => item.Nome == chbConfeitaria.Text);
            chbSalgadinhos.Checked = itensSelecionados.Any(item => item.Nome == chbSalgadinhos.Text);
            chbDecoracao.Checked = itensSelecionados.Any(item => item.Nome == chbDecoracao.Text);
            chbLembrancas.Checked = itensSelecionados.Any(item => item.Nome == chbLembrancas.Text);
            chbDescartaveis.Checked = itensSelecionados.Any(item => item.Nome == chbDescartaveis.Text);
            chbFantasias.Checked = itensSelecionados.Any(item => item.Nome == chbFantasias.Text);
        }

        public void ConfigurarCheckBoxSelecionados(List<ItemTema> items)
        {
            CheckBox[] checkBoxes =
            {
                chbConfeitaria,
                chbSalgadinhos,
                chbDecoracao,
                chbLembrancas,
                chbDescartaveis,
                chbFantasias
            };

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    items.RemoveAll(x => x.Nome == checkBox.Text);
                    items.Add(new ItemTema(checkBox.Text));
                }
            }
        }
    }
}
