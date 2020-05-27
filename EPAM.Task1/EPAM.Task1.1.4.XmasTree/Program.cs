using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task1._1._4.XmasTree
{
    class Program
    {
        public static void PaintingOfRectangle(int numberOfTree, int n)
        {
            int numberOfStars = 1;
            int numberOfSpaces = (n - 1) * 2;

            for (int j = 0; j < numberOfTree; j++)
            {
                for (int i = 0; i < numberOfSpaces / 2; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < numberOfStars; i++)
                {
                    Console.Write("*");
                }

                for (int i = 0; i < numberOfSpaces / 2; i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();

                numberOfSpaces -= 2;
                numberOfStars += 2;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PaintingOfRectangle(i, n);
            }
        }
    }
}
