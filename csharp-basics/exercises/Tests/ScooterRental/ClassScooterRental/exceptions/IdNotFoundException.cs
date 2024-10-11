namespace ScooterRental.Exceptions
{
    public class IdNotFoundException : Exception
    {
        public IdNotFoundException(string id) : base($"Id {id} does not exist!")
        {

        }
    }
}