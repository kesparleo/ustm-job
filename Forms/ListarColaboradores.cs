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
using T2.Utils;
using T2.Model;
namespace Teste2.Forms
{
    public partial class ListarColaboradores : Form
    {
        private readonly ColaboradorController _controller;
        private readonly DbContextOptions<AppDbContext> _options;
        public ListarColaboradores()
        {
            InitializeComponent();
            _options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite(Constants.DATABASE_SOURCE)
                .Options;

            var context = new AppDbContext(_options);
            _controller = new ColaboradorController(context);

            CarregarDados();
        }

        private void CarregarDados()
        {
            dgvColaboradores.DataSource = null;
            var lista = _controller.ListarColaboradores();

            dgvColaboradores.DataSource = lista.Select(c => new
            {
                c.Id,
                c.Nome,
                c.Cargo,
                Autocarro = c.Autocarro != null ? c.Autocarro.Matricula : "Nenhum"
            }).ToList();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvColaboradores.CurrentRow == null) return;

            int id = (int)dgvColaboradores.CurrentRow.Cells["Id"].Value;

            using var db = new AppDbContext(_options);
            var colaborador = db.Colaboradores.Include(c => c.Autocarro).FirstOrDefault(c => c.Id == id);
            if (colaborador != null)
            {
                var frm = new CadastroColaborador(colaborador); // precisa aceitar um colaborador
                frm.ShowDialog();
                CarregarDados();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvColaboradores.CurrentRow == null) return;

            int id = (int)dgvColaboradores.CurrentRow.Cells["Id"].Value;
            string nome = dgvColaboradores.CurrentRow.Cells["Nome"].Value.ToString() ?? "Colaborador";

            var confirm = MessageBox.Show($"Deseja excluir {nome}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                _controller.ExcluirColaborador(id);
                CarregarDados();
            }
        }
    }
}
