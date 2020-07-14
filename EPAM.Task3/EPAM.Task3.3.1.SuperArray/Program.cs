using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EPAM.Task3._3._1.SuperArray.ArrayExtension;

namespace EPAM.Task3._3._1.SuperArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[7] { 1, 5, 3, 4, 5, 2, 20 };

            int[] testArray = ArrayElementsChanger(array, MultiplicationByTwo);

            foreach (var item in testArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine($"Сумма всех элементов массива: {ArrayValuesSearcher(array, SumOfAllArrayElements)}");
            Console.WriteLine($"Среднее значение в массиве: {ArrayValuesSearcher(array, AverageValueOfAllArrayElements)}");
            Console.WriteLine($"Самый часто встречаемый элемент массива: {ArrayValuesSearcher(array, MostFrequentArrayElement)}");
        }
    }
}
