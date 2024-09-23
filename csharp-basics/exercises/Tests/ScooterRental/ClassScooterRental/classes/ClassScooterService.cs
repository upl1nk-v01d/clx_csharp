using ScooterRental.Exceptions;

namespace ScooterRental
{
    public class ScooterService : IScooterService
    {
        private readonly List<Scooter> _inventory;
        
        public ScooterService(List<Scooter> inventory)
        {
            _inventory = inventory;
        }

        public void AddScooter(string id, decimal pricePerMinute)
        {
            if(string.IsNullOrEmpty(id))
            {
                throw new InvalidIdException(id);
            }

            if(pricePerMinute <= 0)
            {
                throw new InvalidPriceException();
            }

            if(_inventory.Any(scooter => scooter.Id == id))
            {
                throw new DuplicateIdException(id);
            }

            _inventory.Add(new Scooter(id, pricePerMinute));
        }

        public void RemoveScooter(string id)
        {
            if(string.IsNullOrEmpty(id))
            {
                throw new InvalidIdException(id);
            }

            if(_inventory.Count > 0)
            {
                if(_inventory.Any(scooter => scooter.Id == id))
                {
                    _inventory.RemoveAll(scooter => scooter.Id == id);
                }
                else
                {
                    throw new InvalidIdException(id);
                }
            }
            else
            {
                throw new NoScootersAvailableException();
            }
        }

        public IList<ScooterService> GetScooters()
        {
            
            if(_inventory.Count > 0)
            {
                return (IList<ScooterService>)_inventory;
            }
            else
            {
                throw new NoScootersAvailableException();
            }
        }

        public ScooterService GetScooterById(string scooterId)
        {
            if(string.IsNullOrEmpty(scooterId))
            {
                throw new InvalidIdException(scooterId);
            }

            if(_inventory.Any(scooter => scooter.Id == scooterId))
            {                
                var scooter = _inventory.First(scooter => scooter.Id == scooterId;
                return List<ScooterService>)scooter;
            }

            throw new NoScootersAvailableException();
        }
    }
}