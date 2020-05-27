using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task1._1
{
    class Program
    {
        public static int InputChecking()
        {
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
                while (n < 1 || n % 1 != 0)
                {
                    Console.WriteLine("The number should be positive and integer. Enter a new one: ");
                    n = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Error. You should enter a positive and integer number. Enter a new one: ");
                n = InputChecking();
            }
            return n;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the side A of rectangle: ");
            int a = InputChecking();

            Console.WriteLine("Enter the side B of rectangle: ");
            int b = InputChecking();

            Console.WriteLine($"The area of the rectangle is equal to {a * b}");
        }
    }
}
