using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AircraftApptest.EntityFrameworkCore
{
    public class AircraftApptestDbContextFactory : IDesignTimeDbContextFactory<AircraftApptestDbContext>
    {
        public AircraftApptestDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AircraftApptest.Web.Host"))
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connStr = configuration.GetConnectionString("Default");
            var builder = new DbContextOptionsBuilder();
            builder.UseNpgsql(connStr);
            return new AircraftApptestDbContext(builder.Options);
        }
    }
}
