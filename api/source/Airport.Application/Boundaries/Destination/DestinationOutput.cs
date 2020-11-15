namespace Airport.Application.Boundaries.Destination
{
    using Airport.Domain.Destination;

    public sealed class DestinationOutput
    {
        public Destination Destination { get; set; }

        public DestinationOutput(Destination destination)
        {
            Destination = destination;
        }
    }
}