using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task1._1._6.FontAdjustment
{
    class Program
    {
        [Flags]
        public enum FontAdjustment : byte
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4
        }

        public static void Main(string[] args)
        {
            FontAdjustment f = 0;
            int flag = 0;

            while (true)
            {
                Console.WriteLine($"Параметры надписи: {f} {Environment.NewLine}" +
                    $"Введите: {Environment.NewLine} " +
                    $"        1: bold {Environment.NewLine} " +
                    $"        2: italic {Environment.NewLine} " +
                    $"        3: underline");

                flag = int.Parse(Console.ReadLine());

                switch (flag)
                {
                    case 1:
                        f ^= FontAdjustment.Bold;
                        break;
                    case 2:
                        f ^= FontAdjustment.Italic;
                        break;
                    case 3:
                        f ^= FontAdjustment.Underline;
                        break;
                }
            }
        }
    }
}
