namespace ScooterRental.Exceptions
{
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException() : base("Price greater than 0 is required!")
        {

        }
    }
}