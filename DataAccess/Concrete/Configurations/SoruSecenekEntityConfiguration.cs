using Core.Entities.Concrete.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class SoruSecenekEntityConfiguration : IEntityTypeConfiguration<SoruSecenek>
    {
        public void Configure(EntityTypeBuilder<SoruSecenek> builder)
        {
            builder.HasOne(se => se.Soru)
                .WithMany(s => s.Secenekler)
                .HasForeignKey(se => se.SoruId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
