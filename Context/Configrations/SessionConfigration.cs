using GymProject.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymProject.Context.Configrations
{
    public class SessionConfigration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(s => s.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.HasOne(s => s.Trainer)
                   .WithMany( s=> s.Sessions )
                   .HasForeignKey(s => s.TrainerId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("CK_Session_Capacity", "Capacity Between 1 AND 25");
                t.HasCheckConstraint("CK_Session_StartDate", "StartDate < EndDate");
            });

        }
    }
}
