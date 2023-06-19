
using FestaInfantil.Dominio.ModuloClientes;

namespace FestaInfantil.ModuloClientes
{
    public partial class ListagemClientesControl : UserControl
    {
        public ListagemClientesControl()
        {
            InitializeComponent();         
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            listCliente.Items.Clear();

            foreach (Cliente c in clientes)
            {
                listCliente.Items.Add(c);
            }
        }

        public Cliente ObterClienteSelecionado()
        {
            return (Cliente)listCliente.SelectedItem;
        }
    }
}
