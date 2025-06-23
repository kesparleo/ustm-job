using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using T2.Model;
using T2.Utils;

namespace T2.Db
{
    public class AppDbContext : DbContext
    {
        public static bool is_logs_enabled = false;
        public DbSet<Autocarro> Autocarros { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        // Eventos
        public event EventHandler? OnDatabaseCreated;
        public event EventHandler<EntityEntry>? OnEntityAdded;
        public event EventHandler<EntityEntry>? OnEntityUpdated;
        public event EventHandler<EntityEntry>? OnEntityDeleted;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
             this.OnDatabaseCreated += (sender, args) =>
                Console.WriteLine("Evento: Banco de dados criado!");
            this.OnEntityAdded += (sender, entry) =>
                Console.WriteLine($"Evento: Entidade adicionada - {entry.Entity.GetType().Name}, ID: {entry.Property("Id").CurrentValue}");
            this.OnEntityUpdated += (sender, entry) =>
                Console.WriteLine($"Evento: Entidade atualizada - {entry.Entity.GetType().Name}, ID: {entry.Property("Id").CurrentValue}");
            this.OnEntityDeleted += (sender, entry) =>
                Console.WriteLine($"Evento: Entidade excluída - {entry.Entity.GetType().Name}, ID: {entry.Property("Id").CurrentValue}");

        }

        public static void setDebugMode(bool val)
        {
            AppDbContext.is_logs_enabled = val;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(Constants.DATABASE_SOURCE);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autocarro>().ToTable("Autocarros");
            modelBuilder.Entity<Colaborador>().ToTable("Colaboradores");
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");

            modelBuilder.Entity<Autocarro>()
                .Property(a => a.Estado)
                .HasConversion<string>();

            modelBuilder.Entity<Usuario>()
                .Property(u => u.TipoUsuario)
                .HasConversion<string>();

            modelBuilder.Entity<Colaborador>()
                .HasOne(c => c.Autocarro)
                .WithMany(a => a.Colaboradores)
                .HasForeignKey(c => c.AutocarroId);
        }

        public override int SaveChanges()
        {

          //Este bloco será executado se estivermos no modo debug  
          if(is_logs_enabled){
              var entries = ChangeTracker.Entries().ToList();
            foreach (var entry in entries)
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        OnEntityAdded?.Invoke(this, entry);
                        break;
                    case EntityState.Modified:
                        OnEntityUpdated?.Invoke(this, entry);
                        break;
                    case EntityState.Deleted:
                        OnEntityDeleted?.Invoke(this, entry);
                        break;
                }
            }
          }

            return base.SaveChanges();
        }


        public new bool CreateDatabaseIfNotExists()
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                OnDatabaseCreated?.Invoke(this, EventArgs.Empty);
            }
            return created;
        }
    }
}