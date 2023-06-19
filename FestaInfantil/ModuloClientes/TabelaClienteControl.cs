

using FestaInfantil.Dominio.ModuloClientes;

namespace FestaInfantil.ModuloClientes
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
        {
            InitializeComponent();

            ConfigurarColunas();
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "ID"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cpf",
                    HeaderText = "CPF"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();

            foreach (Cliente c in clientes)
            {
                grid.Rows.Add(c.id, c.nome, c.telefone, c.cpf);
            }
        }

        public int ObterIdSelecionado()
        {
            if (grid.Rows.Count == 0)
            {
                return 0;
            }
            int id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
