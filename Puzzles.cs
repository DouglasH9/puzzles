using System;
using System.Collections.Generic;

namespace Puzzles
{
    public static class Problems
    {
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] randArr = new int[10];

            for (int i = 0; i < randArr.Length; i++)
            {
                randArr[i] = rand.Next(5,25);
            }
            return randArr;
        }
        public static double CoinToss()
        {
            Random rand = new Random();
            Console.WriteLine("Tossing a coin!");
            double toss = rand.Next(1,3);
            if (toss == 1)
            {
                Console.Write("It landed on heads!");
                return 1;
            }
            else 
            {
                Console.Write("It landed on tails!");
                return 2;
            }
        }
        public static double TossMultiple(double num)
        {
            double headsCount = 0;
            double tailsCount = 0;
            for (int i = 1; i<= num; i++)
            {
                CoinToss();
                if (CoinToss() == 1)
                {
                    headsCount++;
                }
                else
                {
                    tailsCount++;
                }
            }
            double headsRatio = headsCount/num;
            Console.WriteLine(headsRatio);
            return headsRatio;
        }
        public static List Names(aList)
        {
            Random rand = new Random();
            List<string> newList = new List<string>();
            foreach (string item in aList)
            {
                newList.Insert(rand.next(1,6), item);
            }
            return newList;
        }
    }
}