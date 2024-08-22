namespace exc06
{
    class Program
    {

        private static void Sleep(int delay = 1)
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

        static void DisplayText(string text = "\n", int tick = 30, int newLines = 1, int delay = 0)
        {
             if(text.Length < 1)
             {
                Console.Write("\n");
             } 
             
             else 
             {
                for(int i1 = 0; i1 < text.Length; i1++)
                {
                    Console.Write(text[i1]);
                    Sleep(tick);

                    if(newLines > 0 && i1 == text.Length - 1)
                    {
                        for(int i = 0; i < newLines; i++){
                            Console.Write("\n");
                        }
                    }
                }
            }

            Sleep(delay);
        }

        private static void Main(string[] args)
        {
            string[] sequence = 
            {
                "Press any key to start creating an array with 10 random integers.",
                "Press any key to duplicate array.",
                "Press any key to change second array last element value.",
            };
            
            Random randomNumbers = new Random();

            bool quit = false;

            int sw = 0;

            List<int> list1 = new List<int>(); 
            List<int> list2 = new List<int>(); 

            int[] arr1 = [];
            int[] arr2 = [];

            Clear();
            DisplayText("-= Array Create & Copy =-", tick: 0, delay: 1000);
            DisplayText("This program creates array and duplicates it.", delay: 1000);

            while(!quit)
            {
                if(sw < sequence.GetLength(0))
                {
                    DisplayText(sequence[sw]);

                    if(sw == 0){
                        Console.ReadKey(true);
                        DisplayText("");
                        DisplayText($"Creating array with 10 random integers...", newLines: 2, delay: 500); 
                        
                        for(int i = 0; i < 10; i++)
                        {
                            list1.Add(randomNumbers.Next(1, 101));
                            DisplayText($"{list1[i]}\t", newLines: 0);

                            if((i + 1) % 5 == 0)
                            { 
                                DisplayText(""); 
                            }
                        }

                        arr1 = list1.ToArray();

                        DisplayText("");
                    }

                    if(sw == 1)
                    {
                        Console.ReadKey(true);

                        Clear();
                        DisplayText($"Duplicating array...", newLines: 2, delay: 500); 

                        for(int i = 0; i < arr1.GetLength(0); i++)
                        {
                            list2.Add(arr1[i]);
                            DisplayText($"{list2[i]}\t", newLines: 0);

                            if((i + 1) % 5 == 0)
                            { 
                                DisplayText(""); 
                            }
                        }

                        arr2 = list2.ToArray();

                        DisplayText("");
                        DisplayText($"Original array content...", newLines: 2, delay: 500); 

                        for(int i = 0; i < arr1.GetLength(0); i++)
                        {
                            DisplayText($"{arr1[i]}\t", newLines: 0);

                            if((i + 1) % 5 == 0)
                            {
                                DisplayText(""); 
                            }
                        }

                        DisplayText("");
                    }    

                    if(sw == 2)
                    {
                        Console.ReadKey(true);
                        Clear();
                        DisplayText($"Changing second array's last element value...", newLines: 2, delay: 500); 
                        
                        arr2[arr2.GetLength(0) - 1] = randomNumbers.Next(1, 101);

                        DisplayText($"Original array content...", newLines: 2, delay: 500); 

                        for(int i = 0; i < arr1.GetLength(0); i++)
                        {
                            DisplayText($"{arr1[i]}\t", newLines: 0);

                            if((i + 1) % 5 == 0)
                            { 
                                DisplayText("");
                            }
                        }

                        DisplayText("");
                        DisplayText($"Modified array content...", newLines: 2, delay: 500); 

                        for(int i = 0; i < arr2.GetLength(0); i++)
                        {
                            DisplayText($"{arr2[i]}\t", newLines: 0);

                            if((i + 1) % 5 == 0)
                            { 
                                DisplayText(""); 
                            }
                        }

                        DisplayText("");
                    }  

                    sw++;
                } 
                
                else 
                {
                    DisplayText("", delay: 1000);
                    DisplayText("Press any key to retry!");
                    DisplayText("Press 'q' key to abort!");
                    
                    if(Console.ReadKey(true).Key.ToString() == "Q")
                    {
                        quit = true;
                    } 
                    
                    else 
                    {
                        sw = 0;
                        list1 = [];
                        list2 = [];
                        arr1 = [];
                        arr2 = [];
                        Clear();
                    }
                }
                    
                if(quit)
                {
                    Clear();
                    DisplayText("Goodbye! :)", delay: 1000);

                    Clear();
                    Exit(1);
                }
            }
        }
    }
}
