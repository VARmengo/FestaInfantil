namespace FestaInfantil
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            festaToolStripMenuItem = new ToolStripMenuItem();
            temasToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            tspBtns = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            labelTitle = new ToolStripLabel();
            statusBar = new StatusStrip();
            textoBaixo = new ToolStripStatusLabel();
            labelRodape = new ToolStripStatusLabel();
            panelRegistros = new Panel();
            aluguelToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            tspBtns.SuspendLayout();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(833, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, festaToolStripMenuItem, temasToolStripMenuItem, aluguelToolStripMenuItem });
            cadastrosToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(78, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(121, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // festaToolStripMenuItem
            // 
            festaToolStripMenuItem.Name = "festaToolStripMenuItem";
            festaToolStripMenuItem.Size = new Size(121, 22);
            festaToolStripMenuItem.Text = "Festa";
            // 
            // temasToolStripMenuItem
            // 
            temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            temasToolStripMenuItem.Size = new Size(121, 22);
            temasToolStripMenuItem.Text = "Temas";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(40, 20);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // tspBtns
            // 
            tspBtns.GripMargin = new Padding(7);
            tspBtns.ImageScalingSize = new Size(24, 24);
            tspBtns.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, labelTitle });
            tspBtns.Location = new Point(0, 24);
            tspBtns.Name = "tspBtns";
            tspBtns.Padding = new Padding(0);
            tspBtns.Size = new Size(833, 31);
            tspBtns.TabIndex = 1;
            tspBtns.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = Properties.Resources.add;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(28, 28);
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.edit;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(28, 28);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.delete;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(28, 28);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // labelTitle
            // 
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(74, 28);
            labelTitle.Text = "Festa Infantil";
            // 
            // statusBar
            // 
            statusBar.Items.AddRange(new ToolStripItem[] { textoBaixo, labelRodape });
            statusBar.Location = new Point(0, 422);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(833, 22);
            statusBar.TabIndex = 3;
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
            // panelRegistros
            // 
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 55);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(833, 367);
            panelRegistros.TabIndex = 4;
            // 
            // aluguelToolStripMenuItem
            // 
            aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            aluguelToolStripMenuItem.Size = new Size(180, 22);
            aluguelToolStripMenuItem.Text = "Aluguel";
            aluguelToolStripMenuItem.Click += aluguelToolStripMenuItem_Click_1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 444);
            Controls.Add(panelRegistros);
            Controls.Add(statusBar);
            Controls.Add(tspBtns);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Festa Infantil 0.1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tspBtns.ResumeLayout(false);
            tspBtns.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem festaToolStripMenuItem;
        private ToolStripMenuItem temasToolStripMenuItem;
        private ToolStrip tspBtns;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private StatusStrip statusBar;
        private ToolStripStatusLabel textoBaixo;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private Panel panelRegistros;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel labelTitle;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripStatusLabel labelRodape;
        private ToolStripMenuItem aluguelToolStripMenuItem;
    }
}