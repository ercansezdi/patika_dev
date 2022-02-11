using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan test = new Calisan();
            test.Ad = "Ercan";
            test.Soyad = "Sezdi";
            test.No = 160845;
            test.Depertman = "EEE";
            Console.WriteLine("1");
            test.CalisanBilgileri();
            Calisan test2 = new Calisan("Feyza","ECE");
            Console.WriteLine("2");
            test2.CalisanBilgileri();

            Calisan test3 = new Calisan("Ahmet");
            Console.WriteLine("3");
            test3.CalisanBilgileri();

            Calisan test4 = new Calisan();
            Console.WriteLine("4");
            test4.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Depertman;

        public Calisan() { }

        public Calisan(string isim)
        {
            this.Ad = isim;
        }
        public Calisan(string ad, string departman) {
            this.Ad = ad;
            this.Depertman = departman;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : {0}", Ad);
            Console.WriteLine("Çalışan Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışan Numarası : {0}", No);
            Console.WriteLine("Çalışan Depermanı : {0}", Depertman);
        }

    }
}
