using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            math_islemler ornek = new math_islemler();
            int num1 = 5, result;
            result = ornek.pow(num1,3);

            ornek.show(Convert.ToString(result));

        }
    }
    class math_islemler
    {
        public int pow(int value,int exponentiation)
        {
            int counter = 0, result = 1;
            while(counter < exponentiation)
            {
                result *= value;
                counter += 1;
            }
            return result;
        }
        public void show(string value)
        {
            Console.WriteLine(value);
        }

    }
}
