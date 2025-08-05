using Microsoft.EntityFrameworkCore;
using eipiai.Model;


namespace eipiai.InfraExtrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet <Livros> Livross { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Host=localhost;" +
                "Port=5432;Database=Library;" +
                "Username=postgres;" +
                "Password=9876;");
                
    }
}
