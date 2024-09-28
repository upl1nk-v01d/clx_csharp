using System;

namespace MakeSounds
{
    class Parrot : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("screech squawk!");
        }

        public Parrot()
        {
            this.PlaySound();
        }
    }
}