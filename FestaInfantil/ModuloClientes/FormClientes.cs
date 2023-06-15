using FestaInfantil.ModuloClientes;

namespace FestaInfantil
{
    public partial class FormClientes : Form
    {
        private Cliente cliente;
        public FormClientes()
        {
            InitializeComponent();
            botoes.btnSair.Click += btnSair_Click;
            botoes.btnSalvar.Click += btnSalvar_Click;
            botoes.btnSalvar.DialogResult = DialogResult.OK;
        }

        public Cliente Cliente
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtNome.Text = value.nome;
                mtbTelefone.Text = value.telefone;
                mtbCPF.Text = value.cpf;
            }
            get
            {
                return cliente;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = FormPrincipal.Principal;

            string nome = txtNome.Text;
            string telefone = mtbTelefone.Text;
            string cpf = mtbCPF.Text;

            cliente = new Cliente(nome, telefone, cpf);

            string[] erros = cliente.Validar();

            if (erros.Length > 0)
            {

                principal.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                return;
            }


            if (txtId.Text != "0")
                cliente.id = Convert.ToInt32(txtId.Text);

            if (DialogResult == DialogResult.OK)
                principal.AtualizarRodape("Cadastro de Clientes");

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
