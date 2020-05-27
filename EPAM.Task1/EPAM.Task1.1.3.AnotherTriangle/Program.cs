using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task1._1._3.AnotherTriangle
{
    class Program
    {
        public static void PaintingOfRectangle(int numberOfSpaces, int numberOfStars)
        {
            for (int i = 0; i < numberOfSpaces; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < numberOfStars; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PaintingOfRectangle(n - i, i * 2 - 1);
            }
        }
    }
}
