using FestaInfantil.ModuloFest;

namespace FestaInfantil.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
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
                    Name = "cliente",
                    HeaderText = "Cliente"
                },
                 new DataGridViewTextBoxColumn()
                {
                    Name = "tema",
                    HeaderText = "Tema"
                },
                 new DataGridViewTextBoxColumn()
                {
                    Name = "tipoCliente",
                    HeaderText = "Tipo do Cliente"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valorAluguelCompleto",
                    HeaderText = "Valor aluguel"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valorAluguelDesconto",
                    HeaderText = "Valor com Desconto"
                },
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (Aluguel aluguel in alugueis)
            {
                grid.Rows.Add(aluguel.id, aluguel.festa.cliente.nome, aluguel.festa.tema.tema, aluguel.tipoCliente, aluguel.valorAluguelCompleto, aluguel.valorAluguelDesconto);
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
