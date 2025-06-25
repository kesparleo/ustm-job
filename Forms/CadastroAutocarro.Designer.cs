namespace Teste2.Forms
{
    partial class CadastroAutocarro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

            // Labels
            lblMarca.Text = "Marca:";
            lblMarca.Location = new System.Drawing.Point(20, 20);
            lblMarca.AutoSize = true;

            lblModelo.Text = "Modelo:";
            lblModelo.Location = new System.Drawing.Point(20, 60);
            lblModelo.AutoSize = true;

            lblMatricula.Text = "Matrícula:";
            lblMatricula.Location = new System.Drawing.Point(20, 100);
            lblMatricula.AutoSize = true;

            lblLotacao.Text = "Lotação:";
            lblLotacao.Location = new System.Drawing.Point(20, 140);
            lblLotacao.AutoSize = true;

            lblEstado.Text = "Estado:";
            lblEstado.Location = new System.Drawing.Point(20, 180);
            lblEstado.AutoSize = true;

            // TextBoxes
            txtMarca.Location = new System.Drawing.Point(120, 17);
            txtMarca.Size = new System.Drawing.Size(200, 27);

            txtModelo.Location = new System.Drawing.Point(120, 57);
            txtModelo.Size = new System.Drawing.Size(200, 27);

            txtMatricula.Location = new System.Drawing.Point(120, 97);
            txtMatricula.Size = new System.Drawing.Size(200, 27);

            txtLotacao.Location = new System.Drawing.Point(120, 137);
            txtLotacao.Size = new System.Drawing.Size(200, 27);

            // ComboBox Estado
            cmbEstado.Location = new System.Drawing.Point(120, 177);
            cmbEstado.Size = new System.Drawing.Size(200, 27);
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            // Botão Salvar
            btnSalvar.Text = "Salvar";
            btnSalvar.Location = new System.Drawing.Point(120, 220);
            btnSalvar.Size = new System.Drawing.Size(100, 30);
            btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblMarca, txtMarca,
                lblModelo, txtModelo,
                lblMatricula, txtMatricula,
                lblLotacao, txtLotacao,
                lblEstado, cmbEstado,
                btnSalvar
            });
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Cadastro de Autocarro";
        }
    }
    #endregion
}