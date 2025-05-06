using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Sala.Infrastructure.Config;

namespace Sala.Database.Context;

    public class SalaDatabaseContextFactory : IDesignTimeDbContextFactory<SalaDatabaseContext>
    {
        public SalaDatabaseContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath($"{Directory.GetCurrentDirectory()}")
                .AddJsonFile($"appsettings.Development.json");

            var configuration = builder.Build();
            AppConfig.Init(configuration);

            return new SalaDatabaseContext();
        }
    }
