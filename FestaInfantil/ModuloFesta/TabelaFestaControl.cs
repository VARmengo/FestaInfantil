﻿using FestaInfantil.Dominio.ModuloFest;
using FestaInfantil.ModuloClientes;

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
                    Name = "endereço",
                    HeaderText = "Endereço"
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
                grid.Rows.Add(f.id, f.cliente.nome, f.tema.tema, f.endereco, f.dataCriacao, f.horaInicial, f.horaFinal);
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
