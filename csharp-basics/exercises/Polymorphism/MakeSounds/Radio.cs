using System;

namespace MakeSounds
{
    class Radio : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("hhhrrrshshshs...");
        }

        public Radio()
        {
            this.PlaySound();
        }
    }
}