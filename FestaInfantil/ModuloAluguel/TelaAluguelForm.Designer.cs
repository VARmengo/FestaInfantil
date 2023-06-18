namespace FestaInfantil.ModuloAluguel
{
    partial class TelaAluguelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            controlBotoes = new Botoes();
            lblId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbFesta = new ComboBox();
            cmbTipoCliente = new ComboBox();
            txtAluguelDesconto = new TextBox();
            txtAluguelTotal = new TextBox();
            label1 = new Label();
            cmbCliente = new ComboBox();
            cmbTema = new ComboBox();
            label6 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // controlBotoes
            // 
            controlBotoes.BackColor = Color.Transparent;
            controlBotoes.Location = new Point(144, 224);
            controlBotoes.Name = "controlBotoes";
            controlBotoes.Size = new Size(216, 91);
            controlBotoes.TabIndex = 12;
            controlBotoes.Load += controlBotoes_Load;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(74, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 14;
            lblId.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 165);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 15;
            label2.Text = "Festa: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 119);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 16;
            label3.Text = "Tipo do Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 119);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 17;
            label4.Text = "Valor Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(244, 165);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 18;
            label5.Text = "Valor com Desconto:";
            // 
            // cmbFesta
            // 
            cmbFesta.FormattingEnabled = true;
            cmbFesta.Location = new Point(102, 162);
            cmbFesta.Name = "cmbFesta";
            cmbFesta.Size = new Size(121, 23);
            cmbFesta.TabIndex = 19;
            // 
            // cmbTipoCliente
            // 
            cmbTipoCliente.FormattingEnabled = true;
            cmbTipoCliente.Location = new Point(102, 116);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(121, 23);
            cmbTipoCliente.TabIndex = 20;
            // 
            // txtAluguelDesconto
            // 
            txtAluguelDesconto.Location = new Point(366, 162);
            txtAluguelDesconto.Name = "txtAluguelDesconto";
            txtAluguelDesconto.Size = new Size(100, 23);
            txtAluguelDesconto.TabIndex = 21;
            // 
            // txtAluguelTotal
            // 
            txtAluguelTotal.Location = new Point(366, 116);
            txtAluguelTotal.Name = "txtAluguelTotal";
            txtAluguelTotal.Size = new Size(100, 23);
            txtAluguelTotal.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 73);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 23;
            label1.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(102, 70);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 24;
            // 
            // cmbTema
            // 
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(366, 70);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(121, 23);
            cmbTema.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 73);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 25;
            label6.Text = "Tema:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.Location = new Point(102, 24);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(33, 23);
            txtId.TabIndex = 27;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 330);
            Controls.Add(txtId);
            Controls.Add(cmbTema);
            Controls.Add(label6);
            Controls.Add(cmbCliente);
            Controls.Add(label1);
            Controls.Add(txtAluguelTotal);
            Controls.Add(txtAluguelDesconto);
            Controls.Add(cmbTipoCliente);
            Controls.Add(cmbFesta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblId);
            Controls.Add(controlBotoes);
            Name = "TelaAluguelForm";
            Text = "Cadastro de Aluguel";
            Load += TelaAluguelForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Botoes controlBotoes;
        private Label lblId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbFesta;
        private ComboBox cmbTipoCliente;
        private TextBox txtAluguelDesconto;
        private TextBox txtAluguelTotal;
        private Label label1;
        private ComboBox cmbCliente;
        private ComboBox cmbTema;
        private Label label6;
        private TextBox txtId;
    }
}