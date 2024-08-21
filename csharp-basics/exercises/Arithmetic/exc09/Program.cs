using System.Text.RegularExpressions;
class Program
{

    static void Sleep(int delay = 1)
    {
        System.Threading.Thread.Sleep(delay);
    }

    static void Clear()
    {
        Console.Clear();
    }

    static void Exit(int num)
    {
        System.Environment.Exit(num);
    }

    static void DisplayText(string text = "\n", int delay = 30, int newLine = 1)
    {
        for(int i1 = 0; i1 < text.Length; i1++){

            Console.Write(text[i1]);
            Sleep(delay);
            
            if(newLine == 1 && i1 == text.Length - 1)
            {
                Console.Write("\n");
            }
        }
    }

    static void Main(string[] args)
    {

        Regex rx = new Regex("[^0-9]");

        Clear();
        Sleep(22);
        DisplayText("-= BMI =-");
        Sleep(1000);

        DisplayText("This program calculates human body mass index.");
        Sleep(22);

        DisplayText("Note that weight is measured in pounds and height is measured in inches.");
        Sleep(22);
        
        DisplayText("Press any key to start...");
        
        Console.ReadKey();

        bool quit = false; 
        bool error = false; 
        bool retry = false;

        double weightMetric = 0;
        double heightMetric = 0;

        int sw = 0;

        string prompt;

        while(!quit)
        {

            if(!error)
            { 
                Console.Clear(); 
            }

            prompt = "";
            error = false;
            retry = false;
           
            if(sw == 0)
            {
                DisplayText("To quit program just enter character 'q' in prompt");
                DisplayText("Please enter weight in centimeters: ",newLine: 0);
                prompt = Console.ReadLine()!;
            }

            if(sw == 1)
            {
                DisplayText("Now enter height in metric units: ",newLine: 0);
                prompt = Console.ReadLine()!;
            }

            if(sw > 1)
            {
                Clear();
                DisplayText($"Body mass index is: ",newLine: 0);
                Sleep(150);

                //main procedure
                double weightPounds = weightMetric * 2.20462;
                double heightInches = heightMetric * 0.393701;
                double inchesSquare = heightInches * heightInches;

                //DisplayText(weightPounds.ToString()); //176
                //DisplayText(heightInches.ToString()); //70
                //DisplayText(inchesSquare.ToString()); //5022

                //Finally!!! The correct calculation.
                //href https://www.calculatorsoup.com/calculators/health/bmi-calculator.php
                double BMI = (weightPounds / (heightInches*heightInches)) * 703;
                
                //calculting in metric values:
                //decimal BMI = weightMetric / (( heightMetric / 100.0m) * (heightMetric / 100.0m));

                DisplayText($"{BMI:0.00}");
                Sleep(1000);

                if(BMI >= 18.5 && BMI <= 25)
                {
                    DisplayText("A sedentary person's weight is considered optimal.");
                } 
                
                else if(BMI < 18.5)
                {
                    DisplayText("A sedentary person's weight is considered underweight.");
                } 
                
                else if(BMI > 25)
                {
                    DisplayText("A sedentary person's weight is considered overweight.");
                }

                Sleep(1000);
 
                Console.WriteLine($"Press 'q' key to Exit program or any other key to continue.");

                if(Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    quit = true;
                    
                    Clear();                    
                    DisplayText("Exiting program!");
                    Sleep(1000);
                    Exit(1);
                } 
                
                else 
                {
                    retry = true;
                    sw = 0;
                }
            }

            if(!retry)
            {
                if(prompt.ToLower() == "q")
                {
                    quit = true;

                    Console.Clear();
                    DisplayText("Exiting program!");
                    Sleep(1000);

                    Exit(1);
                } 
                
                else if(rx.Matches(prompt).Count > 0)
                {
                    error = true;

                    Clear();
                    DisplayText("Are you following or already tired? :/");
                    Sleep(1000);

                    DisplayText("Please enter only digits! :)");
                    Sleep(1000);
                } 

                else if(prompt.Length <= 0)
                {
                    error = true;

                    Clear();
                    DisplayText("Eh?!");
                    Sleep(1000);
                    
                    DisplayText("Type in something...");
                    Sleep(1000);
                } 
                
                else if(int.Parse(prompt) < 1)
                {
                    DisplayText();
                    DisplayText("Please enter number higher than 0");
                    Sleep(2000);
                } 
                
                else 
                {
                    if(sw == 0)
                    { 
                        weightMetric = double.Parse(prompt); 
                    }

                    if(sw == 1)
                    { 
                        heightMetric = double.Parse(prompt); 
                    }
                    
                    sw++;
                }
            }
        }
    }
}