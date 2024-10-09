namespace ScooterRental.Exceptions
{
    public class NoRentedScootersAvailableException : Exception
    {
        public NoRentedScootersAvailableException() : base($"No rented scooters are available in company!")
        {

        }
    }
}