namespace ScooterRental.Exceptions
{
    public class InvalidIdException : Exception
    {
        public InvalidIdException(string id) : base($"Id {id} is not valid!")
        {

        }
    }
}