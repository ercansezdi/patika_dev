using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            q1();
            q2();
            q3();
            q4();

        }
        static void q1()
        {
            int inputNum;
            Console.Write("Pozitif sayi giriniz : ");
            inputNum = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[inputNum];

            int counter = 0;
            Console.WriteLine("");
            while (counter < inputNum)
            {
                Console.Write("{0}. pozitif sayi  : ", counter + 1);
                array[counter] = Convert.ToInt32(Console.ReadLine());
                counter += 1;
            }
            Console.Write("Çift sayilar : ");
            foreach (var num in array)
            {
                if (num % 2 == 0)
                    Console.Write(num.ToString() + " ");
            }
            Console.Write("\nTek sayilar : ");
            foreach (var num in array)
            {
                if (num % 2 == 1)
                    Console.Write(num.ToString() + " ");
            }
        }
        static void q2()
        {
            int[] inputNum = new int[2];
            Console.Write("Pozitif sayi giriniz : ");
            inputNum[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pozitif sayi giriniz : ");
            inputNum[1] = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[inputNum[0]];
            int counter = 0;
            Console.WriteLine("");
            while (counter < inputNum[0])
            {
                Console.Write("{0}. pozitif sayi  : ", counter + 1);
                array[counter] = Convert.ToInt32(Console.ReadLine());
                counter += 1;
            }
            Console.Write("{0} sayısına tam bölünen sayılar : ", inputNum[1]);
            foreach (var num in array)
            {
                if (num % inputNum[1] == 0)
                    Console.Write(num.ToString() + " ");
            }
        }
        static void q3()
        {
            int inputNum;
            Console.Write("Pozitif sayi giriniz : ");
            inputNum = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[inputNum];

            int counter = 0;
            Console.WriteLine("");
            while (counter < inputNum)
            {
                Console.Write("{0}. kelime  : ", counter + 1);
                array[counter] = Console.ReadLine();
                counter += 1;
            }
            inputNum -= 1;
            while(inputNum > -1)
            {
                Console.Write(array[inputNum] + " ");
                inputNum -= 1;
            }
        }

        static void q4()
        {
            string sentence;
            Console.Write("Cümle girin : ");
            sentence = Console.ReadLine();

            int[] size = { 0, 0 };

            foreach(var letter in sentence)
            {
                if (letter == ' ')
                    size[0] += 1;
                else
                    size[1] += 1;
            }

            Console.WriteLine("{0} Kelime, {1} harf var.", size[0]+1, size[1]);

        }
    }
}
