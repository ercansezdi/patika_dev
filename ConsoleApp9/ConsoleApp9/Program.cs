using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 4, 3 };

            Convert.ToString(test[0]).Show();
            int ans = test.powAl();
            Convert.ToString(ans).Show();

        }
    }
    public static class Extansion
    {
        public static int powAl(this int[] nums)
        {
            return nums[0] * nums[1];
        }
        public static void Show(this string value)
        {
            Console.WriteLine(value);
        }
    }

}
