using FestaInfantil.ModuloClientes;
using FestaInfantil.ModuloFest;

namespace FestaInfantil
{
    public partial class FormFesta : Form
    {
        private Festa festa;
        public FormFesta(List <Cliente> clientes)
        {
            InitializeComponent();

            foreach (Cliente cliente in clientes)
                cmbCliente.Items.Add(cliente);

            controlBotoes.btnSair.Click += btnSair_Click;
            controlBotoes.btnSalvar.Click += btnSalvar_Click;
            controlBotoes.btnSalvar.DialogResult = DialogResult.OK;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Festa Festa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtEndereco.Text = value.endereco;
                dtpData.Value = value.dataCriacao;
                mtbHoraI.Text = value.horaInicial;
                mkbHoraF.Text = value.horaFinal;
            }
            get
            {
                return festa;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = FormPrincipal.Principal;

            string endereco = txtEndereco.Text;
            DateTime data = dtpData.Value;
            string horaInicio = mtbHoraI.Text;
            string horaFinal = mkbHoraF.Text;
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;

            festa = new Festa(endereco, data, horaInicio, horaFinal, cliente);

            string[] erros = festa.Validar();

            if (erros.Length > 0)
            {

                principal.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                return;
            }

            if (txtId.Text != "0")
                cliente.id = Convert.ToInt32(txtId.Text);

            if (DialogResult == DialogResult.OK)
                principal.AtualizarRodape("Cadastro de Festas");
        }
    }
}
