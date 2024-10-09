namespace ScooterRental.Exceptions
{
    public class NoScootersAvailableException : Exception
    {
        public NoScootersAvailableException() : base($"No scooters are available in service!")
        {

        }
    }
}