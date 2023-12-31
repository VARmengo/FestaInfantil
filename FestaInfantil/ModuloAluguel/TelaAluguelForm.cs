﻿using FestaInfantil.Compartilhado;
using FestaInfantil.Dominio.ModuloAluguel;
using FestaInfantil.Dominio.ModuloClientes;
using FestaInfantil.Dominio.ModuloFest;
using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;

        public TelaAluguelForm(List<Festa> festas, List<Cliente> clientes, List<Tema> temas)
        {
            InitializeComponent();

            this.ConfigurarDIalog();

            CarregarClientes(clientes);
            CarregarTipoCliente();
            CarregarFestas(festas);
            CarregarTemas(temas);
            controlBotoes.btnSair.Click += btnSair_Click;
            controlBotoes.btnSalvar.Click += btnSalvar_Click;
            controlBotoes.btnSalvar.DialogResult = DialogResult.OK;
        }

        private void CarregarTipoCliente()
        {
            TipoCliente[] tipoClientes = Enum.GetValues<TipoCliente>();

            foreach (TipoCliente tipoCliente in tipoClientes)
            {
                cmbTipoCliente.Items.Add(tipoCliente);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm principal = TelaPrincipalForm.Principal;

            Aluguel aluguel = ObterAluguel();

            string[] erros = aluguel.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Principal.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                return;
            }

            if (DialogResult == DialogResult.OK)
                principal.AtualizarRodape("Cadastro de Aluguel");
        }

        public Aluguel ObterAluguel()
        {
            int id = Convert.ToInt32(txtId.Text);
            Festa festa = (Festa)cmbFesta.SelectedItem;
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            Tema tema = (Tema)cmbTema.SelectedItem;
            decimal valorAluguelCompleto = Convert.ToDecimal(txtAluguelTotal.Text);
            decimal valorAluguelDesconto = Convert.ToDecimal(txtAluguelDesconto.Text);
            TipoCliente tipoCliente = (TipoCliente)cmbTipoCliente.SelectedItem;

            if (tipoCliente == TipoCliente.Antigo)
            {
                valorAluguelDesconto = tema.valorTotal * 0.2m;
            }

            Aluguel aluguel = new Aluguel(festa, cliente, tema, tipoCliente, valorAluguelCompleto, valorAluguelDesconto);

            if (id > 0)
                aluguel.id = id;

            return aluguel;
        }

        private void CarregarFestas(List<Festa> festas)
        {
            foreach (Festa festa in festas)
            {
                cmbFesta.Items.Add(festa);
            }
        }

        private void CarregarClientes(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                cmbCliente.Items.Add(cliente);
            }
        }
        private void CarregarTemas(List<Tema> temas)
        {
            foreach (Tema tema in temas)
            {
                cmbTema.Items.Add(tema);
            };
        }

        private void controlBotoes_Load(object sender, EventArgs e)
        {

        }

        private void TelaAluguelForm_Load(object sender, EventArgs e)
        {

        }

        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            txtId.Text = aluguelSelecionado.id.ToString();
            cmbFesta.SelectedItem = aluguelSelecionado.festa;
            cmbCliente.SelectedItem = aluguelSelecionado.cliente;
            cmbTema.SelectedItem = aluguelSelecionado.tema;
            txtAluguelTotal.Text = aluguelSelecionado.tema.valorTotal.ToString();
            cmbTipoCliente.SelectedItem = aluguelSelecionado.tipoCliente;
            txtAluguelDesconto.Text = aluguelSelecionado.valorAluguelDesconto.ToString();
        }

        private void TelaAluguelForm_Load_1(object sender, EventArgs e)
        {

        }

        private void cmbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tema temaSelecionado = cmbTema.SelectedItem as Tema;

            if (temaSelecionado == null)
                return;

            decimal calculoAluguelDesconto = temaSelecionado.valorTotal * 0.2m;
            decimal valorAluguelDesconto = temaSelecionado.valorTotal - calculoAluguelDesconto;
            txtAluguelTotal.Text = temaSelecionado.valorTotal.ToString();
            txtAluguelDesconto.Text = valorAluguelDesconto.ToString();
        }

        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tema temaSelecionado = cmbTema.SelectedItem as Tema;

            if (temaSelecionado == null)
                return;

            TipoCliente tipoCliente = (TipoCliente)cmbTipoCliente.SelectedItem;


            if(tipoCliente == TipoCliente.Antigo)
            {
                decimal calculoAluguelDesconto = temaSelecionado.valorTotal * 0.2m;
                decimal valorAluguelDesconto = temaSelecionado.valorTotal - calculoAluguelDesconto;
                txtAluguelTotal.Text = temaSelecionado.valorTotal.ToString();
                txtAluguelDesconto.Text = valorAluguelDesconto.ToString();
            }

            else if (tipoCliente == TipoCliente.Novo)
            {
                txtAluguelTotal.Text = temaSelecionado.valorTotal.ToString();
                txtAluguelDesconto.Text = temaSelecionado.valorTotal.ToString();
            }
        }
    }
}
