using System;

namespace DragRace
{
    public class Tesla : Car, ICar
    {
        public override void SpeedUp() 
        {
            _currentSpeed += 11;
        }

        public void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }
    }
}