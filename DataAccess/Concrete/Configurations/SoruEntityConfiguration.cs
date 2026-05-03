using Core.Entities.Concrete.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class SoruEntityConfiguration : IEntityTypeConfiguration<Soru>
    {
        public void Configure(EntityTypeBuilder<Soru> builder)
        {
            builder.HasOne(s => s.Konu)
                .WithMany(k => k.Sorular)
                .HasForeignKey(s => s.KonuId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
