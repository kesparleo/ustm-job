using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T2.Db;
using T2.Model;
using T2.Utils;

namespace Teste2.Forms
{
    public partial class CadastroColaborador : Form
    {
        private readonly DbContextOptions<AppDbContext> _options;
        private readonly Colaborador? _colaboradorExistente;
        public CadastroColaborador()
        {
            InitializeComponent();
            _options = new DbContextOptionsBuilder<AppDbContext>()
               .UseSqlite(Constants.DATABASE_SOURCE)
               .Options;

            PopularAutocarros();
        }

        // Construtor para edição
        public CadastroColaborador(Colaborador colaborador) : this()
        {
            _colaboradorExistente = colaborador;
            PreencherCampos();
        }

        private void PopularAutocarros()
        {
            using var db = new AppDbContext(_options);
            var autocarros = db.Autocarros.ToList();

            cmbAutocarro.DisplayMember = "Matricula";
            cmbAutocarro.ValueMember = "Id";
            cmbAutocarro.DataSource = autocarros;

            cmbAutocarro.SelectedIndex = -1;
        }

        private void PreencherCampos()
        {
            if (_colaboradorExistente == null) return;

            txtNome.Text = _colaboradorExistente.Nome;
            txtCargo.Text = _colaboradorExistente.Cargo;
            cmbAutocarro.SelectedValue = _colaboradorExistente.AutocarroId ?? -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var db = new AppDbContext(_options);

            if (_colaboradorExistente == null)
            {
                // Novo
                var colaborador = new Colaborador
                {
                    Nome = txtNome.Text.Trim(),
                    Cargo = txtCargo.Text.Trim(),
                    AutocarroId = cmbAutocarro.SelectedValue as int?
                };

                db.Colaboradores.Add(colaborador);
            }
            else
            {
                // Edição
                var colab = db.Colaboradores.Find(_colaboradorExistente.Id);
                if (colab != null)
                {
                    colab.Nome = txtNome.Text.Trim();
                    colab.Cargo = txtCargo.Text.Trim();
                    colab.AutocarroId = cmbAutocarro.SelectedValue as int?;
                    db.Colaboradores.Update(colab);
                }
            }

            db.SaveChanges();
            MessageBox.Show("Colaborador salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CadastroColaborador_Load(object sender, EventArgs e)
        {

        }
    }
}
