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
            ((System.ComponentModel.ISupportInitialize)dgvColaboradores).BeginInit();
            SuspendLayout();
            // 
            // dgvColaboradores
            // 
            dgvColaboradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvColaboradores.ColumnHeadersHeight = 29;
            dgvColaboradores.Dock = DockStyle.Top;
            dgvColaboradores.Location = new Point(0, 0);
            dgvColaboradores.Name = "dgvColaboradores";
            dgvColaboradores.ReadOnly = true;
            dgvColaboradores.RowHeadersWidth = 51;
            dgvColaboradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvColaboradores.Size = new Size(868, 300);
            dgvColaboradores.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(173, 340);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 48);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(300, 340);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 48);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // ListarColaboradores
            // 
            ClientSize = new Size(868, 446);
            Controls.Add(dgvColaboradores);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ListarColaboradores";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Listagem de Colaboradores";
            ((System.ComponentModel.ISupportInitialize)dgvColaboradores).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}