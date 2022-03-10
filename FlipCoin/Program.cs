using System;

namespace FlipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Flip Coin Problem\n");
            int TotalFlip = TakeInput();
            int TotalHead = CoinCheck(TotalFlip);
            int TotalTail = TotalFlip - TotalHead;
            Console.WriteLine("\nH: " + TotalHead + " T: " + TotalTail);
        }

        public static int TakeInput()
        {
            Console.Write("Enter how many times to Flip: ");
            string Num = Console.ReadLine();
            return Convert.ToInt32(Num);
        }

        public static int CoinCheck(int TotalFlip)
        {
            Random random = new Random();
            int HeadNum = 0;
            while (TotalFlip > 0)
            {
                int CoinFlip = random.Next(0, 2);
                if (CoinFlip == 0)
                    HeadNum++;
                TotalFlip--;
            }
            return HeadNum;
        }
    }
}
