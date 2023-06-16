using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloAluguel;
using FestaInfantil.ModuloClientes;
using FestaInfantil.ModuloFest;

namespace FestaInfantil
{
    public partial class FormPrincipal : Form
    {
        private ControladorBase controlador;
        private RepositorioCliente repositorioCliente = new RepositorioCliente();
        private RepositorioTema repositorioTema = new RepositorioTema(new List<Tema>());
        private RepositorioAluguel repositorioAluguel = new RepositorioAluguel(new List<Aluguel>());

        private static FormPrincipal formPrincipal;
        private RepositorioFesta repositorioFesta = new RepositorioFesta();
        public FormPrincipal()
        {
            InitializeComponent();
            formPrincipal = this;
        }
        public static FormPrincipal Principal
        {
            get
            {
                if (formPrincipal == null)
                    formPrincipal = new FormPrincipal();

                return formPrincipal;
            }
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);
            ConfigurarTelaPrincipal();
        }

        private void ConfigurarTelaPrincipal()
        {
            controlador = new ControladorTema(repositorioTema);

            ConfigurarTelaPrincipal(controlador);
        }

        private void aluguelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            controlador = new ControladorAluguel(repositorioTema);

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTitle.Text = controlador.ObterTipoCadastro();
            labelRodape.Text = controlador.ObterTipoCadastro();
            ConfigurarToolTips(new ControladorCliente(repositorioCliente));
            ConfigurarListagem(controlador);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnAdicionar.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Escolha um cadastro primeiro!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            controlador.Inserir();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();

            formInfo.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void festaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorFesta(repositorioFesta, repositorioCliente);
            ConfigurarTelaPrincipal();
        }
    }
}