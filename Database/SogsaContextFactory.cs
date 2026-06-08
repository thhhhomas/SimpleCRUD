using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SOGSA.Api.Database;

public class SogsaContextFactory : IDesignTimeDbContextFactory<SogsaDbContext> {

  public SogsaDbContext CreateDbContext(string[] args) {
    var configuration = new ConfigurationBuilder()
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile("appsettings.json")
      .Build();

    var optionsBuilder = new DbContextOptionsBuilder<SogsaDbContext>();

    var connectionString = configuration.GetConnectionString("MigrationsConnection");
    optionsBuilder.UseSqlServer(connectionString);

    return new SogsaDbContext(optionsBuilder.Options);
  }

}
