using System;

namespace Exercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};

            double sum = 0;
            int counter = 0;
            double average;
            for (int i=0;i<numbers.GetLength(0);i++){
                sum += numbers[i];
                counter++;
            }

            average = sum / counter;

            Console.WriteLine();
            Console.WriteLine($"Average value of the array elements is : {average:0.00}");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit program!");
            Console.ReadKey(true);
        }
    }
}
