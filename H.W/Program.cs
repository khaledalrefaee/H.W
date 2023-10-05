using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W
{
    internal class Program
    {
        public static void ReverseArray(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length / 2; i++)
            {
                // for قمت بتبديل العناصر بين البداية والنهاية بشكل عكسي باستخدام حلقة
                // و يمكننا باستخدام while ايضا و عن طريق reverse  الموجودة من أصل اللغة
                int temp = arr[i];
                arr[i] = arr[length - 1 - i];
                arr[length - 1 - i] = temp;
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array_7 = { 5, 3, 9, 1, 4 };
            Console.WriteLine("Original Array:");
            PrintArray(array_7);

            ReverseArray(array_7);
            Console.WriteLine("Reversed Array:");
            PrintArray(array_7);



            CustomArray array1 = new CustomArray(10);
            array1.Print();
            array1.CalculateTime();

            CustomArray array2 = new CustomArray(100);
            array2.Print();
            array2.CalculateTime();

            CustomArray array3 = new CustomArray(1000);
            array3.Print();
            array3.CalculateTime();
        
            Console.ReadKey();
        }
    }
}
