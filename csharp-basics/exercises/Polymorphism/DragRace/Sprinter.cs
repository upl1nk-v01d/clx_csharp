using System;

namespace DragRace
{
    public class Sprinter : Car, ICar
    {
        public override void SpeedUp()
        {
            _currentSpeed += 6;
        }

        public override void SlowDown()
        {
            _currentSpeed -= 8;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Hrrrrrr.....");
        }
    }
}