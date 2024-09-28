using System;

namespace DragRace
{
    public class Audi : Car, ICar
    {
        public override void SpeedUp()
        {
            _currentSpeed += 10;
        }

        public override void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}