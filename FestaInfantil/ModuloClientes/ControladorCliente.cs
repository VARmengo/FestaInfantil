using FestaInfantil.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.ModuloClientes
{
    public class ControladorCliente : ControladorBase
    {
        private RepositorioCliente repositorioCliente;
        private TabelaClienteControl tabelaClientes;

        public ControladorCliente(RepositorioCliente repositorioCliente) 
        {
            this.repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir {get { return "Inserir novo Cliente"; } }

        public override string ToolTipEditar { get { return "Editar novo Cliente"; } }

        public override string ToolTipExcluir { get { return "Excluir novo Cliente"; } }

        public override void Inserir()
        {
            FormClientes formClientes = new FormClientes();

            DialogResult opcaoEscolhida = formClientes.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = formClientes.Cliente;
                repositorioCliente.Inserir(cliente);

                CarregarClientes();

                MessageBox.Show("Informações Gravadas com Sucesso!");
            }
        }
        public override void Editar()
        {
            FormClientes formClientes = new FormClientes();

            formClientes.Cliente = ObterClienteSelecionado();

            DialogResult opcaoEscolhida = formClientes.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = formClientes.Cliente;
                repositorioCliente.Editar(cliente);

                CarregarClientes();

                MessageBox.Show("Informações Editadas com Sucesso!");
            }
        }
        public override void Excluir()
        {
            Cliente clienteSelecionado = ObterClienteSelecionado();

            if(clienteSelecionado == null)
            {
                MessageBox.Show("Escolha um Cliente Primeiro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o cliente: {clienteSelecionado.nome}?", "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Excluir(clienteSelecionado);

                CarregarClientes();

                MessageBox.Show("Cliente Excluído com Sucesso!");
            }
        }

        private Cliente ObterClienteSelecionado()
        {
            int id = tabelaClientes.ObterIdSelecionado();
            return repositorioCliente.SelecionarPorId(id);
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.GetClientes();
            tabelaClientes.AtualizarRegistros(clientes);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaClientes == null)
                tabelaClientes = new TabelaClienteControl();

            CarregarClientes();

            return tabelaClientes;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Clientes";
        }

    }
}
