namespace Teste2.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            autocarrosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarNovoToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            colaboradoresToolStripMenuItem = new ToolStripMenuItem();
            cadastrarNovoToolStripMenuItem1 = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            novoUsuárioToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { autocarrosToolStripMenuItem, colaboradoresToolStripMenuItem, usuáriosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1022, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // autocarrosToolStripMenuItem
            // 
            autocarrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarNovoToolStripMenuItem, listarToolStripMenuItem });
            autocarrosToolStripMenuItem.Name = "autocarrosToolStripMenuItem";
            autocarrosToolStripMenuItem.Size = new Size(95, 24);
            autocarrosToolStripMenuItem.Text = "Autocarros";
            // 
            // cadastrarNovoToolStripMenuItem
            // 
            cadastrarNovoToolStripMenuItem.Name = "cadastrarNovoToolStripMenuItem";
            cadastrarNovoToolStripMenuItem.Size = new Size(195, 26);
            cadastrarNovoToolStripMenuItem.Text = "Cadastrar Novo";
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(195, 26);
            listarToolStripMenuItem.Text = "Listar";
            // 
            // colaboradoresToolStripMenuItem
            // 
            colaboradoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarNovoToolStripMenuItem1, listarToolStripMenuItem1 });
            colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            colaboradoresToolStripMenuItem.Size = new Size(121, 24);
            colaboradoresToolStripMenuItem.Text = "Colaboradores";
            // 
            // cadastrarNovoToolStripMenuItem1
            // 
            cadastrarNovoToolStripMenuItem1.Name = "cadastrarNovoToolStripMenuItem1";
            cadastrarNovoToolStripMenuItem1.Size = new Size(195, 26);
            cadastrarNovoToolStripMenuItem1.Text = "Cadastrar Novo";
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(195, 26);
            listarToolStripMenuItem1.Text = "Listar";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoUsuárioToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(79, 24);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            novoUsuárioToolStripMenuItem.Size = new Size(182, 26);
            novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1022, 634);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestão de Frotas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem autocarrosToolStripMenuItem;
        private ToolStripMenuItem cadastrarNovoToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem colaboradoresToolStripMenuItem;
        private ToolStripMenuItem cadastrarNovoToolStripMenuItem1;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}