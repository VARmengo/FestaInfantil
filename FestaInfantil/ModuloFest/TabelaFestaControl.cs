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

namespace FestaInfantil.ModuloFest
{
    public partial class TabelaFestaControl : UserControl
    {

        public TabelaFestaControl()
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
                    Name = "endereço",
                    HeaderText = "Endereço"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cliente",
                    HeaderText = "Cliente"
                },

                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "inicio",
                    HeaderText = "Inicio"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "fim",
                    HeaderText = "Fim"
                }


            };

            grid.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Festa> festas)
        {
            grid.Rows.Clear();

            foreach (Festa f in festas)
            {
                grid.Rows.Add(f.id, f.cliente.nome, f.endereco, f.dataCriacao, f.horaInicial, f.horaFinal);
            }
        }

        public int ObterIdSelecionado()
        {
            int id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
