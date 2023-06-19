using FestaInfantil.Dominio.ModuloClientes;

namespace FestaInfantil
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;
        public TelaClienteForm()
        {
            InitializeComponent();
            botoes.btnSair.Click += btnSair_Click;
            botoes.btnSalvar.Click += btnSalvar_Click;
            botoes.btnSalvar.DialogResult = DialogResult.OK;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm principal = TelaPrincipalForm.Principal;

            Cliente cliente = ObterCliente();

            string[] erros = cliente.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Principal.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                return;
            }

            if (DialogResult == DialogResult.OK)
                principal.AtualizarRodape("Cadastro de Clientes");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Cliente ObterCliente()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            string telefone = mtbTelefone.Text;
            string cpf = mtbCPF.Text;
            
            Cliente cliente = new Cliente(nome, telefone, cpf);

            if (id > 0)
                cliente.id = id;

            return cliente;
        }

        public void ConfigurarTela(Cliente clienteSelecionado)
        {
            txtId.Text = clienteSelecionado.id.ToString();
            txtNome.Text = clienteSelecionado.nome;
            mtbTelefone.Text = clienteSelecionado.telefone;
            mtbCPF.Text = clienteSelecionado.cpf;
        }
    }
}
