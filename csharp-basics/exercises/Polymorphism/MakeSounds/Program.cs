using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static List<ISound> parrots = new List<ISound>();
        
        private static List<ISound> radios = new List<ISound>();

        private static List<ISound> fireworks = new List<ISound>();

        private static void MakeParrotSounds()
        {
            for(int i = 0; i < 5; i++)
            {
                ISound parrot = new Parrot();
                parrots.Add(parrot);
            }

            foreach(var parrot in parrots)
            {
                parrot.PlaySound();
            }
        }

        private static void MakeRadioSounds()
        {
            for(int i = 0; i < 5; i++)
            {
                ISound radio = new Radio();
                radios.Add(radio);
            }

            foreach(var radio in radios)
            {
                radio.PlaySound();
            }
        }

        private static void MakeFireworksSounds()
        {
            for(int i = 0; i < 5; i++)
            {
                ISound firework = new Firework();
                fireworks.Add(firework);
            }

            foreach(var firework in fireworks)
            {
                firework.PlaySound();
            }
        }

        private static void Main(string[] args)
        {
            Console.Clear();
            
            MakeParrotSounds();
            MakeRadioSounds();
            MakeFireworksSounds();
        }
    }
}