namespace FestaInfantil
{
    partial class FormTema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTema));
            labelNome = new Label();
            textBox1 = new TextBox();
            labelItens = new Label();
            controlBotoes = new Botoes();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(12, 26);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 18);
            labelNome.TabIndex = 0;
            labelNome.Text = "Tema:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 0;
            // 
            // labelItens
            // 
            labelItens.AutoSize = true;
            labelItens.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelItens.Location = new Point(12, 63);
            labelItens.Name = "labelItens";
            labelItens.Size = new Size(44, 18);
            labelItens.TabIndex = 2;
            labelItens.Text = "Itens:";
            // 
            // controlBotoes
            // 
            controlBotoes.BackColor = Color.Transparent;
            controlBotoes.Location = new Point(151, 128);
            controlBotoes.Name = "controlBotoes";
            controlBotoes.Size = new Size(216, 91);
            controlBotoes.TabIndex = 3;
            // 
            // FormTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 220);
            Controls.Add(controlBotoes);
            Controls.Add(labelItens);
            Controls.Add(textBox1);
            Controls.Add(labelNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTema";
            Text = "Cadastro de Temas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textBox1;
        private Label labelItens;
        private Botoes controlBotoes;
    }
}