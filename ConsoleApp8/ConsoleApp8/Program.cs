﻿using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            overloading instance = new overloading();

            instance.test(5);
            instance.test(5.5f);
            instance.test("TEST");

        }
    }
    class overloading
    {
        public void test(string name)
        {
            Console.WriteLine(name);
        }
        public void test(int name)
        {
            Console.WriteLine(name);
        }
        public void test(float name)
        {
            Console.WriteLine(name);
        }
    }
}
