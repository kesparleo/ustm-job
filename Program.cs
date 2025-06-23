using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using T2.Controllers;
using T2.Db;
using T2.Model;
using T2.Utils;

namespace T2
{
    class Program
    {
        static void Main()
        {
            //Vamos usar só em dev.
            //ex do que acontece ao habilitar: Evento: Entidade atualizada - Colaborador, ID: 1
             AppDbContext.setDebugMode(true); 
             
            // Inicialização do contexto da database
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite(Constants.DATABASE_SOURCE)
                .Options;
            using var context = new AppDbContext(options);
            // Criar a database se não existir
            context.CreateDatabaseIfNotExists();

        }
    }
}