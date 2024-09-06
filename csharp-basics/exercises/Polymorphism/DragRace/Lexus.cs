using System;

namespace DragRace
{
    public class Lexus : Car, ICar, IBoostable
    {
        public override void SpeedUp() 
        {
            _currentSpeed += 9;
        }

        public void UseNitrousOxideEngine() 
        {
            _currentSpeed += 30;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}