namespace ScooterRental
{
    public class RentedScooter
    {
        public DateTime _startTime;
        public DateTime? _endTime;
        public string _scooterId;
        public decimal _pricePerMinute;
        public string _name;
        public IScooterService _scooterService;

        public RentedScooter(string name, IScooterService scooterService, string scooterId, decimal pricePerMinute, DateTime StartTime)
        {
            _name = name;
            _scooterService = scooterService;
            _scooterId = scooterId;
            _pricePerMinute = pricePerMinute;
            _startTime = StartTime;
        }
    }
}
