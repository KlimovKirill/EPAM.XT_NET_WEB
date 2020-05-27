using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task1._2._2.Doubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first string: ");
            string firstInputString = Console.ReadLine();

            Console.Write("Enter second string: ");
            string secondInputString = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < firstInputString.Length; i++)
            {
                sb.Append(firstInputString[i]);

                if (secondInputString.Contains(firstInputString[i]))
                {
                    sb.Append(firstInputString[i]);
                }
            }

            Console.WriteLine($"Result string: {sb}");
        }
    }
}
