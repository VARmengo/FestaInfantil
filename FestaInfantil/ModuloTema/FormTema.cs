
using FestaInfantil.ModuloTema;

namespace FestaInfantil
{
    public partial class FormTema : Form
    {
        private Tema tema;
        public FormTema()
        {
            InitializeComponent();
            controlBotoes.btnSair.Click += btnSair_Click;
            controlBotoes.btnSalvar.Click += btnSalvar_Click;
            controlBotoes.btnSalvar.DialogResult = DialogResult.OK;
        }

        

        private void btnSalvar_Click(object? sender, EventArgs e)
        {
            FormPrincipal principal = FormPrincipal.Principal;

            Tema tema = ObterTema();

            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                FormPrincipal.Principal.AtualizarRodape(erros[0]);

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

            if(id > 0 )
                tema.id = id;

            return tema;
        }

        public void ConfigurarTela(Tema temaSelecionado)
        {
            txtId.Text = temaSelecionado.id.ToString();
            txtTema.Text = temaSelecionado.tema;

        }
    }
}
