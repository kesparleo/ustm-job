using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using T2.Controllers;
using T2.Db;
using T2.Model;
using T2.Utils;

namespace Teste2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            //ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


            //Vamos usar só em dev.
            //ex do que acontece ao habilitar: Evento: Entidade atualizada - Colaborador, ID: 1
            AppDbContext.setDebugMode(true);

            // Inicialização do contexto da database
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite(Constants.DATABASE_SOURCE)
                .Options;
            using var context = new AppDbContext(options);
            // Criar a database se não existir
            if (context.CreateDatabaseIfNotExists())
            {
                Console.WriteLine("Base de dados sincronizada com sucesso!");
            }

            Console.WriteLine("=== Hora da verdade: Sistema de Gestão de Frotas blablabla ===");


            var autocarroController = new AutocarroController(context);
            var colaboradorController = new ColaboradorController(context);
            var usuarioController = new UsuarioController(context);

            // Testar Usuários
            Console.WriteLine("\n--- blablabla de Usuários ---");
            var usuario = new Usuario
            {
                Nome = "Kelven Cassamo",
                Username = "kelven",
                Senha = "123456",
                TipoUsuario = TipoUsuario.Admin
            };
            usuarioController.AdicionarUsuario(usuario);
            Console.WriteLine("Usuário adicionado: " + usuario.Nome);

            var usuarios = usuarioController.ListarUsuarios();
            Console.WriteLine("Usuários cadastrados:");
            foreach (var u in usuarios)
                Console.WriteLine($"ID: {u.Id}, Nome: {u.Nome}, Tipo: {u.TipoUsuario}");

            var autenticado = usuarioController.AutenticarUsuario("kelven", "123456");
            Console.WriteLine($"Autenticação: {(autenticado != null ? "Sucesso" : "Falha")}");

            usuario.Nome = "Kelven Actualizado";
            usuarioController.ActualizarUsuario(usuario);
            Console.WriteLine("Usuário actualizado: " + usuario.Nome);

            usuarioController.ExcluirUsuario(usuario.Id);
            Console.WriteLine("Usuário excluído.");

            // Testar  Autocarros
            Console.WriteLine("\n--- Teste de Autocarros ---");
            var autocarro = new Autocarro
            {
                Marca = "Mitsubishi",
                Modelo = "XYZ",
                Matricula = "ABC1234",
                Lotacao = 20,
                Estado = EstadoAutocarro.Disponivel
            };
            autocarroController.AdicionarAutocarro(autocarro);
            Console.WriteLine("Autocarro adicionado: " + autocarro.Matricula);

            var autocarros = autocarroController.ListarAutocarros();
            Console.WriteLine("Autocarros cadastrados:");
            foreach (var a in autocarros)
                Console.WriteLine($"ID: {a.Id}, Matricula: {a.Matricula}, Estado: {a.EstadoDisplay}");

            autocarro.Lotacao = 25;
            autocarroController.ActualizarAutocarro(autocarro);
            Console.WriteLine("Autocarro actualizado: Lotação = " + autocarro.Lotacao);

            // Testar Colaboradores
            Console.WriteLine("\n--- Teste de Colaboradores ---");
            var colaborador = new Colaborador
            {
                Nome = "Kespar Leo",
                Cargo = "Motorista",
                AutocarroId = autocarro.Id
            };
            colaboradorController.AdicionarColaborador(colaborador);
            Console.WriteLine("Colaborador adicionado: " + colaborador.Nome);

            var colaboradores = colaboradorController.ListarColaboradores();
            Console.WriteLine("Colaboradores cadastrados:");
            foreach (var c in colaboradores)
                Console.WriteLine($"ID: {c.Id}, Nome: {c.Nome}, Autocarro: {c.Autocarro?.Matricula ?? "Nenhum"}");

            colaborador.Cargo = "Motorista Sênior";
            colaboradorController.ActualizarColaborador(colaborador);
            Console.WriteLine("Colaborador actualizado: Cargo = " + colaborador.Cargo);

            colaboradorController.ExcluirColaborador(colaborador.Id);
            Console.WriteLine("Colaborador excluído.");

            autocarroController.ExcluirAutocarro(autocarro.Id);
            Console.WriteLine("Autocarro excluído.");

            Console.WriteLine("\n=== Teste Concluído ===");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            



        }
    }
    
}