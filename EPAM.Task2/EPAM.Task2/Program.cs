using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringstr1;
            Console.Write($"Welcome to MyString Test Application{Environment.NewLine}Enter string line: ");
            stringstr1 = Console.ReadLine();
            MyString mystr1 = new MyString(stringstr1);
            Console.WriteLine($"MyString from string line is: {mystr1}{Environment.NewLine}It's length is {mystr1.Length}{Environment.NewLine}");

            Console.Write("Enter another two MyString lines to compare them. First one: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Second one: ");
            MyString mystr2 = new MyString(Console.ReadLine());
            switch (MyString.Compare(mystr1, mystr2))
            {
                case 1:
                    Console.WriteLine("First one is bigger");
                    break;
                case -1:
                    Console.WriteLine("Second one is bigger");
                    break;
                case 0:
                    Console.WriteLine("They are the same");
                    break;
            }

            Console.WriteLine();

            Console.Write("Enter another two MyString lines to concatenate them. First one: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Second one: ");
            mystr2 = new MyString(Console.ReadLine());
            Console.WriteLine($"The concatenation is: {MyString.Concat(mystr1, mystr2)}");
            Console.WriteLine();

            Console.Write("Enter another two MyString lines to find out, if they are equal. First one: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Second one: ");
            mystr2 = new MyString(Console.ReadLine());
            if (mystr1.Equals(mystr2))
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are not equal");
            }

            Console.WriteLine();

            Console.Write("Enter another two MyString lines to find if the first contains second. First one: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Second one: ");
            mystr2 = new MyString(Console.ReadLine());
            if (mystr1.Contains(mystr2))
            {
                Console.WriteLine("It does");
            }
            else
            {
                Console.WriteLine("It doesn't");
            }

            Console.WriteLine();

            Console.Write("Enter another two MyString lines to find if the first starts with second. First one: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Second one: ");
            mystr2 = new MyString(Console.ReadLine());
            if (mystr1.StartsWith(mystr2))
            {
                Console.WriteLine("It does");
            }
            else
            {
                Console.WriteLine("It doesn't");
            }

            Console.WriteLine();

            Console.Write("Enter another two MyString lines to find if the first ends with second. First one: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Second one: ");
            mystr2 = new MyString(Console.ReadLine());
            if (mystr1.EndsWith(mystr2))
            {
                Console.WriteLine("It does");
            }
            else
            {
                Console.WriteLine("It doesn't");
            }

            Console.WriteLine();

            Console.Write("Enter MyString to find the index of a sybmbol. MyString: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Sybmbol: ");
            char symbol = char.Parse(Console.ReadLine());
            if (mystr1.IndexOf(symbol) == -1)
            {
                Console.WriteLine("There is no such symbol");
            }
            else
            {
                Console.WriteLine(mystr1.IndexOf(symbol));
            }

            Console.WriteLine();

            Console.Write("Enter MyString to find the last index of a sybmbol. MyString: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Sybmbol: ");
            symbol = char.Parse(Console.ReadLine());
            if (mystr1.LastIndexOf(symbol) == -1)
            {
                Console.WriteLine("There is no such symbol");
            }
            else
            {
                Console.WriteLine(mystr1.LastIndexOf(symbol));
            }

            Console.WriteLine();

            Console.Write("Enter MyString to find the first index of any symbol in char array. MyString: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Sybmbols: ");
            char[] symbols = Console.ReadLine().ToCharArray();
            if (mystr1.IndexOfAny(symbols) == -1)
            {
                Console.WriteLine("There is no such symbols");
            }
            else
            {
                Console.WriteLine(mystr1.IndexOfAny(symbols));
            }

            Console.WriteLine();

            Console.Write("Enter MyString to find the last index of any symbol in char array. MyString: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Sybmbols: ");
            symbols = Console.ReadLine().ToCharArray();
            if (mystr1.LastIndexOfAny(symbols) == -1)
            {
                Console.WriteLine("There is no such symbols");
            }
            else
            {
                Console.WriteLine(mystr1.LastIndexOfAny(symbols));
            }

            Console.WriteLine();

            Console.Write("Enter MyString to make it to upper: ");
            mystr1 = new MyString(Console.ReadLine());
            mystr1.ToUpper();
            Console.WriteLine($"The result is: {mystr1}");
            Console.WriteLine();

            Console.Write("Enter MyString to make it to lower: ");
            mystr1 = new MyString(Console.ReadLine());
            mystr1.ToLower();
            Console.WriteLine($"The result is: {mystr1}");
            Console.WriteLine();

            Console.Write("Enter another two MyString lines and position to insert second in the first. First one: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Second one: ");
            mystr2 = new MyString(Console.ReadLine());
            Console.Write("Position: ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine($"The result is: {mystr1.Insert(position, mystr2)}");
            Console.WriteLine();

            Console.Write("Enter another MyString line and start and end positions to remove elements. MyString: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Start: ");
            position = int.Parse(Console.ReadLine());
            Console.Write("End: ");
            int position1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The result is: {mystr1.Remove(position, position1)}");
            Console.WriteLine();

            Console.Write("Enter another MyString line and start and end positions to generate SubMyString. MyString: ");
            mystr1 = new MyString(Console.ReadLine());
            Console.Write("Start: ");
            position = int.Parse(Console.ReadLine());
            Console.Write("End: ");
            position1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The result is: {mystr1.SubMyString(position, position1)}");
            Console.WriteLine();
        }
    }
}
