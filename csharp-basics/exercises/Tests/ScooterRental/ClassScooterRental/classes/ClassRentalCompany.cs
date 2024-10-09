using ScooterRental.Exceptions;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IScooterService _scooterService;
        private readonly List<RentedScooter> _rentedScooters;
        protected decimal _revenue;
        
        public RentalCompany(string name, IScooterService scooterService, List<RentedScooter> rentedScooters)
        {
            Name = name;
            _scooterService = scooterService;
            _rentedScooters = rentedScooters;
            _revenue = 0;
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
                throw new RentedIdException(id);
            }
            
            scooter.IsRented = true;

            var rentedScooter = new RentedScooter(scooter.Id, scooter.PricePerMinute, DateTime.Now);
            _rentedScooters.Add(rentedScooter);
        }
        
        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            if(year > DateTime.Now.Year)
            {
                throw new InvalidOperationException();
            }

            if(_rentedScooters.Count < 1)
            {
                throw new NoRentedScootersAvailableException();
            }

            decimal sum = 0m;

            foreach(RentedScooter scooter in _rentedScooters)
            {
                if(scooter._startTime.Year == year)
                {
                    TimeSpan minutes = scooter._endTime - scooter._startTime;

                    sum += Convert.ToDecimal(minutes.TotalMinutes) * scooter._pricePerMinute;
                }
            }

            return Decimal.Round(sum, 3);
        }

        public decimal EndRent(string id)
        {
            Scooter scooter = _scooterService.GetScooterById(id);

            if(scooter == null || scooter.IsRented == false)
            {
                throw new InvalidOperationException();
            }
            
            scooter.IsRented = false;

            var rentedScooter = this.GetRentedScooterById(id);
            rentedScooter._endTime = DateTime.Now;

            _revenue = this.CalculateIncome(DateTime.Now.Year, false);
            
            return scooter.PricePerMinute;
        }

        public RentedScooter GetRentedScooterById(string id)
        {
            if(_rentedScooters.Any(rentedScooter => rentedScooter._scooterId == id))
            {                
                RentedScooter rentedScooter = _rentedScooters.First(scooter => scooter._scooterId == id);
                return rentedScooter;
            }

            throw new NoRentedScooterIsAvailableException(id);
        }
    }
}