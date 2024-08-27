class Program
{
    static private void Main(string[] args)
    {
        var productsList = new ProductList("Banana",1.1,13);

        productsList.AddProduct("Logitech mouse", 70.00, 14); 
        productsList.AddProduct("iPhone 5s", 999.99, 3); 
        productsList.AddProduct("Epson EB-U05", 440.46, 1); 

        productsList.PrintProducts();

        bool quit = false;
        
        while(!quit)
        {
            productsList.ChangeProductInfo();

            Console.WriteLine();
            Console.WriteLine("Please 'Q' key to quit!");
            Console.WriteLine("Please press any key to continue!");
            
            if(Console.ReadKey(true).Key.ToString() == "Q")
            {
                quit = true;
            } 

            else
            {
                Console.Clear();
            }

            if(quit)
            {
                Console.Clear();
                Console.WriteLine("Goodbye! :)");
                Console.Clear();
            }
        }
        
    }
}
