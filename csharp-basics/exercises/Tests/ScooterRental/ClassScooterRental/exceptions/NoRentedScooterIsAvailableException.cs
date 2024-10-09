namespace ScooterRental.Exceptions
{
    public class NoRentedScooterIsAvailableException : Exception
    {
        public NoRentedScooterIsAvailableException(string id) : base($"No rented scooter with id ${id} is available in company!")
        {

        }
    }
}