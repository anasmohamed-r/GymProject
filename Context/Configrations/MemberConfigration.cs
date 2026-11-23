using GymProject.Entites;
using Microsoft.EntityFrameworkCore;

namespace GymProject.Context.Configrations
{
    public class MemberConfigration : GymUserConfigrations<Member> , IEntityTypeConfiguration<Member>
    {
        public new void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Member> builder)
        {

            builder.Property(m => m.CreatedAt)
                   .HasColumnName("JoinDate")
                   .HasDefaultValueSql("GETDATE()");

            
            base.Configure(builder);
        }
    }
}
