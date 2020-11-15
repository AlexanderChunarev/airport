namespace Airport.Application.Boundaries.Destination
{
    using Airport.Domain.Destination;

    public class DestinationInput
    {
        public Destination Destination { get; set; }

        public DestinationInput(Destination destination)
        {
            Destination = destination;
        }
    }
}