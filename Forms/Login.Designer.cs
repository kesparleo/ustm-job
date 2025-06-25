namespace Teste2.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnSair;

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
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnSair = new Button();
            linkCadastrar = new LinkLabel();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(12, 47);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(100, 23);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(12, 123);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(100, 23);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(147, 47);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(180, 34);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(147, 123);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(180, 34);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(259, 293);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(100, 33);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(30, 293);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(80, 33);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // linkCadastrar
            // 
            linkCadastrar.AutoSize = true;
            linkCadastrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkCadastrar.Location = new Point(12, 190);
            linkCadastrar.Name = "linkCadastrar";
            linkCadastrar.Size = new Size(146, 23);
            linkCadastrar.TabIndex = 6;
            linkCadastrar.TabStop = true;
            linkCadastrar.Text = "Cadastrar Usuario";
            linkCadastrar.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(393, 350);
            Controls.Add(linkCadastrar);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(btnEntrar);
            Controls.Add(btnSair);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }
        private LinkLabel linkCadastrar;
    }
}
#endregion