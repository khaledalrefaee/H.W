using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace H.W
{
    internal class CustomArray
    {
        public int[] array;

        public CustomArray(int length)
        {
            array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = i;
            }
        }

        public void Print()
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public void CalculateTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Print();
            
            stopwatch.Stop();
            // هذه ال ميثود ElapsedMilliseconds M.S قامت لي بحساب الوقت 
            Console.WriteLine($"Elapsed Time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
