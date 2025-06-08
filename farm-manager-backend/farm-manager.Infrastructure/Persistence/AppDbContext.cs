using farm_manager.Domain.Entities;
using farm_manager.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace farm_manager.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Field> Fields => Set<Field>();
        public DbSet<Crop> Crops => Set<Crop>();
        public DbSet<Treatment> Treatments => Set<Treatment>();
        public DbSet<Yield> Yields => Set<Yield>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FieldConfiguration());
            modelBuilder.ApplyConfiguration(new CropConfiguration());
            modelBuilder.ApplyConfiguration(new TreatmentConfiguration());
            modelBuilder.ApplyConfiguration(new YieldConfiguration());
        }


    }
}
