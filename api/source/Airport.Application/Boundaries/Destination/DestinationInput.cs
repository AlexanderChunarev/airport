using System.Collections.Generic;

namespace Airport.Application.Boundaries.Destination
{
    using Airport.Domain.Destination;

    public class DestinationInput
    {
        public List<Destination> Destinations { get; set; }

        public DestinationInput(List<Destination> destinations)
        {
            Destinations = destinations;
        }
    }
}