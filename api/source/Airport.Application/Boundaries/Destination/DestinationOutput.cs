using System.Collections.Generic;

namespace Airport.Application.Boundaries.Destination
{
    using Airport.Domain.Destination;

    public sealed class DestinationOutput
    {
        public List<Destination> Destinations { get; set; }

        public DestinationOutput(List<Destination> destinations)
        {
            Destinations = destinations;
        }
    }
}