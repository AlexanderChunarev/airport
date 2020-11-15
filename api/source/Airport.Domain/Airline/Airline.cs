using System.Collections.Generic;

namespace Airport.Domain.Airline
{
    using Plane;
    public class Airline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Plane> Planes { get; set; }
    }
}