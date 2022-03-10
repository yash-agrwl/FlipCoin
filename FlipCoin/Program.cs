using System;

namespace FlipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Flip Coin Problem\n");
            int TotalFlip = TakeInput();
            Console.WriteLine("\nNumber of times to Flip is: " + TotalFlip);
        }

        public static int TakeInput()
        {
            Console.Write("Enter how many times to Flip: ");
            string Num = Console.ReadLine();
            return Convert.ToInt32(Num);
        }
    }
}
