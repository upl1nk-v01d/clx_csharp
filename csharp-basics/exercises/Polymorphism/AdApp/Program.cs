﻿using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();

            var campaign1 = new Campaign("The Post");
            campaign1.AddAdvert(new Advert(1000)); //fee
            campaign1.AddAdvert(new Hoarding(500, 7, 1)); //fee, days, rate koef
            campaign1.AddAdvert(new NewspaperAd(2, 21, 52, 50)); //fee, columns, size, additional charge in percent
            campaign1.AddAdvert(new TVAd(50000, 1000, 30, true)); //fee, views, seconds, what is 'true'?
            Console.WriteLine("\n" + campaign1 + "\n");
        }
    }
}