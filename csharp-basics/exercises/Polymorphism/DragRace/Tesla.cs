using System;

namespace DragRace
{
    public class Tesla
    {
        private int currentSpeed = 0;

        public void SpeedUp() {
            currentSpeed += 20;
        }

        public void SlowDown() {
            currentSpeed += 20;
        }

        public string ShowCurrentSpeed() {
            return currentSpeed.ToString();
        }

        public void StartEngine() {
            Console.WriteLine("-- silence ---");
        }
    }
}