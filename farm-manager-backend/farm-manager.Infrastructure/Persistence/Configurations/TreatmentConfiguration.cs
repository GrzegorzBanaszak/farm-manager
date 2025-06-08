using farm_manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace farm_manager.Infrastructure.Persistence.Configurations
{
    public class TreatmentConfiguration : IEntityTypeConfiguration<Treatment>
    {
        public void Configure(EntityTypeBuilder<Treatment> builder)
        {
            builder.ToTable("Treatments");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.TreatmentType).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Description).HasMaxLength(255);
            builder.Property(t => t.DatePlanned).IsRequired();
            builder.Property(t => t.DatePerformed);
            builder.Property(t => t.Notes).HasMaxLength(500);
        }
    }
}
