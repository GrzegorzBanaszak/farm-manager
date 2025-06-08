using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace farm_manager.Infrastructure.Persistence
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Można to pobrać z ENV/sekretów, ale na razie wpisz jawnie:
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433;Database=FarmAppDb;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
