using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = string.Empty;
            while(product != "exit")
            {
                Console.WriteLine(@"Enter a product:");
                product = Console.ReadLine();
            }
        }
    }
}
