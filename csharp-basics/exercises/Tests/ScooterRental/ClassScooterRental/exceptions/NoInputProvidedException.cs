namespace ScooterRental.Exceptions
{
    public class NoInputProvidedException : Exception
    {
        public NoInputProvidedException() : base($"No id is provided!")
        {

        }
    }
}