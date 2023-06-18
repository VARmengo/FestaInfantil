namespace FestaInfantil
{
    partial class TelaFestaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFestaForm));
            labelEndereço = new Label();
            txtEndereco = new TextBox();
            cmbTema = new ComboBox();
            labelTema = new Label();
            labelData = new Label();
            txtData = new DateTimePicker();
            panelFesta = new Panel();
            txtHoraFinal = new DateTimePicker();
            txtHoraInicial = new DateTimePicker();
            labelcliente = new Label();
            cmbCliente = new ComboBox();
            labelID = new Label();
            txtId = new TextBox();
            labelHoraF = new Label();
            labelHoraI = new Label();
            controlBotoes = new Botoes();
            titelFesta = new Label();
            panelTema = new Panel();
            listItensTema = new ListBox();
            labelitens = new Label();
            panelFesta.SuspendLayout();
            panelTema.SuspendLayout();
            SuspendLayout();
            // 
            // labelEndereço
            // 
            labelEndereço.AutoSize = true;
            labelEndereço.BackColor = Color.Transparent;
            labelEndereço.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEndereço.Location = new Point(14, 178);
            labelEndereço.Name = "labelEndereço";
            labelEndereço.Size = new Size(80, 18);
            labelEndereço.TabIndex = 5;
            labelEndereço.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.White;
            txtEndereco.Location = new Point(100, 178);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(220, 23);
            txtEndereco.TabIndex = 3;
            // 
            // cmbTema
            // 
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(33, 48);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(190, 23);
            cmbTema.TabIndex = 4;
            cmbTema.SelectedIndexChanged += cmbTema_SelectedIndexChanged;
            // 
            // labelTema
            // 
            labelTema.AutoSize = true;
            labelTema.BackColor = Color.Transparent;
            labelTema.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTema.Location = new Point(33, 23);
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
            labelData.Location = new Point(48, 85);
            labelData.Name = "labelData";
            labelData.Size = new Size(46, 18);
            labelData.TabIndex = 8;
            labelData.Text = "Data:";
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(100, 85);
            txtData.Name = "txtData";
            txtData.Size = new Size(97, 23);
            txtData.TabIndex = 5;
            // 
            // panelFesta
            // 
            panelFesta.BorderStyle = BorderStyle.FixedSingle;
            panelFesta.Controls.Add(txtHoraFinal);
            panelFesta.Controls.Add(txtHoraInicial);
            panelFesta.Controls.Add(labelcliente);
            panelFesta.Controls.Add(cmbCliente);
            panelFesta.Controls.Add(labelID);
            panelFesta.Controls.Add(txtId);
            panelFesta.Controls.Add(txtEndereco);
            panelFesta.Controls.Add(labelEndereço);
            panelFesta.Controls.Add(labelHoraF);
            panelFesta.Controls.Add(labelHoraI);
            panelFesta.Controls.Add(txtData);
            panelFesta.Controls.Add(labelData);
            panelFesta.Location = new Point(12, 12);
            panelFesta.Name = "panelFesta";
            panelFesta.Size = new Size(408, 241);
            panelFesta.TabIndex = 10;
            panelFesta.Paint += panelFesta_Paint;
            // 
            // txtHoraFinal
            // 
            txtHoraFinal.CustomFormat = "HH:mm";
            txtHoraFinal.Format = DateTimePickerFormat.Custom;
            txtHoraFinal.Location = new Point(100, 147);
            txtHoraFinal.Name = "txtHoraFinal";
            txtHoraFinal.ShowUpDown = true;
            txtHoraFinal.Size = new Size(97, 23);
            txtHoraFinal.TabIndex = 22;
            // 
            // txtHoraInicial
            // 
            txtHoraInicial.CustomFormat = "HH:mm";
            txtHoraInicial.Format = DateTimePickerFormat.Custom;
            txtHoraInicial.Location = new Point(100, 116);
            txtHoraInicial.Name = "txtHoraInicial";
            txtHoraInicial.ShowUpDown = true;
            txtHoraInicial.Size = new Size(97, 23);
            txtHoraInicial.TabIndex = 21;
            // 
            // labelcliente
            // 
            labelcliente.AutoSize = true;
            labelcliente.BackColor = Color.Transparent;
            labelcliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelcliente.Location = new Point(33, 54);
            labelcliente.Name = "labelcliente";
            labelcliente.Size = new Size(61, 18);
            labelcliente.TabIndex = 18;
            labelcliente.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(100, 54);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(131, 23);
            cmbCliente.TabIndex = 17;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.BackColor = Color.Transparent;
            labelID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(67, 23);
            labelID.Name = "labelID";
            labelID.Size = new Size(27, 18);
            labelID.TabIndex = 16;
            labelID.Text = "ID:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.Location = new Point(100, 23);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(33, 23);
            txtId.TabIndex = 15;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // labelHoraF
            // 
            labelHoraF.AutoSize = true;
            labelHoraF.BackColor = Color.Transparent;
            labelHoraF.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHoraF.Location = new Point(6, 147);
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
            labelHoraI.Location = new Point(5, 116);
            labelHoraI.Name = "labelHoraI";
            labelHoraI.Size = new Size(89, 18);
            labelHoraI.TabIndex = 10;
            labelHoraI.Text = "Hora Início: ";
            // 
            // controlBotoes
            // 
            controlBotoes.BackColor = Color.Transparent;
            controlBotoes.Location = new Point(245, 259);
            controlBotoes.Name = "controlBotoes";
            controlBotoes.Size = new Size(216, 91);
            controlBotoes.TabIndex = 11;
            // 
            // titelFesta
            // 
            titelFesta.AutoSize = true;
            titelFesta.BackColor = SystemColors.Control;
            titelFesta.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titelFesta.Location = new Point(16, 9);
            titelFesta.Name = "titelFesta";
            titelFesta.Size = new Size(117, 18);
            titelFesta.TabIndex = 13;
            titelFesta.Text = "Cadastro Festa";
            // 
            // panelTema
            // 
            panelTema.BorderStyle = BorderStyle.FixedSingle;
            panelTema.Controls.Add(listItensTema);
            panelTema.Controls.Add(labelitens);
            panelTema.Controls.Add(labelTema);
            panelTema.Controls.Add(cmbTema);
            panelTema.Location = new Point(440, 12);
            panelTema.Name = "panelTema";
            panelTema.Size = new Size(254, 241);
            panelTema.TabIndex = 14;
            // 
            // listItensTema
            // 
            listItensTema.FormattingEnabled = true;
            listItensTema.ItemHeight = 15;
            listItensTema.Location = new Point(33, 103);
            listItensTema.Name = "listItensTema";
            listItensTema.Size = new Size(142, 124);
            listItensTema.TabIndex = 9;
            // 
            // labelitens
            // 
            labelitens.AutoSize = true;
            labelitens.BackColor = Color.Transparent;
            labelitens.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelitens.Location = new Point(33, 78);
            labelitens.Name = "labelitens";
            labelitens.Size = new Size(108, 18);
            labelitens.TabIndex = 8;
            labelitens.Text = "Itens do Tema:";
            // 
            // TelaFestaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 350);
            ControlBox = false;
            Controls.Add(titelFesta);
            Controls.Add(controlBotoes);
            Controls.Add(panelFesta);
            Controls.Add(panelTema);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaFestaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Festas";
            panelFesta.ResumeLayout(false);
            panelFesta.PerformLayout();
            panelTema.ResumeLayout(false);
            panelTema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelEndereço;
        private TextBox txtEndereco;
        private DateTimePicker txtData;
        private Label labelData;
        private Label labelTema;
        private ComboBox cmbTema;
        private Panel panelFesta;
        private Label labelHoraI;
        private Label labelHoraF;
        private Botoes controlBotoes;
        private Label titelFesta;
        private Label labelID;
        private TextBox txtId;
        private Label labelcliente;
        private ComboBox cmbCliente;
        private Panel panelTema;
        private ListBox listItensTema;
        private Label labelitens;
        private DateTimePicker txtHoraFinal;
        private DateTimePicker txtHoraInicial;
    }
}