using SOGSA.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace SOGSA.Api.Database;

public class SogsaDbContext : DbContext {

  public DbSet<Student> Students { get; set; }

  public DbSet<Teacher> Teachers { get; set; }

  public SogsaDbContext() {}

  public SogsaDbContext(DbContextOptions options) : base(options) {}
  
}
