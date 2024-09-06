using System;

namespace DragRace
{
    public class Bmw : Car, ICar
    {
        public override void SpeedUp()
        {
            _currentSpeed += 8;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}