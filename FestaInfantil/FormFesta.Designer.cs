namespace FestaInfantil
{
    partial class FormFesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFesta));
            txtNome = new TextBox();
            labelNome = new Label();
            mtbTelefone = new MaskedTextBox();
            labelTelefone = new Label();
            labelEndereço = new Label();
            txtEndereco = new TextBox();
            panelCliente = new Panel();
            labelCPF = new Label();
            mtbCPF = new MaskedTextBox();
            cmbTema = new ComboBox();
            labelTema = new Label();
            labelData = new Label();
            dtpData = new DateTimePicker();
            panelFesta = new Panel();
            mkbHoraF = new MaskedTextBox();
            mtbHoraI = new MaskedTextBox();
            labelHoraF = new Label();
            labelHoraI = new Label();
            controlBotoes = new Botoes();
            titleCliente = new Label();
            titelFesta = new Label();
            panelCliente.SuspendLayout();
            panelFesta.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Location = new Point(69, 16);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(292, 23);
            txtNome.TabIndex = 0;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.Transparent;
            labelNome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(9, 16);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(54, 18);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome:";
            // 
            // mtbTelefone
            // 
            mtbTelefone.BackColor = Color.White;
            mtbTelefone.Location = new Point(85, 45);
            mtbTelefone.Mask = "(00)00000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(92, 23);
            mtbTelefone.TabIndex = 1;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.BackColor = Color.Transparent;
            labelTelefone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefone.Location = new Point(9, 50);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(70, 18);
            labelTelefone.TabIndex = 3;
            labelTelefone.Text = "Telefone:";
            // 
            // labelEndereço
            // 
            labelEndereço.AutoSize = true;
            labelEndereço.BackColor = Color.Transparent;
            labelEndereço.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEndereço.Location = new Point(17, 17);
            labelEndereço.Name = "labelEndereço";
            labelEndereço.Size = new Size(80, 18);
            labelEndereço.TabIndex = 5;
            labelEndereço.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.White;
            txtEndereco.Location = new Point(103, 17);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(292, 23);
            txtEndereco.TabIndex = 3;
            // 
            // panelCliente
            // 
            panelCliente.BorderStyle = BorderStyle.FixedSingle;
            panelCliente.Controls.Add(labelCPF);
            panelCliente.Controls.Add(mtbCPF);
            panelCliente.Controls.Add(labelNome);
            panelCliente.Controls.Add(txtNome);
            panelCliente.Controls.Add(labelTelefone);
            panelCliente.Controls.Add(mtbTelefone);
            panelCliente.Location = new Point(12, 12);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(408, 115);
            panelCliente.TabIndex = 6;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.BackColor = Color.Transparent;
            labelCPF.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCPF.Location = new Point(9, 79);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(45, 18);
            labelCPF.TabIndex = 5;
            labelCPF.Text = "CPF:";
            // 
            // mtbCPF
            // 
            mtbCPF.BackColor = Color.White;
            mtbCPF.Location = new Point(60, 74);
            mtbCPF.Mask = "000.000.000-00";
            mtbCPF.Name = "mtbCPF";
            mtbCPF.Size = new Size(90, 23);
            mtbCPF.TabIndex = 2;
            // 
            // cmbTema
            // 
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(69, 44);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(131, 23);
            cmbTema.TabIndex = 4;
            // 
            // labelTema
            // 
            labelTema.AutoSize = true;
            labelTema.BackColor = Color.Transparent;
            labelTema.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTema.Location = new Point(17, 44);
            labelTema.Name = "labelTema";
            labelTema.Size = new Size(50, 18);
            labelTema.TabIndex = 7;
            labelTema.Text = "Tema:";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.BackColor = Color.Transparent;
            labelData.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelData.Location = new Point(17, 71);
            labelData.Name = "labelData";
            labelData.Size = new Size(46, 18);
            labelData.TabIndex = 8;
            labelData.Text = "Data:";
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(69, 71);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(97, 23);
            dtpData.TabIndex = 5;
            // 
            // panelFesta
            // 
            panelFesta.BorderStyle = BorderStyle.FixedSingle;
            panelFesta.Controls.Add(mkbHoraF);
            panelFesta.Controls.Add(mtbHoraI);
            panelFesta.Controls.Add(labelHoraF);
            panelFesta.Controls.Add(labelEndereço);
            panelFesta.Controls.Add(labelHoraI);
            panelFesta.Controls.Add(txtEndereco);
            panelFesta.Controls.Add(labelTema);
            panelFesta.Controls.Add(dtpData);
            panelFesta.Controls.Add(cmbTema);
            panelFesta.Controls.Add(labelData);
            panelFesta.Location = new Point(12, 149);
            panelFesta.Name = "panelFesta";
            panelFesta.Size = new Size(408, 172);
            panelFesta.TabIndex = 10;
            // 
            // mkbHoraF
            // 
            mkbHoraF.Location = new Point(100, 132);
            mkbHoraF.Mask = "00:00";
            mkbHoraF.Name = "mkbHoraF";
            mkbHoraF.Size = new Size(38, 23);
            mkbHoraF.TabIndex = 14;
            // 
            // mtbHoraI
            // 
            mtbHoraI.Location = new Point(100, 106);
            mtbHoraI.Mask = "00:00";
            mtbHoraI.Name = "mtbHoraI";
            mtbHoraI.Size = new Size(38, 23);
            mtbHoraI.TabIndex = 13;
            // 
            // labelHoraF
            // 
            labelHoraF.AutoSize = true;
            labelHoraF.BackColor = Color.Transparent;
            labelHoraF.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHoraF.Location = new Point(18, 132);
            labelHoraF.Name = "labelHoraF";
            labelHoraF.Size = new Size(88, 18);
            labelHoraF.TabIndex = 12;
            labelHoraF.Text = "Hora Final: ";
            // 
            // labelHoraI
            // 
            labelHoraI.AutoSize = true;
            labelHoraI.BackColor = Color.Transparent;
            labelHoraI.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHoraI.Location = new Point(17, 106);
            labelHoraI.Name = "labelHoraI";
            labelHoraI.Size = new Size(89, 18);
            labelHoraI.TabIndex = 10;
            labelHoraI.Text = "Hora Início: ";
            // 
            // controlBotoes
            // 
            controlBotoes.BackColor = Color.Transparent;
            controlBotoes.Location = new Point(108, 327);
            controlBotoes.Name = "controlBotoes";
            controlBotoes.Size = new Size(216, 91);
            controlBotoes.TabIndex = 11;
            // 
            // titleCliente
            // 
            titleCliente.AutoSize = true;
            titleCliente.BackColor = SystemColors.Control;
            titleCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleCliente.Location = new Point(16, 8);
            titleCliente.Name = "titleCliente";
            titleCliente.Size = new Size(126, 18);
            titleCliente.TabIndex = 12;
            titleCliente.Text = "Cadastro Cliente";
            // 
            // titelFesta
            // 
            titelFesta.AutoSize = true;
            titelFesta.BackColor = SystemColors.Control;
            titelFesta.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titelFesta.Location = new Point(16, 146);
            titelFesta.Name = "titelFesta";
            titelFesta.Size = new Size(117, 18);
            titelFesta.TabIndex = 13;
            titelFesta.Text = "Cadastro Festa";
            // 
            // FormFesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 420);
            ControlBox = false;
            Controls.Add(titelFesta);
            Controls.Add(titleCliente);
            Controls.Add(controlBotoes);
            Controls.Add(panelFesta);
            Controls.Add(panelCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormFesta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Festas";
            panelCliente.ResumeLayout(false);
            panelCliente.PerformLayout();
            panelFesta.ResumeLayout(false);
            panelFesta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label labelNome;
        private MaskedTextBox mtbTelefone;
        private Label labelTelefone;
        private Label labelEndereço;
        private TextBox txtEndereco;
        private Panel panelCliente;
        private DateTimePicker dtpData;
        private Label labelData;
        private Label labelTema;
        private ComboBox cmbTema;
        private Panel panelFesta;
        private Label labelHoraI;
        private Label labelHoraF;
        private Label labelCPF;
        private MaskedTextBox mtbCPF;
        private MaskedTextBox mkbHoraF;
        private MaskedTextBox mtbHoraI;
        private Botoes controlBotoes;
        private Label titelFesta;
        private Label titleCliente;
    }
}