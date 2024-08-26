using System.Reflection;

class Product
{
    public string Name { get; set; }

    public double PriceAtStart { get; set; }

    public int AmountAtStart { get; set; }
}

class ProductList
{
    public List<object> products = new List<object>();

    public void AddProduct(string name, double priceAtStart, int amountAtStart)
    {
        products.Add( new { Name = name, PriceAtStart = priceAtStart, AmountAtStart = amountAtStart });
    }

    public void ChangeProductInfo()
    { 
        int i = 0;
        int detected = -1;
        
        Console.WriteLine("Please enter a product name to change: ");
        string searchName = Console.ReadLine()!;

        foreach(object o in products)
        {
            if(o.GetType().GetProperty("Name").GetValue(o).ToString() == searchName)
            {
                detected = i;
            }

            i++;
        }

        if (detected != -1)
        {
            Console.Clear();

            var propName = products[detected].GetType().GetProperty("Name").GetValue(products[detected]).ToString();
            
            Console.WriteLine($"old Name value: {propName}");
            Console.WriteLine("Leave blank and press 'Enter' key if you want to discard changes");
            Console.WriteLine("Please enter new value of Name: ");
            string promptPropName = Console.ReadLine();
            Console.Clear();
            
            var propPriceAtStart = products[detected].GetType().GetProperty("PriceAtStart").GetValue(products[detected]).ToString();
            
            Console.WriteLine($"old PriceAtStart value: {propPriceAtStart}");
            Console.WriteLine("Leave blank and press 'Enter' key if you want to discard changes");
            Console.WriteLine("Please enter new value of Name: ");
            string promptPriceAtStart = Console.ReadLine();
            Console.Clear();

            var propAmountAtStart = products[detected].GetType().GetProperty("AmountAtStart").GetValue(products[detected]).ToString();
            
            Console.WriteLine($"old AmountAtStart value: {propAmountAtStart}");
            Console.WriteLine("Leave blank and press 'Enter' key if you want to discard changes");
            Console.WriteLine("Please enter new value of Name: ");
            string promptAmountAtStart = Console.ReadLine();
            Console.Clear();

            if(promptPropName != "")
            {
                propName = promptPropName;
            }

            if(promptPriceAtStart != "")
            {
                propPriceAtStart = promptPriceAtStart;
            }

            if(promptAmountAtStart != "")
            {
                propAmountAtStart = promptAmountAtStart;
            }
                
            var product = new Product() 
            {
                Name = propName,
                PriceAtStart = double.Parse(propPriceAtStart),
                AmountAtStart = int.Parse(propAmountAtStart),
            };

            products[detected] = product;

            this.PrintProducts();
        }

        else
        {
            Console.Clear();
            Console.WriteLine($"product with name {searchName} is not found!");
        }
    }

    public void PrintProducts()
    {
        int i = 0;

        Console.WriteLine();
        Console.WriteLine("Printing list of products:\n");

        foreach (object o in products)
        {
            foreach (PropertyInfo p in products[i].GetType().GetProperties())
            {
                Console.Write(p.Name + ": ");
                Console.WriteLine(p.GetValue(products[i])); 
            }
     
            Console.WriteLine();

            i++;
        }
    }

    public ProductList(string name, double priceAtStart, int amountAtStart)
    {
        AddProduct(name, priceAtStart, amountAtStart);
    }
}