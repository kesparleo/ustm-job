namespace Teste2.Forms
{
    partial class CadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        ///private System.ComponentModel.IContainer components = null;
        private Label lblNome;
        private Label lblUsername;
        private Label lblSenha;
        private Label lblConfirmarSenha;
        private Label lblTipoUsuario;
        private TextBox txtNome;
        private TextBox txtUsername;
        private TextBox txtSenha;
        private ComboBox cmbTipoUsuario;
        private Button btnSalvar;
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
            lblNome = new Label();
            lblUsername = new Label();
            lblSenha = new Label();
            lblTipoUsuario = new Label();
            txtNome = new TextBox();
            txtUsername = new TextBox();
            txtSenha = new TextBox();
            cmbTipoUsuario = new ComboBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Location = new Point(20, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome completo:";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(20, 60);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(126, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Nome de usuário:";
            // 
            // lblSenha
            // 
            lblSenha.Location = new Point(20, 100);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(100, 23);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.Location = new Point(20, 140);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(126, 23);
            lblTipoUsuario.TabIndex = 6;
            lblTipoUsuario.Text = "Tipo de usuário:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(183, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 27);
            txtNome.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(183, 63);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(183, 96);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(200, 27);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.Location = new Point(183, 140);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(200, 28);
            cmbTipoUsuario.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(145, 205);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // CadastroUsuario
            // 
            ClientSize = new Size(433, 277);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblTipoUsuario);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Novo Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}