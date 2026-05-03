using Core.Entities.Concrete.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class KonuEntityConfiguration : IEntityTypeConfiguration<Konu>
    {
        public void Configure(EntityTypeBuilder<Konu> builder)
        {
            builder.HasOne(k => k.Bolum)
                .WithMany(b => b.Konular)
                .HasForeignKey(k => k.BolumId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
