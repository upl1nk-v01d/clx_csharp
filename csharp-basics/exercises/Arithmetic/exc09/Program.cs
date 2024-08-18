﻿using System.Text.RegularExpressions;
class Program{

    static void sleep(int delay=1){
        System.Threading.Thread.Sleep(delay);
    }
    static void clc(){
        Console.Clear();
    }
    static void exit(int p){
        System.Environment.Exit(p);
    }

    static void displayText(string text="\n", int delay=30, int el=1){
        for(int i1=0;i1<text.Length;i1++){
            Console.Write(text[i1]);
            sleep(delay);
            if(el==1 && i1 == text.Length-1){
                Console.Write("\n");
            }
        }
    }
    static void Main(string[] args){

        Regex rx = new Regex("[^0-9]");

        clc();
        sleep(22);
        displayText("-= BMI =-");
        sleep(1000);
        displayText("This program calculates human body mass index.");
        sleep(22);
        displayText("Note that weight is measured in pounds and height is measured in inches.");
        sleep(22);
        displayText("Press any key to start...");
        Console.ReadKey();

        bool quit=false, err=false, retry=false;
        int sw=0;
        double weightMetric = 0;
        double heightMetric = 0;
        string? prompt;

        while(!quit){

            if(!err){ 
                Console.Clear(); 
            }

            prompt = "";
            err = false;
            retry=false;
           
            if(sw == 0){
                displayText("To quit program just enter character 'q' in prompt");
                displayText("Please enter weight in centimeters: ",30,0);
                prompt = Console.ReadLine();
            }
            if(sw == 1){
                displayText("Now enter height in metric units: ",30,0);
                prompt = Console.ReadLine();
            }
            if(sw > 1){
                clc();
                displayText($"Body mass index is: ",30,0);
                sleep(150);

                //main procedure
                double weightPounds = weightMetric*2.20462;
                double heightInches = heightMetric*0.393701;
                double inchesSquare = heightInches*heightInches;

                //displayText(weightPounds.ToString()); //176
                //displayText(heightInches.ToString()); //70
                //displayText(inchesSquare.ToString()); //5022

                //Finally!!! The correct calculation.
                //href https://www.calculatorsoup.com/calculators/health/bmi-calculator.php
                double BMI = (weightPounds / (heightInches*heightInches)) * 703;
                
                //calculting in metric values:
                //decimal BMI = weightMetric / (( heightMetric / 100.0m) * (heightMetric / 100.0m));

                displayText($"{BMI:0.00}");
                sleep(1000);

                if(BMI>=18.5 && BMI <=25){
                    displayText("A sedentary person's weight is considered optimal.");
                } else if(BMI<18.5){
                    displayText("A sedentary person's weight is considered underweight.");
                } else if(BMI>25){
                    displayText("A sedentary person's weight is considered overweight.");
                }

                sleep(1000);
 
                Console.WriteLine($"Press 'q' key to exit program or any other key to continue.");

                if(Console.ReadKey(true).Key == ConsoleKey.Q){
                    clc();
                    quit=true;
                    displayText("Exiting program!");
                    sleep(1000);
                    exit(1);
                } else {
                    retry=true;
                    sw=0;
                }
            }

            if(!retry){
                if(prompt.ToLower() == "q"){
                    Console.Clear();
                    displayText("Exiting program!");
                    quit = true;
                    sleep(1000);
                    exit(1);
                } else if(rx.Matches(prompt).Count > 0){
                    err = true;
                    clc();
                    displayText("Are you following or already tired? :/");
                    sleep(1000);
                    displayText("Please enter only digits! :)");
                    sleep(1000);
                } else if(prompt.Length<=0){
                    err = true;
                    clc();
                    displayText("Eh?!");
                    sleep(1000);
                    displayText("Type in something...");
                    sleep(1000);
                } else if(int.Parse(prompt)<1){
                    displayText();
                    displayText("Please enter number higher than 0");
                    sleep(2000);
                } else {
                    if(sw == 0){ weightMetric = double.Parse(prompt); }
                    if(sw == 1){ heightMetric = double.Parse(prompt); }
                    sw++;
                }
            }
        }
    }
}