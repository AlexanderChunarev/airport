namespace Airport.Domain.Plane
{
    public class Plane
    {
        public int Id { get; set; }
        public int AirlineId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}