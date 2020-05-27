using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task1._2._1.Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string inputString = Console.ReadLine();

            int lengthOfCurrentWord = 0;
            int sumOfLetters = 0;
            int countOfWords = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (char.IsLetterOrDigit(inputString[i]))
                {
                    lengthOfCurrentWord++;
                }

                if (char.IsPunctuation(inputString[i]) || char.IsSeparator(inputString[i]) || i == inputString.Length - 1)
                {
                    sumOfLetters += lengthOfCurrentWord;
                    lengthOfCurrentWord = 0;
                    countOfWords++;
                }
            }

            Console.WriteLine($"The average string length = {sumOfLetters / countOfWords}");
        }
    }
}
