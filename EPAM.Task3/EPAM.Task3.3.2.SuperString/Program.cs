using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task3._3._2.SuperString
{
    class Program
    {
        public static void Main(string[] args)
        {
            string testString = Console.ReadLine();

            Console.WriteLine(StringExtension.LanguageDetermination(testString));
        }
    }
}
