using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = string.Empty;
            while (product != "exit")
            {
                Console.WriteLine(@"Enter a product:
Keyboard = 0,
        Mouse = 1,
        Mic = 2,
        Speaker = 3");
                product = Console.ReadLine();
            }
        }
    }
}
