using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i<= 100; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i.ToString() + ": Odd");
                else
                    Console.WriteLine(i.ToString() + ": Even");
            }
        }
    }
}
