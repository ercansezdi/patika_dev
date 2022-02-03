using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int  int_note = Int32.Parse( Console.ReadLine());
            string note = int_note < 50 ? "FF" : int_note < 60 ? "CC" : int_note < 70 ? "CB" : int_note < 80 ? "BB" : int_note < 90 ? "BA" : int_note < 100 ? "AA" : "Wrong Note";

            Console.WriteLine(note);
        }
    }
}
