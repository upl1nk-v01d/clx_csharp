namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IScooterService _scooterService;
        public readonly List<RentedScooter> _rentedScooters;
        
        public RentalCompany(string name, IScooterService scooterService, List<RentedScooter> rentedScooters)
        {
            Name = name;
            _scooterService = scooterService;
            _rentedScooters = rentedScooters;
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

            var rentedScooter = new RentedScooter(scooter.Id, scooter.PricePerMinute, DateTime.Now);
            //rentedScooter.StartTime = new DateTime(2024, 01, 01, 10, 00, 00); DateTime.Now

            //_rentedScooters.Add(rentedScooter);
        }
        
        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            if(year > DateTime.Now.Year || _rentedScooters.Count < 1)
            {
                throw new InvalidOperationException();
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

            return sum;
        }

        public decimal EndRent(string id)
        {
            Scooter scooter = _scooterService.GetScooterById(id);

            if(scooter == null || scooter.IsRented == false)
            {
                throw new InvalidOperationException();
            }
            
            scooter.IsRented = false;

            var rentedScooter = new RentedScooter(scooter.Id, scooter.PricePerMinute, DateTime.Now);
            rentedScooter._endTime = DateTime.Now;

            return scooter.PricePerMinute;
        }
    }
}