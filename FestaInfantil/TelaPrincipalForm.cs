using FestaInfantil.Dominio.ModuloAluguel;
using FestaInfantil.Dominio.ModuloClientes;
using FestaInfantil.Dominio.ModuloTema;
using FestaInfantil.Dominio.ModuloFest;

using FestaInfantil.Infra.Dados.ModuloClientes;
using FestaInfantil.Infra.Dados.ModuloTema;
using FestaInfantil.Infra.Dados.ModuloFest;
using FestaInfantil.Infra.Dados.Memoria.ModuloAluguel;

using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloClientes;
using FestaInfantil.ModuloTema;
using FestaInfantil.ModuloFest;
using FestaInfantil.ModuloAluguel;

namespace FestaInfantil
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioCliente repositorioCliente = new RepositorioCliente(new List<Cliente>());
        private RepositorioTema repositorioTema = new RepositorioTema(new List<Tema>());
        private RepositorioFesta repositorioFesta = new RepositorioFesta(new List<Festa>());
        private RepositorioAluguel repositorioAluguel = new RepositorioAluguel(new List<Aluguel>());

        private static TelaPrincipalForm formPrincipal;

        public TelaPrincipalForm()
        {
            InitializeComponent();
            formPrincipal = this;
        }
        public static TelaPrincipalForm Principal
        {
            get
            {
                if (formPrincipal == null)
                    formPrincipal = new TelaPrincipalForm();

                return formPrincipal;
            }
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);
            ConfigurarTelaPrincipal(controlador);
        }

        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema);

            ConfigurarTelaPrincipal(controlador);
        }

        private void festaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorFesta(repositorioFesta, repositorioCliente, repositorioTema);
            ConfigurarTelaPrincipal(controlador);
        }

        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorAluguel(repositorioAluguel, repositorioCliente, repositorioTema, repositorioFesta);
            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTitle.Text = controlador.ObterTipoCadastro();
            labelRodape.Text = controlador.ObterTipoCadastro();
            ConfigurarToolTips(controlador);
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
            TelaInfoForm formInfo = new TelaInfoForm();

            formInfo.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Escolha um cadastro primeiro!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Escolha um cadastro primeiro!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            controlador.Excluir();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        
    }
}