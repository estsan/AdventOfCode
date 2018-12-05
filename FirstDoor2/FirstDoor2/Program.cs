using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FirstDoor2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = File.ReadAllLines("TextFile1.txt");
            int frequency = 0;
            List<int> frequencyList = new List<int> { };
            bool forts = true;
            int i = 0;
            while (forts)
            {
                if (numbers[i].Substring(0,1) == "+")
                {
                    frequency += int.Parse(numbers[i].Substring(1));
                }
                else
                {
                    frequency -= int.Parse(numbers[i].Substring(1));
                }
                frequencyList.Add(frequency);
                for (int j = 0; j < frequencyList.Count() - 1; j++)
                {
                    if (frequency == frequencyList[j])
                    {
                        forts = false;
                    }
                }
                i++;
                if (i >= numbers.Length)
                {
                    i = 0;
                }
            }
            Console.WriteLine(frequency);
            Console.ReadKey();
        }
    }
}
