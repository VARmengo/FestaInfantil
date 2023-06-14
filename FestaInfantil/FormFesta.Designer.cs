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
            labelEndereço = new Label();
            txtEndereco = new TextBox();
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
            titelFesta = new Label();
            labelID = new Label();
            txtId = new TextBox();
            panelFesta.SuspendLayout();
            SuspendLayout();
            // 
            // labelEndereço
            // 
            labelEndereço.AutoSize = true;
            labelEndereço.BackColor = Color.Transparent;
            labelEndereço.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEndereço.Location = new Point(14, 50);
            labelEndereço.Name = "labelEndereço";
            labelEndereço.Size = new Size(80, 18);
            labelEndereço.TabIndex = 5;
            labelEndereço.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.White;
            txtEndereco.Location = new Point(100, 50);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(292, 23);
            txtEndereco.TabIndex = 3;
            // 
            // cmbTema
            // 
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(66, 77);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(131, 23);
            cmbTema.TabIndex = 4;
            // 
            // labelTema
            // 
            labelTema.AutoSize = true;
            labelTema.BackColor = Color.Transparent;
            labelTema.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTema.Location = new Point(14, 77);
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
            labelData.Location = new Point(14, 104);
            labelData.Name = "labelData";
            labelData.Size = new Size(46, 18);
            labelData.TabIndex = 8;
            labelData.Text = "Data:";
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(66, 104);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(97, 23);
            dtpData.TabIndex = 5;
            // 
            // panelFesta
            // 
            panelFesta.BorderStyle = BorderStyle.FixedSingle;
            panelFesta.Controls.Add(labelID);
            panelFesta.Controls.Add(txtId);
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
            panelFesta.Location = new Point(12, 12);
            panelFesta.Name = "panelFesta";
            panelFesta.Size = new Size(408, 206);
            panelFesta.TabIndex = 10;
            // 
            // mkbHoraF
            // 
            mkbHoraF.Location = new Point(97, 165);
            mkbHoraF.Mask = "00:00";
            mkbHoraF.Name = "mkbHoraF";
            mkbHoraF.Size = new Size(38, 23);
            mkbHoraF.TabIndex = 14;
            // 
            // mtbHoraI
            // 
            mtbHoraI.Location = new Point(97, 139);
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
            labelHoraF.Location = new Point(15, 165);
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
            labelHoraI.Location = new Point(14, 139);
            labelHoraI.Name = "labelHoraI";
            labelHoraI.Size = new Size(89, 18);
            labelHoraI.TabIndex = 10;
            labelHoraI.Text = "Hora Início: ";
            // 
            // controlBotoes
            // 
            controlBotoes.BackColor = Color.Transparent;
            controlBotoes.Location = new Point(108, 224);
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
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.BackColor = Color.Transparent;
            labelID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(15, 23);
            labelID.Name = "labelID";
            labelID.Size = new Size(27, 18);
            labelID.TabIndex = 16;
            labelID.Text = "ID:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.Location = new Point(48, 23);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(33, 23);
            txtId.TabIndex = 15;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // FormFesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 323);
            ControlBox = false;
            Controls.Add(titelFesta);
            Controls.Add(controlBotoes);
            Controls.Add(panelFesta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormFesta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Festas";
            panelFesta.ResumeLayout(false);
            panelFesta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelEndereço;
        private TextBox txtEndereco;
        private DateTimePicker dtpData;
        private Label labelData;
        private Label labelTema;
        private ComboBox cmbTema;
        private Panel panelFesta;
        private Label labelHoraI;
        private Label labelHoraF;
        private MaskedTextBox mkbHoraF;
        private MaskedTextBox mtbHoraI;
        private Botoes controlBotoes;
        private Label titelFesta;
        private Label labelID;
        private TextBox txtId;
    }
}