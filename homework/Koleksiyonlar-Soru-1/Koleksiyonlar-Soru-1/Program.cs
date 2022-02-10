using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20,counter = 0,input_;
            Double ort;
            ArrayList list = new ArrayList();
            ArrayList poz = new ArrayList();
            ArrayList neg = new ArrayList();

            while( counter< size)
            {
                try
                {
                    Console.WriteLine("{0}. pozitif eleman giriniz :", counter + 1);
                    input_ = Convert.ToInt32(Console.ReadLine());


                    while (input_ < 0)
                    {
                        Console.WriteLine("Pozitif deger giriniz ! ");
                        Console.WriteLine("{0}. pozitif eleman giriniz :", counter + 1);
                        list[counter] = Console.ReadLine();
                    }
                    if(Program.asal(input_))
                        poz.Add(input_);
                    else
                        neg.Add(input_);
                    counter += 1;
                }
                catch
                {
                    Console.WriteLine("Pozitif Sayı giriniz ! ");
                }
            }
            poz.Sort();
            poz.Reverse();
            neg.Sort();
            neg.Reverse();
            Console.WriteLine("-----------");
            Console.WriteLine("Asal  Sayilar :");
            counter = 0;
            foreach(var i in poz)
            {
                counter += Convert.ToInt32(i);
                Console.Write(i.ToString() + " ");

            }
            ort = Convert.ToDouble(counter) / Convert.ToDouble(poz.Count);
            Console.WriteLine("\nEleman Sayisi :{0} Ortalaması :{1}", poz.Count.ToString(), (ort).ToString());
            Console.WriteLine("-----------");
            Console.WriteLine("Asal Olmayan Sayilar :");
            counter = 0;
            foreach (var i in neg)
            {
                counter += Convert.ToInt32(i);
                Console.Write(i.ToString() + " ");

            }
            ort = Convert.ToDouble(counter) / Convert.ToDouble(neg.Count);
            Console.WriteLine("\nEleman Sayisi :{0} Ortalaması :{1}", neg.Count.ToString(), (ort).ToString());




        }
        private static bool asal(int value)
        {
            for(int half = Convert.ToInt32(value / 2) +1; half > 1; half--)
            {
                if (value % half == 0)
                    return false;
            }
            return true;
        }
    }
}
