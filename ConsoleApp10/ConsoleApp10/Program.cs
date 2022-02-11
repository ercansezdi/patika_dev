using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan test = new Calisan();
            test.Ad = "Ercan";
            test.Soyad = "Sezdi";
            test.No =  160845;
            test.Depertman = "EEE";

            test.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Depertman;



        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : {0}", Ad);
            Console.WriteLine("Çalışan Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışan Numarası : {0}", No);
            Console.WriteLine("Çalışan Depermanı : {0}", Depertman);
        }

    }
}
