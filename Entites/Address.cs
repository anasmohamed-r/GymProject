namespace GymProject.Entites
{
    public class Address
    {
        public string street { get; set; } = default!;
        public string city { get; set; } = default!;

        public int BuildingNumber { get; set; }
    }
}
