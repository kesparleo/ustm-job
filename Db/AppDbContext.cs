using Microsoft.EntityFrameworkCore;

namespace T2.Db
{
    public class AppDbContext : DbContext
    {
        public DbSet<T2.Model.Autocarro> Autocarros { get; set; }
        public DbSet<T2.Model.Colaborador> Colaboradores { get; set; }
        public DbSet<T2.Model.Usuario> Usuarios { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=bivdev.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T2.Model.Autocarro>().ToTable("Autocarros");
            modelBuilder.Entity<T2.Model.Colaborador>().ToTable("Colaboradores");
            modelBuilder.Entity<T2.Model.Usuario>().ToTable("Usuarios");

            modelBuilder.Entity<T2.Model.Autocarro>()
                .Property(a => a.Estado)
                .HasConversion<string>();

            modelBuilder.Entity<T2.Model.Usuario>()
                .Property(u => u.TipoUsuario)
                .HasConversion<string>();

            modelBuilder.Entity<T2.Model.Colaborador>()
                .HasOne(c => c.Autocarro)
                .WithMany(a => a.Colaboradores)
                .HasForeignKey(c => c.AutocarroId);
        }
    }
}