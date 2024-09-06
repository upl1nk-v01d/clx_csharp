using System;

namespace DragRace
{
    public class Mosquitch : Car, ICar
    {
        public override void SpeedUp()
        {
            _currentSpeed += 2;
        }

        public override void SlowDown()
        {
            _currentSpeed -= 8;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Brrrr.....");
        }
    }
}