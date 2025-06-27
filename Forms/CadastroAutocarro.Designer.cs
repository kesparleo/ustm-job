namespace Teste2.Forms
{
    partial class CadastroAutocarro
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblMatricula;
        private Label lblLotacao;
        private Label lblEstado;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtMatricula;
        private TextBox txtLotacao;
        private ComboBox cmbEstado;
        private Button btnSalvar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAutocarro));
            lblMarca = new Label();
            lblModelo = new Label();
            lblMatricula = new Label();
            lblLotacao = new Label();
            lblEstado = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtMatricula = new TextBox();
            txtLotacao = new TextBox();
            cmbEstado = new ComboBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 12F);
            lblMarca.Location = new Point(55, 56);
            lblMarca.Margin = new Padding(4, 0, 4, 0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(70, 28);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 12F);
            lblModelo.Location = new Point(55, 126);
            lblModelo.Margin = new Padding(4, 0, 4, 0);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(85, 28);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo:";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 12F);
            lblMatricula.Location = new Point(55, 196);
            lblMatricula.Margin = new Padding(4, 0, 4, 0);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(98, 28);
            lblMatricula.TabIndex = 4;
            lblMatricula.Text = "Matrícula:";
            // 
            // lblLotacao
            // 
            lblLotacao.AutoSize = true;
            lblLotacao.Font = new Font("Segoe UI", 12F);
            lblLotacao.Location = new Point(55, 266);
            lblLotacao.Margin = new Padding(4, 0, 4, 0);
            lblLotacao.Name = "lblLotacao";
            lblLotacao.Size = new Size(85, 28);
            lblLotacao.TabIndex = 6;
            lblLotacao.Text = "Lotação:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F);
            lblEstado.Location = new Point(55, 336);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(75, 28);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado:";
            // 
            // txtMarca
            // 
            txtMarca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMarca.Location = new Point(248, 56);
            txtMarca.Margin = new Padding(4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(411, 34);
            txtMarca.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtModelo.Location = new Point(248, 126);
            txtModelo.Margin = new Padding(4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(411, 34);
            txtModelo.TabIndex = 3;
            // 
            // txtMatricula
            // 
            txtMatricula.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMatricula.Location = new Point(248, 196);
            txtMatricula.Margin = new Padding(4);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(411, 34);
            txtMatricula.TabIndex = 5;
            // 
            // txtLotacao
            // 
            txtLotacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLotacao.Location = new Point(248, 266);
            txtLotacao.Margin = new Padding(4);
            txtLotacao.Name = "txtLotacao";
            txtLotacao.Size = new Size(411, 34);
            txtLotacao.TabIndex = 7;
            // 
            // cmbEstado
            // 
            cmbEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(248, 336);
            cmbEstado.Margin = new Padding(4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(411, 36);
            cmbEstado.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(522, 434);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(138, 53);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // CadastroAutocarro
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(825, 532);
            Controls.Add(lblMarca);
            Controls.Add(txtMarca);
            Controls.Add(lblModelo);
            Controls.Add(txtModelo);
            Controls.Add(lblMatricula);
            Controls.Add(txtMatricula);
            Controls.Add(lblLotacao);
            Controls.Add(txtLotacao);
            Controls.Add(lblEstado);
            Controls.Add(cmbEstado);
            Controls.Add(btnSalvar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(681, 471);
            Name = "CadastroAutocarro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Autocarro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
