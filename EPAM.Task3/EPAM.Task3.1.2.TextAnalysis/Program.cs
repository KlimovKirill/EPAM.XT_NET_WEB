using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EPAM.Task3._1._2.TextAnalysis
{
    class Program
    {
        public static void WordFounder(string s, ref Dictionary<string, int> wordFreq)
        {
            s.ToLower();
            char[] separators = new char[12] { ' ', '.', ',', ';', ':', '?', '!', '-', '(', ')', '\n', '\r' };
            while (s.Length != 0)
            {
                int i_sep = s.IndexOfAny(separators);
                if (i_sep == -1)
                {
                    i_sep = s.Length;
                }

                if (!wordFreq.ContainsKey(s.Substring(0, i_sep)))
                {
                    if (s.Substring(0, i_sep) != " " && !String.IsNullOrEmpty(s.Substring(0, i_sep)))
                    {
                        wordFreq.Add(s.Substring(0, i_sep), 1);
                    }
                }
                else
                {
                    wordFreq[s.Substring(0, i_sep)]++;
                }

                if (i_sep >= s.Length)
                {
                    i_sep = s.Length - 1;
                }

                s = s.Remove(0, i_sep + 1);
            }
        }

        public static void Main(string[] args)
        {
            Dictionary<string, int> wordFreq = new Dictionary<string, int>();

            Console.WriteLine("Hello! Please, enter the path to your file with text you need to check: ");
            string pathToFile = Console.ReadLine();

            Console.WriteLine(Environment.NewLine);
            
            StreamReader sr = new StreamReader(pathToFile);
            string s = sr.ReadToEnd();
            
            WordFounder(s, ref wordFreq);

            Console.WriteLine("Table of words and their frequencies (in descending order):" + Environment.NewLine);

            var items = from pair in wordFreq
                        orderby pair.Value descending
                        select pair;

            foreach (KeyValuePair<string, int> pair in items)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}
