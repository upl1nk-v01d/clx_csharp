using System;
using System.Text.RegularExpressions;

namespace Exercise5
{
    class Program
    {

        private static void sleep(int delay=1){
            System.Threading.Thread.Sleep(delay);
        }
        static void clc(){
            Console.Clear();
        }
        static void exit(int p){
            System.Environment.Exit(p);
        }

        static void displayText(string text="\n", int tick=30, int newLines=1, int delay=0){
             if(text.Length<1){
                Console.Write("\n");
             } else {
                for(int i1=0;i1<text.Length;i1++){
                    Console.Write(text[i1]);
                    sleep(tick);
                    if(newLines>0 && i1 == text.Length-1){
                        for(int i=0;i<newLines;i++){
                            Console.Write("\n");
                        }
                    }
                }
            }
            sleep(delay);
        }
        private static void Main(string[] args)
        {
            string[] sequence = {
                "Press any key to start creating an array with 10 random integers.",
                "Press any key to duplicate array.",
                "Press any key to change second array last element value.",
            };
            
            Regex rx = new Regex("[^0-9]");
            Random rnd = new Random();
            bool quit=false;
            int sw = 0;

            List<int> list1 = new List<int>(); 
            List<int> list2 = new List<int>(); 

            int[] arr1 = [];
            int[] arr2 = [];

            clc();
            displayText("-= Array Create & Copy =-",tick:0,delay:1000);
            displayText("This program creates array and duplicates it.",delay:1000);

            while(!quit){

                if(sw < sequence.GetLength(0)){
                    displayText(sequence[sw]); 
                    if(sw == 0){
                        Console.ReadKey(true);
                        displayText("");
                        displayText($"Creating array with 10 random integers...",newLines:2,delay:500); 
                        for(int i=0;i<10;i++){
                            list1.Add(rnd.Next(1,101));
                            displayText($"{list1[i]}\t",newLines:0);
                            if((i+1) % 5 == 0){ displayText(""); }
                        }
                        arr1 = list1.ToArray();
                        displayText("");
                    }
                    if(sw == 1){
                        Console.ReadKey(true);
                        clc();
                        displayText($"Duplicating array...",newLines:2,delay:500); 
                        for(int i=0;i<arr1.GetLength(0);i++){
                            list2.Add(arr1[i]);
                            displayText($"{list2[i]}\t",newLines:0);
                            if((i+1) % 5 == 0){ displayText(""); }
                        }
                        arr2 = list2.ToArray();
                        displayText("");
                        
                        displayText($"Original array content...",newLines:2,delay:500); 
                        for(int i=0;i<arr1.GetLength(0);i++){
                            displayText($"{arr1[i]}\t",newLines:0);
                            if((i+1) % 5 == 0){ displayText(""); }
                        }
                        displayText("");
                    }             
                    if(sw == 2){
                        Console.ReadKey(true);
                        clc();
                        displayText($"Changing second array last element value...",newLines:2,delay:500); 
                        arr2[arr2.GetLength(0)-1] = rnd.Next(1,101);

                        displayText($"Original array content...",newLines:2,delay:500); 
                        for(int i=0;i<arr1.GetLength(0);i++){
                            displayText($"{arr1[i]}\t",newLines:0);
                            if((i+1) % 5 == 0){ displayText(""); }
                        }
                        displayText("");

                        displayText($"Modified array content...",newLines:2,delay:500); 
                        for(int i=0;i<arr2.GetLength(0);i++){
                            displayText($"{arr2[i]}\t",newLines:0);
                            if((i+1) % 5 == 0){ displayText(""); }
                        }
                        displayText("");
                    }             
                    sw++;
                } else {
                    displayText("",delay:1000);
                    displayText("Press any key to retry!");
                    displayText("Press 'q' key to abort!");
                    
                    if(Console.ReadKey(true).Key.ToString() == "Q"){
                        quit = true;
                    } else {
                        sw=0;
                        list1 = [];
                        list2 = [];
                        arr1 = [];
                        arr2 = [];
                        clc();
                    }
                }
                    
                if(quit){
                    clc();
                    quit=true;
                    displayText("Goodbye! :)",delay:1000);
                    clc();
                    exit(1);
                }
                
            }
        }
    }
}
