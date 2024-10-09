namespace ScooterRental.Exceptions
{
    public class RentedIdException : Exception
    {
        public RentedIdException(string id) : base($"Id {id} cannot be removed while it is rented!")
        {

        }
    }
}