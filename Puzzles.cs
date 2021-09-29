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
        public static List<string> Names()
        {
            List<string> names = new List<string>()
            {
                "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
            };
            Random rand = new Random();

            // List<string> newList = new List<string>();
            for (int i = 0; i < names.Count/2; i++)
            {
                int randomIndex = rand.Next(names.Count);
                string temp = names[randomIndex];
                names[randomIndex] = names[i];
                names[i] = temp;
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Length <= 5)
                {
                    names.RemoveAt(i);
                }
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            return names;
        }
    }
}