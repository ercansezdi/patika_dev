using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> vowels = new List<char>();
            vowels.Add('a');
            vowels.Add('e');
            vowels.Add('i');
            vowels.Add('o');
            vowels.Add('u');
            vowels.Add('a');


            string cumle;
            Console.Write("Cümle giriniz :");
            cumle = Console.ReadLine().ToLower();
            int counter = 0;
            foreach(var i in cumle)
            {
                if (vowels.Contains(i))
                    counter += 1;

            }
            char[] array = new char[counter];
            counter = 0;
            foreach(var i in cumle)
            {
                if (vowels.Contains(i))
                {
                    array[counter] = i;
                    counter += 1;
                }

            }
            Array.Sort(array);
            Console.WriteLine("Sesli harfler: ");
            foreach (var i in array)
            {
                Console.Write(i.ToString() + " ");
            }





        }
    }
}
