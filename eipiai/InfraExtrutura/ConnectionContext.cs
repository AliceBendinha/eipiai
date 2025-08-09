using eipiai.Dominio.Model;
using Microsoft.EntityFrameworkCore;


namespace eipiai.InfraExtrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Livros> Livross { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Host=localhost;" +
                "Port=5432;Database=Library;" +
                "Username=postgres;" +
                "Password=9876;");

    }
}
