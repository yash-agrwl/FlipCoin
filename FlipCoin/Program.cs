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
            DisplayResult(TotalHead, TotalFlip);
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

        public static void DisplayResult(int TotalHead,int TotalFlip)
        {
            int TotalTail = TotalFlip - TotalHead;
            Console.WriteLine("\nTotal number of Heads is: " + TotalHead + " and Tails is: " + TotalTail);
            float HeadPercent = ( (float)TotalHead / TotalFlip ) * 100;
            float TailPercent = ( (float)TotalTail / TotalFlip ) * 100;
            Console.WriteLine("\nThus, the reqd percentage of Heads is: " + HeadPercent + "% and Tails is: " + TailPercent + "%");
        }
    }
}
