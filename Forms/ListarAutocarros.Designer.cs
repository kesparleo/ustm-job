namespace Teste2.Forms
{
    partial class ListarAutocarros
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvAutocarros;
        private Button btnEditar;
        private Button btnExcluir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvAutocarros = new DataGridView();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAutocarros).BeginInit();
            SuspendLayout();
            // 
            // dgvAutocarros
            // 
            dgvAutocarros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAutocarros.ColumnHeadersHeight = 29;
            dgvAutocarros.Dock = DockStyle.Top;
            dgvAutocarros.Location = new Point(0, 0);
            dgvAutocarros.Margin = new Padding(4, 4, 4, 4);
            dgvAutocarros.Name = "dgvAutocarros";
            dgvAutocarros.ReadOnly = true;
            dgvAutocarros.RowHeadersWidth = 51;
            dgvAutocarros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutocarros.Size = new Size(1100, 280);
            dgvAutocarros.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom;
            btnEditar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(425, 504);
            btnEditar.Margin = new Padding(4, 4, 4, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(138, 55);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom;
            btnExcluir.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(711, 504);
            btnExcluir.Margin = new Padding(4, 4, 4, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(138, 55);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom;
            btnAdicionar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(154, 504);
            btnAdicionar.Margin = new Padding(4, 4, 4, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(154, 55);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // ListarAutocarros
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1100, 588);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvAutocarros);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ListarAutocarros";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Listagem de Autocarros";
            Load += ListarAutocarros_Load;
            Resize += ListarAutocarros_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvAutocarros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdicionar;
    }
}
