using farm_manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace farm_manager.Infrastructure.Persistence.Configurations
{
    public class YieldConfiguration : IEntityTypeConfiguration<Yield>
    {
        public void Configure(EntityTypeBuilder<Yield> builder)
        {
            builder.ToTable("Yields");
            builder.HasKey(y => y.Id);

            builder.Property(y => y.DateHarvested).IsRequired();
            builder.Property(y => y.AmountTons).IsRequired();
            builder.Property(y => y.QualityNotes).HasMaxLength(500);
        }
    }
}
