using System.Reflection;

class Product
{
    private string Name { get; set; }

    private double PriceAtStart { get; set; }

    private int AmountAtStart { get; set; }

    public Product(string name, double priceAtStart, int amountAtStart)
    {
         Name = name;
         PriceAtStart = priceAtStart;
         AmountAtStart = amountAtStart;
    }

    public object GetProductName()
    {
        return this.Name;
    }

    public object GetProductPrice()
    {
        return this.PriceAtStart;
    }

    public object GetProductAmount()
    {
        return this.AmountAtStart;
    }
}

class ProductList
{
    private List<Product> products = new List<Product>();

    public void AddProduct(string name, double priceAtStart, int amountAtStart)
    {
        products.Add(new Product(name, priceAtStart, amountAtStart));
    }

    public void ChangeProductInfo()
    { 
        int i = 0;
        int detected = -1;
        
        Console.WriteLine("Please enter a product name to change: ");
        string searchName = Console.ReadLine()!;

        foreach(Product product in products)
        {
            if(product.GetProductName().ToString().ToLower() == searchName.ToLower())
            {
                detected = i;
            }

            i++;
        }

        if (detected != -1)
        {
            Console.Clear();

            var propName = products[detected].GetProductName();
            
            Console.WriteLine($"old Name value: {propName}");
            Console.WriteLine("Leave blank and press 'Enter' key if you want to discard changes");
            Console.WriteLine("Please enter new value of Name: ");

            string promptPropName = Console.ReadLine();
            Console.Clear();
            
            var propPriceAtStart = products[detected].GetProductPrice();
            
            Console.WriteLine($"old PriceAtStart value: {propPriceAtStart}");
            Console.WriteLine("Leave blank and press 'Enter' key if you want to discard changes");
            Console.WriteLine("Please enter new value of Name: ");

            string promptPriceAtStart = Console.ReadLine();
            Console.Clear();

            var propAmountAtStart = products[detected].GetProductAmount();
            
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
                
            var product = new Product(propName.ToString(), double.Parse(propPriceAtStart.ToString()), 
            int.Parse(propAmountAtStart.ToString()));

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

        foreach (Product product in products)
        {
            Console.WriteLine("Name: " + product.GetProductName());
            Console.WriteLine("Price: " + product.GetProductPrice());
            Console.WriteLine("Amount: " + product.GetProductAmount());
            Console.WriteLine();
     
            i++;
        }
    }

    public ProductList(string name, double priceAtStart, int amountAtStart)
    {
        AddProduct(name, priceAtStart, amountAtStart);
    }
}