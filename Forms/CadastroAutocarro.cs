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
using T2.Db;
using T2.Model;
using T2.Utils;

namespace Teste2.Forms
{
    public partial class CadastroAutocarro : Form
    {
        private Autocarro? _autocarroExistente;
        private readonly DbContextOptions<AppDbContext> _options;
        public CadastroAutocarro()
        {
            InitializeComponent();
            _options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite(Constants.DATABASE_SOURCE)
                .Options;

            PopularEstados();
        }

        public CadastroAutocarro(Autocarro autocarro) : this()
        {
            _autocarroExistente = autocarro;
            PreencherCampos();
        }

        private void PopularEstados()
        {
            /* cmbEstado.Items.Clear();
             cmbEstado.Items.AddRange(Enum.GetValues(typeof(EstadoAutocarro)));
             cmbEstado.SelectedIndex = 0;*/
            cmbEstado.DataSource = Enum.GetValues(typeof(EstadoAutocarro));
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void PreencherCampos()
        {
            if (_autocarroExistente == null) return;

            txtMarca.Text = _autocarroExistente.Marca;
            txtModelo.Text = _autocarroExistente.Modelo;
            txtMatricula.Text = _autocarroExistente.Matricula;
            txtLotacao.Text = _autocarroExistente.Lotacao.ToString();
            cmbEstado.SelectedItem = _autocarroExistente.Estado;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                string.IsNullOrWhiteSpace(txtLotacao.Text) ||
                cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtLotacao.Text, out int lotacao))
            {
                MessageBox.Show("Lotação deve ser um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var db = new AppDbContext(_options);

            if (_autocarroExistente == null)
            {
                var novoAutocarro = new Autocarro
                {
                    Marca = txtMarca.Text.Trim(),
                    Modelo = txtModelo.Text.Trim(),
                    Matricula = txtMatricula.Text.Trim(),
                    Lotacao = lotacao,
                    Estado = (EstadoAutocarro)cmbEstado.SelectedItem!
                };

                db.Autocarros.Add(novoAutocarro);
            }
            else
            {
                var autocarro = db.Autocarros.Find(_autocarroExistente.Id);
                if (autocarro != null)
                {
                    autocarro.Marca = txtMarca.Text.Trim();
                    autocarro.Modelo = txtModelo.Text.Trim();
                    autocarro.Matricula = txtMatricula.Text.Trim();
                    autocarro.Lotacao = lotacao;
                    autocarro.Estado = (EstadoAutocarro)cmbEstado.SelectedItem;

                    db.Autocarros.Update(autocarro);
                }
            }

            db.SaveChanges();

            MessageBox.Show("Autocarro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
