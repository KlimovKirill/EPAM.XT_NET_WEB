using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task1._1._9.NonNegativeSum
{
    class Program
    {
        public static void ArrayFill(ref int[] array)
        {
            Random RandomGenerator = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RandomGenerator.Next(-1000, 1000);
            }
        }

        public static void ArrayPrint(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = new int[20];
            ArrayFill(ref array);

            Console.WriteLine("Initial array: ");
            ArrayPrint(array);

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine($"Non-Negative Sum = {sum}");
        }
    }
}
