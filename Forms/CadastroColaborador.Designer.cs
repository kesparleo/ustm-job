namespace Teste2.Forms
{
    partial class CadastroColaborador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblAutocarro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.ComboBox cmbAutocarro;
        private System.Windows.Forms.Button btnSalvar;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroColaborador));
            lblNome = new Label();
            lblCargo = new Label();
            lblAutocarro = new Label();
            txtNome = new TextBox();
            txtCargo = new TextBox();
            cmbAutocarro = new ComboBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 28);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(21, 98);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(69, 28);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo:";
            // 
            // lblAutocarro
            // 
            lblAutocarro.AutoSize = true;
            lblAutocarro.Location = new Point(12, 168);
            lblAutocarro.Name = "lblAutocarro";
            lblAutocarro.Size = new Size(104, 28);
            lblAutocarro.TabIndex = 4;
            lblAutocarro.Text = "Autocarro:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(120, 17);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(523, 34);
            txtNome.TabIndex = 1;
            // 
            // txtCargo
            // 
            txtCargo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCargo.Location = new Point(120, 95);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(523, 34);
            txtCargo.TabIndex = 3;
            // 
            // cmbAutocarro
            // 
            cmbAutocarro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbAutocarro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAutocarro.Location = new Point(120, 160);
            cmbAutocarro.Name = "cmbAutocarro";
            cmbAutocarro.Size = new Size(523, 36);
            cmbAutocarro.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSalvar.Location = new Point(120, 305);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(423, 34);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // CadastroColaborador
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(683, 434);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCargo);
            Controls.Add(txtCargo);
            Controls.Add(lblAutocarro);
            Controls.Add(cmbAutocarro);
            Controls.Add(btnSalvar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CadastroColaborador";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Colaborador";
            Load += CadastroColaborador_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
    #endregion
}
    