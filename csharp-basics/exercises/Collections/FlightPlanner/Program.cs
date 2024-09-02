using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../FlightPlanner/flights.txt";

        private static string GetUSerChoiceValue(List<string> flights, int startPointPos)
        {
            var num = 0;
            var flight = "";

            foreach(var startPoint in flights)
            {
                num++;

                if(startPointPos == num)
                {
                    flight = startPoint;
                }
            }

            return flight;
        }

        private static void ShowAvailableCities(List<string> flights)
        {
            var num = 0;

            foreach(var startPoint in flights)
            {
                num++;
                Console.WriteLine($"{num}. {startPoint}");
            }
        }

        private static Dictionary<string, List<string>> ExtractFlightsToDictionary()
        {
            var readText = File.ReadAllLines(Path);

            var flightPairs = readText
            .Select(pair => new KeyValuePair<string, string>(pair.Split(" -> ")[0],pair.Split(" -> ")[1]))
            .ToList();

            var flightPath = new List<string>();
            var flightDictionary = new Dictionary<string, List<string>>();

            foreach(var pair in flightPairs)
            {
                if(flightDictionary.ContainsKey(pair.Key))
                {
                    flightDictionary[pair.Key].Add(pair.Key);
                }
                else
                {
                    flightDictionary[pair.Key] = new List<string>{ pair.Value };
                }
            }

            return flightDictionary;
        }

        private static void Main(string[] args)
        {
            Console.Clear();

            var flightDictionary = ExtractFlightsToDictionary();
            var flightPath = new List<string>();
            ShowAvailableCities(flightDictionary.Keys.ToList());
            Console.WriteLine("\nPick a start point: ");

            int prompt = Convert.ToInt32(Console.ReadLine());
            var startPointPos = prompt;

            var firstFlight = GetUSerChoiceValue(flightDictionary.Keys.ToList(), startPointPos);
            flightPath.Add(firstFlight);
            var firstTime = true;
            var firstDestination = GetUSerChoiceValue(flightDictionary[firstFlight], startPointPos);

            var destination = "";
            ShowAvailableCities(flightDictionary[firstDestination]);
            Console.WriteLine("\nPick a end point: ");

            
            while(firstFlight != destination)
            {
                var key = firstTime ? firstFlight : destination;
                ShowAvailableCities(flightDictionary[key]);
                Console.WriteLine("\nPick a end point: ");

                prompt = Convert.ToInt32(Console.ReadLine());
                startPointPos = prompt;
                destination = GetUSerChoiceValue(flightDictionary[key], startPointPos);
                flightPath.Add(destination);
                firstTime = false;
            }

            Console.WriteLine($"{string.Join(" -> ", flightPath)}");
        }
    }
}
