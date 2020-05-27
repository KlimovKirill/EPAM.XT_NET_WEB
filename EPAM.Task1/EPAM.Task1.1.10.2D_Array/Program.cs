using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task1._1._10._2D_Array
{
    class Program
    {
        public static void TwoDArrayFill(ref int[,] array)
        {
            Random RandomGenerator = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = RandomGenerator.Next(-10, 10);
                }
            }
        }

        public static void TwoDArrayPrint(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];

            TwoDArrayFill(ref array);

            Console.WriteLine("Initial array: ");
            TwoDArrayPrint(array);

            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }

            Console.WriteLine($"The sum of the elements standing at even places = {sum}");
        }
    }
}
