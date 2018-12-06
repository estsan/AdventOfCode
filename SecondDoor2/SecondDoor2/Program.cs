using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SecondDoor2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] boxIDs = File.ReadAllLines("TextFile.txt");
            foreach (string boxID in boxIDs)
            {
                foreach (string boxIDCompare in boxIDs)
                {
                    int a = 0;
                    int b = 0;
                    if (boxID != boxIDCompare)
                    {
                        for (int k = 0; k < boxID.Length; k++)
                        {
                            if (boxID[k] != boxIDCompare[k])
                            {
                                a++;
                                b = k;
                            }
                        }
                        if (a < 2)
                        {
                            string answer = boxID.Substring(0, b) + boxID.Substring(b + 1);
                            Console.WriteLine(answer);
                            Console.ReadKey();
                            break;
                        }
                    }
                }
            }
        }
    }
}
