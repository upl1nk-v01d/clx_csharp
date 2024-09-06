using System;

namespace DragRace
{
    public abstract class Car
    {
        protected int _currentSpeed;

        protected Car()
        {
            _currentSpeed = 0;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public abstract void SpeedUp();
        
        public virtual void SlowDown() 
        {
            var random = new Random();
            _currentSpeed = random.Next(1, 10);
        }
    }
}