using ConnektingTheDataBaseToTheProject.DbStuff.DbModels;
using Microsoft.EntityFrameworkCore;

namespace ConnektingTheDataBaseToTheProject.DbStuff;

public class TestDbContext : DbContext
{
   protected readonly IConfiguration Configuration;

   public TestDbContext(IConfiguration configuration)
   {
      Configuration = configuration;
   }
   
   protected override void OnConfiguring(DbContextOptionsBuilder options)
   {
      // connect to postgres with connection string from app settings
      options.UseNpgsql(Configuration.GetConnectionString("Test"));
   }
   
   public DbSet<Test> Tests { get; set; }
}