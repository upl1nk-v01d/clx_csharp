namespace ScooterRental
{
    public class RentedScooter
    {
        public DateTime _startTime;
        public DateTime _endTime;
        public string _scooterId;
        public decimal _pricePerMinute;

        public RentedScooter(string scooterId, decimal pricePerMinute, DateTime StartTime)
        {
            _scooterId = scooterId;
            _pricePerMinute = pricePerMinute;
            _startTime = StartTime;
        }
    }
}
