namespace FestaInfantil
{
    partial class TelaTemaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTemaForm));
            labelNome = new Label();
            txtTema = new TextBox();
            labelItens = new Label();
            controlBotoes = new Botoes();
            chbConfeitaria = new CheckBox();
            chbSalgadinhos = new CheckBox();
            chbDecoracao = new CheckBox();
            chbLembrancas = new CheckBox();
            chbDescartaveis = new CheckBox();
            chbFantasias = new CheckBox();
            labelID = new Label();
            txtId = new TextBox();
            panel = new Panel();
            titleTemas = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(11, 47);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 18);
            labelNome.TabIndex = 0;
            labelNome.Text = "Tema:";
            // 
            // txtTema
            // 
            txtTema.Location = new Point(63, 47);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(209, 23);
            txtTema.TabIndex = 0;
            // 
            // labelItens
            // 
            labelItens.AutoSize = true;
            labelItens.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelItens.Location = new Point(11, 81);
            labelItens.Name = "labelItens";
            labelItens.Size = new Size(44, 18);
            labelItens.TabIndex = 2;
            labelItens.Text = "Itens:";
            // 
            // controlBotoes
            // 
            controlBotoes.BackColor = Color.Transparent;
            controlBotoes.Location = new Point(128, 178);
            controlBotoes.Name = "controlBotoes";
            controlBotoes.Size = new Size(216, 91);
            controlBotoes.TabIndex = 3;
            // 
            // chbConfeitaria
            // 
            chbConfeitaria.AutoSize = true;
            chbConfeitaria.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbConfeitaria.Location = new Point(63, 83);
            chbConfeitaria.Name = "chbConfeitaria";
            chbConfeitaria.Size = new Size(86, 19);
            chbConfeitaria.TabIndex = 4;
            chbConfeitaria.Text = "Confeitaria";
            chbConfeitaria.UseVisualStyleBackColor = true;
            // 
            // chbSalgadinhos
            // 
            chbSalgadinhos.AutoSize = true;
            chbSalgadinhos.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbSalgadinhos.Location = new Point(63, 108);
            chbSalgadinhos.Name = "chbSalgadinhos";
            chbSalgadinhos.Size = new Size(99, 19);
            chbSalgadinhos.TabIndex = 5;
            chbSalgadinhos.Text = "Salgadinhos ";
            chbSalgadinhos.UseVisualStyleBackColor = true;
            // 
            // chbDecoracao
            // 
            chbDecoracao.AutoSize = true;
            chbDecoracao.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbDecoracao.Location = new Point(168, 83);
            chbDecoracao.Name = "chbDecoracao";
            chbDecoracao.Size = new Size(86, 19);
            chbDecoracao.TabIndex = 6;
            chbDecoracao.Text = "Decoração";
            chbDecoracao.UseVisualStyleBackColor = true;
            // 
            // chbLembrancas
            // 
            chbLembrancas.AutoSize = true;
            chbLembrancas.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbLembrancas.Location = new Point(168, 108);
            chbLembrancas.Name = "chbLembrancas";
            chbLembrancas.Size = new Size(113, 19);
            chbLembrancas.TabIndex = 7;
            chbLembrancas.Text = "Lembrancinhas";
            chbLembrancas.UseVisualStyleBackColor = true;
            // 
            // chbDescartaveis
            // 
            chbDescartaveis.AutoSize = true;
            chbDescartaveis.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbDescartaveis.Location = new Point(286, 83);
            chbDescartaveis.Name = "chbDescartaveis";
            chbDescartaveis.Size = new Size(98, 19);
            chbDescartaveis.TabIndex = 8;
            chbDescartaveis.Text = "Descartáveis";
            chbDescartaveis.UseVisualStyleBackColor = true;
            // 
            // chbFantasias
            // 
            chbFantasias.AutoSize = true;
            chbFantasias.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chbFantasias.Location = new Point(286, 108);
            chbFantasias.Name = "chbFantasias";
            chbFantasias.Size = new Size(81, 19);
            chbFantasias.TabIndex = 9;
            chbFantasias.Text = "Fantasias";
            chbFantasias.UseVisualStyleBackColor = true;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(11, 17);
            labelID.Name = "labelID";
            labelID.Size = new Size(27, 18);
            labelID.TabIndex = 10;
            labelID.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(63, 17);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(45, 23);
            txtId.TabIndex = 11;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // panel
            // 
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(labelID);
            panel.Controls.Add(chbFantasias);
            panel.Controls.Add(txtId);
            panel.Controls.Add(chbDescartaveis);
            panel.Controls.Add(txtTema);
            panel.Controls.Add(chbLembrancas);
            panel.Controls.Add(labelNome);
            panel.Controls.Add(chbDecoracao);
            panel.Controls.Add(labelItens);
            panel.Controls.Add(chbSalgadinhos);
            panel.Controls.Add(chbConfeitaria);
            panel.Location = new Point(9, 21);
            panel.Name = "panel";
            panel.Size = new Size(451, 151);
            panel.TabIndex = 12;
            // 
            // titleTemas
            // 
            titleTemas.AutoSize = true;
            titleTemas.BackColor = SystemColors.Control;
            titleTemas.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleTemas.Location = new Point(21, 9);
            titleTemas.Name = "titleTemas";
            titleTemas.Size = new Size(115, 18);
            titleTemas.TabIndex = 14;
            titleTemas.Text = "Cadastro Tema";
            // 
            // FormTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 277);
            ControlBox = false;
            Controls.Add(titleTemas);
            Controls.Add(controlBotoes);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Temas";
            Load += FormTema_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox txtTema;
        private Label labelItens;
        private Botoes controlBotoes;
        private CheckBox chbConfeitaria;
        private CheckBox chbSalgadinhos;
        private CheckBox chbDecoracao;
        private CheckBox chbLembrancas;
        private CheckBox chbDescartaveis;
        private CheckBox chbFantasias;
        private Label labelID;
        private TextBox txtId;
        private Panel panel;
        private Label titleTemas;
    }
}