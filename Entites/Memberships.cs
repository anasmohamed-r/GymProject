using System.ComponentModel.DataAnnotations.Schema;

namespace GymProject.Entites
{
    public class Memberships : BaseEntity
    {
        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int PlanId { get; set; }
        public Plan Plan { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [NotMapped]
        public string Status => StartDate >= DateTime.Now ? "Upcoming" 
                               : EndDate >= DateTime.Now ? "Active"
                               : "Expired";
    }
}
