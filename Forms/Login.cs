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
using T2.Utils;
using T2.Controllers;
using T2.Model;

namespace Teste2.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnEntrar;
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite(Constants.DATABASE_SOURCE);

            using var context = new AppDbContext(optionsBuilder.Options);
            var controller = new UsuarioController(context);

            Usuario? usuario = controller.AutenticarUsuario(username, senha);

            if (usuario != null)
            {
                // Acesso concedido
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new Main(usuario).Show(); // Podes trocar por o teu formulário principal
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Encerra toda a aplicação
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new CadastroUsuario().Show(this);
        }
    }
}
