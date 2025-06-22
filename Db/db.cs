
using Microsoft.EntityFrameworkCore;

namespace T2.Db
{
    public class AppContext : DbContext
    {
        public DbSet<Model.Bus> buses { get; set; }
        public DbSet<Model.Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySql(
                "server= ; database= ; user=; password= ;",
                ServerVersion.AutoDetect("server= ; database= ; user=; password= ;")
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.Bus>().ToTable(""); 
            modelBuilder.Entity<Model.Usuario>().ToTable(""); 
        }
    }
}