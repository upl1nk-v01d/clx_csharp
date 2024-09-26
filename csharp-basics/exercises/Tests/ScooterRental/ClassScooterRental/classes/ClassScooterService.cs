using System.Text.RegularExpressions;
using ScooterRental.Exceptions;

namespace ScooterRental
{
    public class ScooterService : IScooterService
    {
        private readonly List<Scooter> _inventory;
        //private Regex regexIsNumbers = new Regex("[0-9]");
        
        public ScooterService(List<Scooter> inventory)
        {
            _inventory = inventory;
        }

        private bool IdInputCheck(string id)
        {
            if(Regex.Matches(id, "[^0-9]").Count > 0)
            {
                return false;
            }

            return true;
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
                    var scooter = _inventory.First(scooter => scooter.Id == id);

                    if(scooter.IsRented)
                    {
                        throw new RentedIdException(id);
                    }
                    else
                    {
                        _inventory.RemoveAll(scooter => scooter.Id == id);
                        return;
                    }
                }
                else
                {
                    throw new InvalidIdException(id);
                }
            }
            
            throw new NoScootersAvailableException();
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

        public Scooter GetScooterById(string scooterId)
        {
            if(string.IsNullOrEmpty(scooterId))
            {
                throw new NoInputProvidedException();
            }

            if(!IdInputCheck(scooterId))
            {
                throw new InvalidIdException(scooterId);
            }

            if(_inventory.Any(scooter => scooter.Id == scooterId))
            {                
                Scooter scooter = _inventory.First(scooter => scooter.Id == scooterId);
                return scooter;
            }
            else 
            {
                throw new IdNotFoundException(scooterId);
            }

            throw new NoScootersAvailableException();
        }
    }
}