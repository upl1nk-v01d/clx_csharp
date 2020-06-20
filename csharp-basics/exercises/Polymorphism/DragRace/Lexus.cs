using System;

namespace DragRace
{
    public class Lexus
    {
        private int currentSpeed = 0;

        public void SpeedUp() {
            currentSpeed += 8;
        }

        public void SlowDown() {
            currentSpeed += 8;
        }

        public string ShowCurrentSpeed() {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() {
            currentSpeed += 30;
        }

        public void StartEngine() {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}