using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20, counter = 0;
            double ort = 0f;

            int[] array = new int[size];
            while (counter < size)
            {
                Console.WriteLine("{0}. sayiyi giriniz : ", counter + 1);
                array[counter] = Convert.ToInt32(Console.ReadLine());
                counter += 1;
            }
            Array.Sort(array);

            Console.WriteLine("------------\nEn küçük 3 sayi:");
            counter = 0;
            while (counter < 3)
            {
                Console.Write(array[counter].ToString() + " ");
                ort += Convert.ToDouble(array[counter]);
                counter += 1;

            }
            Console.WriteLine("\nOrtlaması : {0}", (ort / 3f).ToString());
            Console.WriteLine("------------\nEn büyük 3 sayi:");
            counter = array.Length -1 ;
            ort = 0f;
            while (counter > array.Length -4)
            {
                Console.Write(array[counter].ToString() + " ");
                ort += Convert.ToDouble(array[counter]);
                counter -= 1;

            }
            Console.WriteLine("\nOrtlaması : {0}", (ort / 3f).ToString());

        }
    }
}
