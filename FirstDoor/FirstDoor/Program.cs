using System;
using System.IO;

namespace FirstDoor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = File.ReadAllLines("TextFile1.txt");
            int sum = 0;
            foreach(string n in number)
            {
                if (n.Substring(0, 1) == "+")
                {
                    sum += int.Parse(n.Substring(1));
                }
                else
                {
                    sum -= int.Parse(n.Substring(1));
                }
            }
            Console.WriteLine(sum);
        }
    }
}
