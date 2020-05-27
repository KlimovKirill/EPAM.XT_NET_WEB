using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task1._1._8.NoPositive
{
    class Program
    {
        public static void ThreeDArrayFill(ref int[,,] array)
        {
            Random RandomGenerator = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = RandomGenerator.Next(-10, 10);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[,,] array = new int[3, 3, 3];
            ThreeDArrayFill(ref array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
        }
    }
}
