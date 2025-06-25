namespace Teste2.Forms
{
    partial class ListarColaboradores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvColaboradores;
        private Button btnEditar;
        private Button btnExcluir;

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
            dgvColaboradores = new DataGridView();
            btnEditar = new Button();
            btnExcluir = new Button();

            // dgvColaboradores
            dgvColaboradores.Location = new Point(20, 20);
            dgvColaboradores.Size = new Size(740, 300);
            dgvColaboradores.ReadOnly = true;
            dgvColaboradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvColaboradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // btnEditar
            btnEditar.Text = "Editar";
            btnEditar.Location = new Point(180, 340);
            btnEditar.Size = new Size(100, 30);
            btnEditar.Click += new EventHandler(btnEditar_Click);

            // btnExcluir
            btnExcluir.Text = "Excluir";
            btnExcluir.Location = new Point(300, 340);
            btnExcluir.Size = new Size(100, 30);
            btnExcluir.Click += new EventHandler(btnExcluir_Click);

            // Form
            this.ClientSize = new Size(800, 400);
            this.Controls.AddRange(new Control[]
            {
                dgvColaboradores,
                btnEditar,
                btnExcluir
            });
            this.Text = "Listagem de Colaboradores";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        #endregion
    }
}