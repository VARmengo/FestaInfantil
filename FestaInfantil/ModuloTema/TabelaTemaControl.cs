using FestaInfantil.ModuloClientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestaInfantil.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
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
                    Name = "tema",
                    HeaderText = "Tema"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "itens",
                    HeaderText = "Itens"
                },
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Tema> temas)
        {
            grid.Rows.Clear();


            foreach (Tema t in temas)
            {
                List<string> itemTexts = t.itemsDeTema.Select(item => item.Nome).ToList();
                string itemsText = string.Join(", ", itemTexts);

                grid.Rows.Add(t.id, t.tema, itemsText);
            }
        }

        public int ObterIdSelecionado()
        {
            int id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
