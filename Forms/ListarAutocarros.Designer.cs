namespace Teste2.Forms
{
    partial class ListarAutocarros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvAutocarros;
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
            dgvAutocarros = new DataGridView();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAutocarros).BeginInit();
            SuspendLayout();
            // 
            // dgvAutocarros
            // 
            dgvAutocarros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAutocarros.ColumnHeadersHeight = 29;
            dgvAutocarros.Location = new Point(20, 20);
            dgvAutocarros.Name = "dgvAutocarros";
            dgvAutocarros.ReadOnly = true;
            dgvAutocarros.RowHeadersWidth = 51;
            dgvAutocarros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutocarros.Size = new Size(768, 300);
            dgvAutocarros.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(180, 340);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(300, 340);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 30);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // ListarAutocarros
            // 
            ClientSize = new Size(800, 400);
            Controls.Add(dgvAutocarros);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Name = "ListarAutocarros";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Listagem de Autocarros";
            ((System.ComponentModel.ISupportInitialize)dgvAutocarros).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}