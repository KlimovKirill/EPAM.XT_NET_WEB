using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task1._2._3.Lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfSmallLetterWords = 0;

            Console.WriteLine("Enter string: ");
            string inputString = Console.ReadLine();

            var arrayOfWords = inputString.Split(new char[] { ' ', ',', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                if (Char.IsLower(arrayOfWords[i][0]))
                {
                    countOfSmallLetterWords++;
                }
            }

            Console.WriteLine($"Count of small letter words: {countOfSmallLetterWords}");
        }
    }
}
