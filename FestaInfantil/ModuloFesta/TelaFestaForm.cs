using FestaInfantil.Dominio.ModuloFest;
using FestaInfantil.Dominio.ModuloClientes;
using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil
{
    public partial class TelaFestaForm : Form
    {
        private Festa festa;
        public TelaFestaForm(List<Cliente> clientes, List<Tema> temas)
        {
            InitializeComponent();
            CarregarClientes(clientes);
            CarregarTemas(temas);

            controlBotoes.btnSair.Click += btnSair_Click;
            controlBotoes.btnSalvar.Click += btnSalvar_Click;
            controlBotoes.btnSalvar.DialogResult = DialogResult.OK;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm principal = TelaPrincipalForm.Principal;

            Festa festa = ObterFesta();

            string[] erros = festa.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Principal.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                return;
            }

            if (DialogResult == DialogResult.OK)
                principal.AtualizarRodape("Cadastro de Temas");
        }

        private void CarregarTemas(List<Tema> temas)
        {
            foreach (Tema tema in temas)
                cmbTema.Items.Add(tema);
        }

        private void CarregarClientes(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
                cmbCliente.Items.Add(cliente);
        }

        public Festa ObterFesta()
        {
            int id = Convert.ToInt32(txtId.Text);
            string endereco = txtEndereco.Text;
            DateTime dataCriacao = txtData.Value;
            TimeSpan horaInicial = txtHoraInicial.Value.TimeOfDay;
            TimeSpan horarioFinal = txtHoraFinal.Value.TimeOfDay;
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            Tema tema = (Tema)cmbTema.SelectedItem;            

            Festa festa = new Festa(endereco, dataCriacao, horaInicial, horarioFinal, cliente, tema);

            if (id > 0)
                festa.id = id;

            return festa;
        }       

        private void label1_Click(object sender, EventArgs e)
        {

        }          

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelFesta_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ConfigurarTela(Festa festaSelecionada)
        {
            txtId.Text = festaSelecionada.id.ToString();
            txtEndereco.Text = festaSelecionada.endereco;
            txtData.Value = festaSelecionada.dataCriacao;
            txtHoraInicial.Value = DateTime.Now.Date.Add(festaSelecionada.horaInicial);
            txtHoraFinal.Value = DateTime.Now.Date.Add(festaSelecionada.horaFinal);

            if (festaSelecionada.cliente != null && festaSelecionada.tema != null)
            {
                cmbCliente.SelectedItem = festaSelecionada.cliente;
                cmbTema.SelectedItem = festaSelecionada.tema;
                CarregarItensTema(festaSelecionada);
            }
        }

        public void CarregarItensTema(Festa festa)
        {
            listItensTema.Items.Clear();

            foreach (ItemTema itemTema in festa.tema.itemsDeTema)
            {
                listItensTema.Items.Add(itemTema);
            }
        }

        private void cmbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            listItensTema.Items.Clear();
                        
            Tema temaSelecionado = cmbTema.SelectedItem as Tema;

            if (temaSelecionado != null)
            {
                foreach (ItemTema itemTema in temaSelecionado.itemsDeTema)
                {
                    listItensTema.Items.Add(itemTema);
                }
            }
        }
    }
}
