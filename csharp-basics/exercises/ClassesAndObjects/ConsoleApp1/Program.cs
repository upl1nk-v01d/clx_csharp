using System;

namespace ConsoleApp1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("new odometer");
        //    //var fuelGauge = new FuelGauge();
        //    //for (int i = 0; i < 10; i++)
        //    //{
        //    //    fuelGauge.Fill();
        //    //}

        //    //Console.WriteLine($"fuel level:{fuelGauge.ReportLevel()}");
        //    //var odometer = new Odometer(fuelGauge);
        //    //Console.WriteLine("running...");
        //    //for (int i = 0; i < 200; i++)
        //    //{
        //    //    odometer.Increment();
        //    //    Console.WriteLine($"odometer report:{odometer.Report()}");
        //    //}
        //    //Console.ReadKey();


        //}

        //char[] misses;
        //int missesCount = 0;
        //char[] guess;
        static void Main(string[] args)
        {
            //RandomWordSpaces();
            Console.ReadKey();
        }
        public static void RandomWordSpaces1()
        {
            string[] words = { "rainbow", "forecasts", "programming", "elephant", "sunset", "desktop" };
            Random rand = new Random();
            int indexOfRandomWord = rand.Next(words.Length);
            int hiddenWordLenght = words[indexOfRandomWord].Length;
            char[] hiddenWord = words[indexOfRandomWord].ToCharArray();
            string hiddenWordString = new string('_', hiddenWordLenght);
            Console.WriteLine($"Find out which word is behind: {hiddenWordString}");
            int missesCount = 0;
            while (missesCount < 7)
            {
                Console.WriteLine("Which letter is in this word? (Enter only one)");
                char guessedLetter = Char.Parse(Console.ReadLine());
                // 
                while (true)
                {
                    if (Char.IsLetter(guessedLetter) == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter not a valid letter!");
                        Console.WriteLine("Enter a letter!");
                        guessedLetter =Char.Parse(Console.ReadLine());
                    }
                        
                }
                int indexOfHiddenLetter = -1;
                int l;
                var missedLetter = string.Empty;
                for (l = 0; l < hiddenWord.Length; l++)
                {
                    if (hiddenWord[l] == guessedLetter)
                    {
                        indexOfHiddenLetter = l;
                        var wordArray = hiddenWordString.ToCharArray();
                        wordArray[l] = guessedLetter;
                        hiddenWordString = new string(wordArray);
                        Console.WriteLine(hiddenWordString);
                    }
                    else
                    {
                        missedLetter += guessedLetter;
                        missesCount++;
                    }
                }
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine($"Word: {hiddenWordString}");
                Console.WriteLine($"Misses: {missesCount}");
                Console.WriteLine($"Guess: {guessedLetter}");
                Console.ReadKey();
            }
        }

        public static void RandomWord()
        {
                string[] words = { "rainbow", "forecasts", "programming", "elephant", "sunset", "desktop" };
            Random rand = new Random();
            int indexOfRandomWord = rand.Next(words.Length);//izvēles random vārda index
            int hiddenWordLenght = words[indexOfRandomWord].Length;//atrod vārda garumu
            char[] hiddenWord = words[indexOfRandomWord].ToCharArray(); //šeit ir atrastais vārds char array
            string hiddenWordString = new string('_', hiddenWordLenght); //paslēptāvārda burti ir aizvietoti ar _ un pēc tam tos aizvietos ar burtiem
            Console.WriteLine($"Find out which word is behind: {hiddenWordString}");
            int missesCount = 0;//skaita cik ir nepareizi uzminēto burtu
            string missedLetter;//strings, kurā ir nepareizi uzminēti burti
            while (missesCount < 7) //apstājas, kad ir vairāk par 7 nepareizi atminētiem burtiem vai kad ir uzminēts viss vārds
            {
                Console.WriteLine("Which letter is in this word? (Enter only one)");
                char guessedLetter = Char.Parse(Console.ReadLine());
                while (true) //pārbauda vai ievadītais simbols ir burts
                {
                    if (Char.IsLetter(guessedLetter) == true)
                    {
                        break;
                    }
                    else// ja simbiols nav burts, liek par jaunu ievadīt burtu
                    {
                        Console.WriteLine("You did not enter not a valid letter!");
                        Console.WriteLine("Enter a letter!");
                        guessedLetter =Char.Parse(Console.ReadLine()); //ievadīto burtu pārvērš uz char
                    }
                        
                }
                int indexOfHiddenLetter = -1;
                if (hiddenWordString.Contains("_"))
                {
              
                    for (int l = 0; l < hiddenWord.Length; l++)//iziet cauri visiem burtiem vārda
                    {
                        if (hiddenWord[l] == guessedLetter) // ja paslēptais vārds pie indexa l satur doto burtu
                        {
                            indexOfHiddenLetter = l; //index, pie kura  mums vajag aizvietot hiddenWordString[l] ar uzminēto burtu
                            var hiddenWordArray = hiddenWordString.ToCharArray();//nevari string pieklūt simbolam pa taisno ar indexu.
                            hiddenWordArray[l] = guessedLetter;//pie l indexa aizvieto _ ar minēto burtu
                            hiddenWordString = new string(hiddenWordArray); //pārvērst uz simbolu masīvu visu vārdu.. aizstāt attiecīgo _ ar burtu un ielikt rezultātu atpakaļ mainīgajā
                            Console.WriteLine(hiddenWordString);//izprintē hiddenWordString, kur _ ir aizvietots ar burtu
                        }
                        if (hiddenWord[l] != guessedLetter)
                        {
                            missedLetter = guessedLetter.ToString();// minēto burtu pievieno  missedLetter stringam
                            Console.WriteLine($"Missed letters: {missedLetter}");// Iprintē visus nepareizi ievadītos burtus
                            missesCount++;//pieskaita nepareizi ievadīto burtu counterim
                        }
                    }
                    
                    
                }
                else
                {
                    Console.WriteLine("You you have found all letters, congratulations!");
                    break; //ja hiddenWordString visi _ ir aizvietoti ar burtiem, vajag beigt spēli
                }
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine($"Word: {hiddenWordString}");
                Console.WriteLine($"Misses: {missesCount}");
                Console.WriteLine($"Guess: {guessedLetter}");
            }
            Console.WriteLine("Sorry, but you have lost!"); // ir vairāk par 7 nepareizi atminētiem burtiem

        }
        
    }
}
