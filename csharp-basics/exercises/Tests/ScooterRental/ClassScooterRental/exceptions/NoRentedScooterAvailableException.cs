namespace ScooterRental.Exceptions
{
    public class NoRentedScootersAvailableException : Exception
    {
        public NoRentedScootersAvailableException(string id) : base($"No scooter with id ${id} are available in service!")
        {

        }
    }
}