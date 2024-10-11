namespace ScooterRental.Exceptions
{
    public class DuplicateIdException : Exception
    {
        public DuplicateIdException(string id) : base($"Non-duplicate Id {id} is required!")
        {

        }
    }
}