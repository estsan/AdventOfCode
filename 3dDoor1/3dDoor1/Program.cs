﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3dDoor1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fabricIDs = File.ReadAllLines("TextFile.txt");
            int n = fabricIDs.Count();
            int[,] fabricPosition = new int[n, 5];

            int i = 0;
            foreach (string s in fabricIDs)
            {
                string[] temp = s.Split('#', '@', ',', ':', 'x');
                fabricPosition[i, 0] = int.Parse(temp[1].Trim());
                fabricPosition[i, 1] = int.Parse(temp[2].Trim());
                fabricPosition[i, 2] = int.Parse(temp[3].Trim());
                fabricPosition[i, 3] = int.Parse(temp[4].Trim());
                fabricPosition[i, 4] = int.Parse(temp[5].Trim());
                i++;
            }

            int[,] fabricMesh = new int[1000, 1000];

            for (int j = 0; j < n; j++) // Every ID
            {
                int rowStartSwat = fabricPosition[j, 2];
                int rowEndSwat = rowStartSwat + fabricPosition[j, 4];
                int colStartSwat = fabricPosition[j, 1];
                int colEndSwat = colStartSwat + fabricPosition[j, 3];
                for (int k = rowStartSwat; k < rowEndSwat; k++) 
                {
                    for (int l = colStartSwat; l < colEndSwat; l++) 
                    {
                        fabricMesh[k, l]++;
                    }
                }
            }
            int overLap = 0;
            foreach (int m in fabricMesh)
            {
                if (m > 1)
                {
                    overLap++;
                }
            }
        }
    }
}
