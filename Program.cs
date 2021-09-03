using System;

namespace Timeloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            if (i < 1 || i > 100)
            {
                Console.WriteLine("Must be a number between 1 and 100");
                return;
            }
            for (int x = 1; x < i + 1; x++)
            {
                Console.WriteLine(x + " Abracadabra");
            }
        }
    }
}
