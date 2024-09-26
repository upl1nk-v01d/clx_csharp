namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IScooterService _scooterService;
        
        public RentalCompany(string name, IScooterService scooterService)
        {
            Name = name;
            _scooterService = scooterService;
        }

        public string Name { get; }

        public void StartRent(string id)
        {            
            Scooter scooter = _scooterService.GetScooterById(id);

            if(scooter == null)
            {
                throw new InvalidOperationException();
            }

            if(scooter.IsRented)
            {
                throw new InvalidOperationException();
            }
            
            scooter.IsRented = true;
        }
        
        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            throw new NotImplementedException();
        }

        public decimal EndRent(string id)
        {
            Scooter scooter = _scooterService.GetScooterById(id);

            if(scooter == null)
            {
                throw new InvalidOperationException();
            }

            if(!scooter.IsRented)
            {
                throw new InvalidOperationException();
            }
            
            scooter.IsRented = false;

            return scooter.PricePerMinute;
        }
    }
}