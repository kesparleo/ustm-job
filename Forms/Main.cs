using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T2.Model;


namespace Teste2.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private Usuario _usuarioLogado;

        public Main(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogado = usuario;

            // Aqui podes mostrar o nome, tipo, etc.
            this.Text = $"Sistema de Gestão - Bem-vindo, {_usuarioLogado.Nome} ({_usuarioLogado.TipoUsuario})";


            // Associar eventos aos menus
            /*cadastrarNovoToolStripMenuItem.Click += (s, e) => new CadastroAutocarro().ShowDialog();
            listarToolStripMenuItem.Click += (s, e) => new ListarAutocarros().ShowDialog();

            cadastrarNovoToolStripMenuItem1.Click += (s, e) => new CadastroColaborador().ShowDialog();
            listarToolStripMenuItem1.Click += (s, e) => new ListarColaboradores().ShowDialog();

            novoUsuárioToolStripMenuItem.Click += (s, e) => new CadastroUsuario().ShowDialog();*/
            cadastrarNovoToolStripMenuItem.Click += (s, e) =>
            {
                this.Hide();
                new CadastroAutocarro().ShowDialog();
                this.Show();
            };

            listarToolStripMenuItem.Click += (s, e) =>
            {
                this.Hide();
                new ListarAutocarros().ShowDialog();
                this.Show();
            };

            cadastrarNovoToolStripMenuItem1.Click += (s, e) =>
            {
                this.Hide();
                new CadastroColaborador().ShowDialog();
                this.Show();
            };

            listarToolStripMenuItem1.Click += (s, e) =>
            {
                this.Hide();
                new ListarColaboradores().ShowDialog();
                this.Show();
            };

            novoUsuárioToolStripMenuItem.Click += (s, e) =>
            {
                this.Hide();
                new CadastroUsuario().ShowDialog();
                this.Show();
            };
            sairToolStripMenuItem.Click += (s, e) => Application.Exit();
            AplicarPermissoes();



        }
        private void AplicarPermissoes()
        {
            switch (_usuarioLogado.TipoUsuario)
            {
                case TipoUsuario.Operador:
                    // Operador só pode listar
                    cadastrarNovoToolStripMenuItem.Enabled = false;
                    cadastrarNovoToolStripMenuItem1.Enabled = false;
                    novoUsuárioToolStripMenuItem.Enabled = false;
                    break;

                case TipoUsuario.Gestor:
                    // Gestor pode cadastrar/listar, mas não pode criar usuários
                    novoUsuárioToolStripMenuItem.Enabled = false;
                    break;

                case TipoUsuario.Admin:
                    // Admin tem acesso total – não fazer nada
                    break;
            }
        }

    }
}

