using cruds.Data;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace cruds
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TareaDBContext>
    {
        public TareaDBContext CreateDbContext(string[] args)
        {
            // Construye la configuración leyendo el appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Obtiene la cadena de conexión
            var builder = new DbContextOptionsBuilder<TareaDBContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Configura el DbContext para usar SQL Server
            builder.UseSqlServer(connectionString);

            // Retorna una nueva instancia del DbContext
            return new TareaDBContext(builder.Options);
        }
    }
}
