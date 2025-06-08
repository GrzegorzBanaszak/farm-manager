using farm_manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace farm_manager.Infrastructure.Persistence.Configurations
{
    public class FieldConfiguration : IEntityTypeConfiguration<Field>
    {
        public void Configure(EntityTypeBuilder<Field> builder)
        {
            builder.ToTable("Fields");
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Name).IsRequired().HasMaxLength(100);
            builder.Property(f => f.AreaHa).IsRequired();
            builder.Property(f => f.Location).HasMaxLength(255);
            builder.Property(f => f.SoilType).HasMaxLength(100);
            builder.Property(f => f.Notes).HasMaxLength(500);

            builder
                .HasMany(f => f.Crops)
                .WithOne()
                .HasForeignKey("FieldId");
        }
    }
}
