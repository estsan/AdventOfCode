using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SecondDoor1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] boxIDs = File.ReadAllLines("TextFile.txt");
            int two = 0;
            int three = 0;
            foreach (string s in boxIDs)
            {
                Dictionary<char, int> characterCount = new Dictionary<char, int> { };
                foreach(char c in s)
                {
                    if (characterCount.ContainsKey(c))
                    {
                        characterCount[c]++;
                    }
                    else
                    {
                        characterCount[c] = 1;
                    }
                }
                if (characterCount.ContainsValue(2))
                {
                    two++;
                }
                if (characterCount.ContainsValue(3))
                {
                    three++;
                }
            }
            int checkcount = two * three;
            Console.WriteLine(checkcount);
            Console.ReadKey();
        }
    }
}
