using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task3._3._1.SuperArray
{
    public static class ArrayExtension
    {
        public delegate int ElementsChanging(int element);
        public delegate int ValuesSearching(int[] array);

        public static int[] ArrayElementsChanger(int[] array, ElementsChanging elementsChanging)
        {
            int[] changedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                changedArray[i] = elementsChanging.Invoke(array[i]);
            }

            return changedArray;
        }

        public static int MultiplicationByTwo(int n)
        {

            return n * 2;
        }

        public static int Squaring(int n)
        {

            return n * n;
        }

        public static int ArrayValuesSearcher(int[] array, ValuesSearching valuesSearching)
        {

            return valuesSearching.Invoke(array);
        }

        public static int SumOfAllArrayElements(int[] array)
        {

            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }

            return sum;
        }

        public static int AverageValueOfAllArrayElements(int[] array)
        {
            return SumOfAllArrayElements(array) / array.Length;
        }

        public static int MostFrequentArrayElement(int[] array)
        {
            int maxCount = 1;
            int elementPosition = -1;
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }

                if (maxCount < count)
                {
                    maxCount = count;
                    elementPosition = i;
                }
            }

            if (elementPosition > -1)
            {
                return array[elementPosition];
            }
            else
            {
                return -1;
            }

        }
    }
}