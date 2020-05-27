using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task1._1._7.ArrayProcessing
{
    class Program
    {
        public static void ArrayFill(ref int[] array)
        {
            Random RandomGenerator = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RandomGenerator.Next(-500, 500);
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

        public static void SwapElements(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        public static void ArrayQuickSort(ref int[] array, ref int leftElement, ref int rightElement)
        {
            if (leftElement >= rightElement)
                return;
            if (leftElement + 1 == rightElement)
            {
                if (array[leftElement] > array[rightElement])
                    SwapElements(ref array[leftElement], ref array[rightElement]);
                return;
            }

            int pivot = array[(leftElement + rightElement) / 2];
            int leftCursor = leftElement, rightCursor = rightElement;

            while (leftCursor <= rightCursor)
            {
                while (array[leftCursor] < pivot)
                    leftCursor++;
                while (array[rightCursor] > pivot)
                    rightCursor--;

                if (leftCursor <= rightCursor)
                {
                    SwapElements(ref array[leftCursor], ref array[rightCursor]);
                    leftCursor++;
                    rightCursor--;
                }
            }
            ArrayQuickSort(ref array, ref leftElement, ref rightCursor);
            ArrayQuickSort(ref array, ref leftCursor, ref rightElement);
        }

        static void Main(string[] args)
        {
            int[] array = new int[20];

            ArrayFill(ref array);

            Console.WriteLine("Initial array: ");
            ArrayPrint(array);

            int q = 0, w = array.Length - 1;

            ArrayQuickSort(ref array, ref q, ref w);

            Console.WriteLine("Sorted array: ");
            ArrayPrint(array);

            Console.WriteLine($"Max element of array: {array[array.Length - 1]}{Environment.NewLine}" +
                $"Min element of array: {array[0]}");
        }
    }
}
