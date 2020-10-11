using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarraydemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedarray = new int[3][];//intializing the values to jagged array
            jaggedarray[0] = new int[3] { 1, 2, 3 };
            jaggedarray[1] = new int[5] { 2, 3, 4, 5, 6 };
            jaggedarray[2] = new int[4] { 6, 5, 9, 4 };
            for (int i = 0; i < jaggedarray.Length; i++)
            {
                Console.WriteLine("elements of{0} are", i);

                for (int j = 0; j < jaggedarray[i].Length; j++)
                {
                    Console.WriteLine(jaggedarray[i][j]);
                }

                Console.ReadLine();
            }
        }
    }
}
