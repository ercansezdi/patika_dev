using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen 5 sayı içerinden hangilerini\n asal sayi olduğunu bulan Program");

            int[] numbers = new int[5];

            for(int i = 0; i < 5; i++)
            {
                Console.Write("{0}. sayiyi giriniz : ", i + 1);
                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            
            foreach(var num in numbers)
            {
                for (int i = (num+1)/2; i > 1; i--)
                {
                    if (num % i == 0)
                    { 
                        Console.WriteLine("{0} Asal sayi değildir.", num);
                        break;
                    }
                    if(i == 2)
                        Console.WriteLine("{0} Asal sayidir.", num);


                }
            }
        }
    }
}
