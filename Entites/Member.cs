namespace GymProject.Entites
{
    public class Member : GymUser
    {
        public string? Photo { get; set; }

        public ICollection<Memberships> MemberSubscription { get; set; } = default!;
    }
}
