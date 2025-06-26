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
    public partial class CadastroUsuario : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        public CadastroUsuario()
        {
            InitializeComponent();
            cmbTipoUsuario.DataSource = Enum.GetValues(typeof(TipoUsuario));
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                errorProvider.SetError(txtNome, "Informe o nome completo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Informe o nome de usuário.");
                return;
            }

            if (txtSenha.Text.Length < 4)
            {
                errorProvider.SetError(txtSenha, "A senha deve ter pelo menos 4 caracteres.");
                return;
            }

            if (cmbTipoUsuario.SelectedItem == null)
            {
                errorProvider.SetError(cmbTipoUsuario, "Selecione o tipo de usuário.");
                return;
            }

            var usuario = new Usuario
            {
                Nome = txtNome.Text.Trim(),
                Username = txtUsername.Text.Trim(),
                Senha = txtSenha.Text.Trim(),
                TipoUsuario = (TipoUsuario)cmbTipoUsuario.SelectedItem!
            };

            //   opções de contexto para SQLite
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite(Constants.DATABASE_SOURCE);

            // contexto com opções
            using var context = new AppDbContext(optionsBuilder.Options);
            context.CreateDatabaseIfNotExists(); 

            var controller = new UsuarioController(context);
            controller.AdicionarUsuario(usuario);

            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            this.Hide();
            new Login().ShowDialog();
            
        }
       
    }
}
