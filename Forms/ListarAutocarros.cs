using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T2.Controllers;
using T2.Db;
using T2.Model;
using T2.Utils;

namespace Teste2.Forms
{
    public partial class ListarAutocarros : Form
    {
        private AutocarroController _controller;
        private DbContextOptions<AppDbContext> _options;
        public ListarAutocarros()
        {

            InitializeComponent();

            _options = new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlite(Constants.DATABASE_SOURCE)
                    .Options;

            var context = new AppDbContext(_options);
            _controller = new AutocarroController(context);

            CarregarDados();
        }

        private void CarregarDados()
        {
            dgvAutocarros.DataSource = null;
            var autocarros = _controller.ListarAutocarros();
            dgvAutocarros.DataSource = autocarros
                .Select(a => new
                {
                    a.Id,
                    a.Marca,
                    a.Modelo,
                    a.Matricula,
                    a.Lotacao,
                    Estado = a.EstadoDisplay
                })
                .ToList();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAutocarros.CurrentRow == null) return;

            int id = (int)dgvAutocarros.CurrentRow.Cells["Id"].Value;

            using var context = new AppDbContext(_options);
            var autocarro = context.Autocarros.Find(id);
            if (autocarro != null)
            {
                var frm = new CadastroAutocarro(autocarro); // precisa ter um construtor com Autocarro
                frm.ShowDialog();
                CarregarDados();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAutocarros.CurrentRow == null) return;

            int id = (int)dgvAutocarros.CurrentRow.Cells["Id"].Value;
            string nome = dgvAutocarros.CurrentRow.Cells["Matricula"].Value.ToString();

            if (MessageBox.Show($"Deseja realmente excluir o autocarro: {nome}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _controller.ExcluirAutocarro(id);
                CarregarDados();
            }
        }
      /*  private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var frm = new CadastroAutocarro(); // precisa ter um construtor sem parâmetros
            frm.ShowDialog();
            CarregarDados();
        }*/
        private void ListarAutocarros_Load(object sender, EventArgs e)
        {
            AjustarAlturaDataGrid();
        }

        private void ListarAutocarros_Resize(object sender, EventArgs e)
        {
            AjustarAlturaDataGrid();
        }

        private void AjustarAlturaDataGrid()
        {
            dgvAutocarros.Height = this.ClientSize.Height / 2;
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            var frm = new CadastroAutocarro(); // precisa ter um construtor sem parâmetros
            frm.ShowDialog();
            CarregarDados();
        }
    }
}
       /* private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadastroAutocarro(); // precisa ter um construtor sem parâmetros
            frm.ShowDialog();
            CarregarDados();
}
    }
}*/
