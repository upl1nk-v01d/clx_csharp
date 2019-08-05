using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            String stringType = "String";
            int otherType = 5;
            String example = "A " + stringType
                    + " can be concatenated with other types also "
                    + otherType;
            Console.WriteLine(example);
            Console.ReadKey();
        }
    }
}
