namespace ScooterRental
{
    public class RentedScooters
    {
        public DateTime StartTime;
        public DateTime? EndTime;
        public string scooterId;
        public decimal pricePerMinute;
        
        public RentalCompany(string name, IScooterService scooterService)
        {
            
        }
}