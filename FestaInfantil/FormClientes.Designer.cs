namespace FestaInfantil
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            panelCliente = new Panel();
            labelCPF = new Label();
            mtbCPF = new MaskedTextBox();
            labelNome = new Label();
            txtNome = new TextBox();
            labelTelefone = new Label();
            mtbTelefone = new MaskedTextBox();
            titleCliente = new Label();
            botoes = new Botoes();
            panelCliente.SuspendLayout();
            SuspendLayout();
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
            panelCliente.Location = new Point(15, 12);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(408, 115);
            panelCliente.TabIndex = 7;
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
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Location = new Point(69, 16);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(292, 23);
            txtNome.TabIndex = 0;
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
            // mtbTelefone
            // 
            mtbTelefone.BackColor = Color.White;
            mtbTelefone.Location = new Point(85, 45);
            mtbTelefone.Mask = "(00)00000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(92, 23);
            mtbTelefone.TabIndex = 1;
            // 
            // titleCliente
            // 
            titleCliente.AutoSize = true;
            titleCliente.BackColor = SystemColors.Control;
            titleCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleCliente.Location = new Point(22, 8);
            titleCliente.Name = "titleCliente";
            titleCliente.Size = new Size(126, 18);
            titleCliente.TabIndex = 13;
            titleCliente.Text = "Cadastro Cliente";
            // 
            // botoes
            // 
            botoes.BackColor = Color.Transparent;
            botoes.Location = new Point(101, 133);
            botoes.Name = "botoes";
            botoes.Size = new Size(216, 91);
            botoes.TabIndex = 14;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 232);
            ControlBox = false;
            Controls.Add(botoes);
            Controls.Add(titleCliente);
            Controls.Add(panelCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormClientes";
            Text = "Cadastro de Clientes";
            panelCliente.ResumeLayout(false);
            panelCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCliente;
        private Label labelCPF;
        private MaskedTextBox mtbCPF;
        private Label labelNome;
        private TextBox txtNome;
        private Label labelTelefone;
        private MaskedTextBox mtbTelefone;
        private Label titleCliente;
        private Botoes botoes;
    }
}