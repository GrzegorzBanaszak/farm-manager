using farm_manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace farm_manager.Infrastructure.Persistence.Configurations
{
    public class CropConfiguration : IEntityTypeConfiguration<Crop>
    {
        public void Configure(EntityTypeBuilder<Crop> builder)
        {
            builder.ToTable("Crops");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.PlantName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Variety).HasMaxLength(100);
            builder.Property(c => c.SowingDate).IsRequired();
            builder.Property(c => c.ExpectedHarvestDate);

            builder
                .HasMany(c => c.Treatments)
                .WithOne()
                .HasForeignKey("CropId");

            builder
                .HasMany(c => c.Yields)
                .WithOne()
                .HasForeignKey("CropId");
        }
    }
}
