using GymProject.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymProject.Context.Configrations
{
    public class MembershipConfigration : IEntityTypeConfiguration<Memberships>
    {
        public void Configure(EntityTypeBuilder<Memberships> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");


        }
    }
}
