using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
