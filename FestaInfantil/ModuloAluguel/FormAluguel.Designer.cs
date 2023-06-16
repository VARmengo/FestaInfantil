namespace FestaInfantil.ModuloAluguel
{
    partial class FormAluguel
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
            statusBar = new StatusStrip();
            textoBaixo = new ToolStripStatusLabel();
            labelRodape = new ToolStripStatusLabel();
            lblId = new Label();
            txtId = new TextBox();
            lblFesta = new Label();
            lblCliente = new Label();
            cmbFesta = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            rdbClienteNovo = new RadioButton();
            rdbClienteAntigo = new RadioButton();
            controlBotoes = new Botoes();
            lblTipoCliente = new Label();
            cmbTema = new ComboBox();
            lblTema = new Label();
            dateTimePicker2 = new DateTimePicker();
            lblHorarioInicio = new Label();
            dateTimePicker3 = new DateTimePicker();
            lblHorarioFinal = new Label();
            txtTotalAluguel = new TextBox();
            lblValorFinalAluguel = new Label();
            textBox1 = new TextBox();
            lblValorTotalAluguel = new Label();
            groupBox1 = new GroupBox();
            statusBar.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // statusBar
            // 
            statusBar.Items.AddRange(new ToolStripItem[] { textoBaixo, labelRodape });
            statusBar.Location = new Point(0, 490);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(754, 22);
            statusBar.TabIndex = 7;
            statusBar.Text = "statusStrip1";
            // 
            // textoBaixo
            // 
            textoBaixo.Name = "textoBaixo";
            textoBaixo.Size = new Size(0, 17);
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(0, 17);
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(80, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 8;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(113, 40);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(52, 23);
            txtId.TabIndex = 9;
            // 
            // lblFesta
            // 
            lblFesta.AutoSize = true;
            lblFesta.Location = new Point(59, 138);
            lblFesta.Name = "lblFesta";
            lblFesta.Size = new Size(37, 15);
            lblFesta.TabIndex = 10;
            lblFesta.Text = "Festa:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(53, 80);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 12;
            lblCliente.Text = "Cliente:";
            // 
            // cmbFesta
            // 
            cmbFesta.FormattingEnabled = true;
            cmbFesta.Location = new Point(113, 133);
            cmbFesta.Name = "cmbFesta";
            cmbFesta.Size = new Size(211, 23);
            cmbFesta.TabIndex = 16;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(113, 78);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(391, 86);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 18;
            label1.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(435, 80);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(82, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // rdbClienteNovo
            // 
            rdbClienteNovo.AutoSize = true;
            rdbClienteNovo.Location = new Point(148, 22);
            rdbClienteNovo.Name = "rdbClienteNovo";
            rdbClienteNovo.Size = new Size(94, 19);
            rdbClienteNovo.TabIndex = 20;
            rdbClienteNovo.TabStop = true;
            rdbClienteNovo.Text = "Cliente Novo";
            rdbClienteNovo.UseVisualStyleBackColor = true;
            // 
            // rdbClienteAntigo
            // 
            rdbClienteAntigo.AutoSize = true;
            rdbClienteAntigo.Location = new Point(252, 22);
            rdbClienteAntigo.Name = "rdbClienteAntigo";
            rdbClienteAntigo.Size = new Size(101, 19);
            rdbClienteAntigo.TabIndex = 21;
            rdbClienteAntigo.TabStop = true;
            rdbClienteAntigo.Text = "Cliente Antigo";
            rdbClienteAntigo.UseVisualStyleBackColor = true;
            // 
            // controlBotoes
            // 
            controlBotoes.BackColor = Color.Transparent;
            controlBotoes.Location = new Point(254, 396);
            controlBotoes.Name = "controlBotoes";
            controlBotoes.Size = new Size(216, 91);
            controlBotoes.TabIndex = 22;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(455, 165);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(90, 15);
            lblTipoCliente.TabIndex = 23;
            lblTipoCliente.Text = "Tipo do Cliente:";
            // 
            // cmbTema
            // 
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(435, 42);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(256, 23);
            cmbTema.TabIndex = 25;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Location = new Point(391, 47);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(38, 15);
            lblTema.TabIndex = 24;
            lblTema.Text = "Tema:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(435, 133);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(82, 23);
            dateTimePicker2.TabIndex = 27;
            // 
            // lblHorarioInicio
            // 
            lblHorarioInicio.Location = new Point(374, 128);
            lblHorarioInicio.Name = "lblHorarioInicio";
            lblHorarioInicio.Size = new Size(51, 37);
            lblHorarioInicio.TabIndex = 26;
            lblHorarioInicio.Text = "Horário Inicio:";
            lblHorarioInicio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(605, 133);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(86, 23);
            dateTimePicker3.TabIndex = 29;
            // 
            // lblHorarioFinal
            // 
            lblHorarioFinal.Location = new Point(548, 128);
            lblHorarioFinal.Name = "lblHorarioFinal";
            lblHorarioFinal.Size = new Size(51, 37);
            lblHorarioFinal.TabIndex = 30;
            lblHorarioFinal.Text = "Horário Final:";
            lblHorarioFinal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTotalAluguel
            // 
            txtTotalAluguel.Location = new Point(213, 81);
            txtTotalAluguel.Name = "txtTotalAluguel";
            txtTotalAluguel.Size = new Size(140, 23);
            txtTotalAluguel.TabIndex = 32;
            // 
            // lblValorFinalAluguel
            // 
            lblValorFinalAluguel.AutoSize = true;
            lblValorFinalAluguel.Location = new Point(144, 122);
            lblValorFinalAluguel.Name = "lblValorFinalAluguel";
            lblValorFinalAluguel.Size = new Size(62, 15);
            lblValorFinalAluguel.TabIndex = 35;
            lblValorFinalAluguel.Text = "Valor final:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 34;
            // 
            // lblValorTotalAluguel
            // 
            lblValorTotalAluguel.AutoSize = true;
            lblValorTotalAluguel.Location = new Point(148, 84);
            lblValorTotalAluguel.Name = "lblValorTotalAluguel";
            lblValorTotalAluguel.Size = new Size(63, 15);
            lblValorTotalAluguel.TabIndex = 33;
            lblValorTotalAluguel.Text = "Valor total:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblValorFinalAluguel);
            groupBox1.Controls.Add(rdbClienteAntigo);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtTotalAluguel);
            groupBox1.Controls.Add(lblValorTotalAluguel);
            groupBox1.Controls.Add(rdbClienteNovo);
            groupBox1.Location = new Point(113, 202);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(578, 178);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculo Aluguel";
            // 
            // FormAluguel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 512);
            Controls.Add(groupBox1);
            Controls.Add(lblHorarioFinal);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(lblHorarioInicio);
            Controls.Add(cmbTema);
            Controls.Add(lblTema);
            Controls.Add(lblTipoCliente);
            Controls.Add(controlBotoes);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(cmbFesta);
            Controls.Add(lblCliente);
            Controls.Add(lblFesta);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(statusBar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAluguel";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Aluguel";
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusBar;
        private ToolStripStatusLabel textoBaixo;
        private ToolStripStatusLabel labelRodape;
        private Label lblId;
        private TextBox txtId;
        private Label lblFesta;
        private Label lblCliente;
        private ComboBox cmbFesta;
        private ComboBox comboBox2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private RadioButton rdbClienteNovo;
        private RadioButton rdbClienteAntigo;
        private Botoes controlBotoes;
        private Label lblTipoCliente;
        private ComboBox cmbTema;
        private Label lblTema;
        private DateTimePicker dateTimePicker2;
        private Label lblHorarioInicio;
        private DateTimePicker dateTimePicker3;
        private Label lblHorarioFinal;
        private TextBox txtTotalAluguel;
        private Label lblValorFinalAluguel;
        private TextBox textBox1;
        private Label lblValorTotalAluguel;
        private GroupBox groupBox1;
    }
}