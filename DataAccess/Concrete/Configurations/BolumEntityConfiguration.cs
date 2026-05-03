using Core.Entities.Concrete.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class BolumEntityConfiguration : IEntityTypeConfiguration<Bolum>
    {
        public void Configure(EntityTypeBuilder<Bolum> builder)
        {
            builder.HasOne(b => b.Sinav)
                .WithMany(s => s.Bolumler)
                .HasForeignKey(b => b.SinavId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
