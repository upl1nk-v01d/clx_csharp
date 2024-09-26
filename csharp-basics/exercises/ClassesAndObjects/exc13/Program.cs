using System;
using System.Collections.Generic;

class Smoothie
{
    public string[] Ingredients;

    public double Price;

    public Smoothie(string[] ingredients, double price)
    {
        Ingredients = ingredients; 
        Price = price;
    }
    
    public string GetIngredients()
    {
        return String.Join(" ", Ingredients);
    }

    public double GetCost()
    {
        return Price;
    }

    public double GetPrice()
    {
        double price = this.GetCost();
        double calc = price + price * 1.5;

        return calc;
    }

    public string GetName()
    {
        string output = "";
        Array.Sort(this.Ingredients);

        if(this.Ingredients.Length > 1)
        {
            foreach(var item in this.Ingredients)
            {
                output += item + " ";
            }

            output += "Fusion";
        }
        else
        {
            output += this.Ingredients[0] + " Smoothie";
        }

        return output;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Let's create first smoothie!");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);

        var smoothie1 = new Smoothie(new string[] { "Banana" }, 0.5);
        Console.WriteLine ("The smoothie's ingredients are " + smoothie1.GetIngredients());
        Console.WriteLine ("Cost is £" + Convert.ToString(smoothie1.GetCost()));
        Console.WriteLine ("Price is £" + Convert.ToString(smoothie1.GetPrice()));
        Console.WriteLine ("Name of smoothie is " + smoothie1.GetName());
        
        Console.WriteLine("\nAs we can see a smoothie is created!");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);

        Console.Clear();
        Console.WriteLine("Now let's create another one!");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);

        var smoothie2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries"  }, 3.50);
        Console.WriteLine ("The smoothie's ingredients are " + smoothie2.GetIngredients());
        Console.WriteLine ("Cost is £" + Convert.ToString(smoothie2.GetCost()));
        Console.WriteLine ("Price is £" + Convert.ToString(smoothie2.GetPrice()));
        Console.WriteLine ("Name of smoothie is " + smoothie2.GetName());
        
        Console.WriteLine("\nWe created our second smoothie!");
        Console.WriteLine("\nPress any key to quit program...");
        Console.ReadKey(true);
    }
}

