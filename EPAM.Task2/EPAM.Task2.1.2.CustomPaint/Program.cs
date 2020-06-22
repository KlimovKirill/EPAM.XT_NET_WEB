using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2._1._2.CustomPaint
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of figures: ");
            Figure[] figureMassive = new Figure[0];
            int n = 0;
            try
            {
                int.TryParse(Console.ReadLine(), out n);
                if (n < 1)
                {
                    throw new Exception();
                }

                figureMassive = new Figure[n];
            }
            catch
            {
                Console.WriteLine("Error. Wrong number. It must be positive integer");
            }

            Console.WriteLine($"{Environment.NewLine}Enter {n} numbers from 1 to 5. 1 - Line, 2 - Circle, 3 - Rectangle, 4 - Round, 5 - Ring");
            int type = 0;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter figure number: ");
                    int.TryParse(Console.ReadLine(), out type);
                    if (type < 1 || type > 5)
                    {
                        throw new Exception();
                    }

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("Enter one at a time x1, y1, x2, y2: ");
                            int x1, x2, y1, y2;
                            int.TryParse(Console.ReadLine(), out x1);
                            int.TryParse(Console.ReadLine(), out y1);
                            int.TryParse(Console.ReadLine(), out x2);
                            int.TryParse(Console.ReadLine(), out y2);
                            Console.WriteLine("____");
                            figureMassive[i] = new Line(x1, y1, x2, y2);
                            break;
                        case 2:
                            Console.WriteLine("Enter one at a time x, y, r: ");
                            int x, y, r;
                            int.TryParse(Console.ReadLine(), out x);
                            int.TryParse(Console.ReadLine(), out y);
                            int.TryParse(Console.ReadLine(), out r);
                            Console.WriteLine("____");
                            figureMassive[i] = new Circle(x, y, r);
                            break;
                        case 3:
                            Console.WriteLine("Enter one at a time x1, y1, x2, y2, x3, y3, x4, y4: ");
                            int x3, x4, y3, y4;
                            int.TryParse(Console.ReadLine(), out x1);
                            int.TryParse(Console.ReadLine(), out y1);
                            int.TryParse(Console.ReadLine(), out x2);
                            int.TryParse(Console.ReadLine(), out y2);
                            int.TryParse(Console.ReadLine(), out x3);
                            int.TryParse(Console.ReadLine(), out y3);
                            int.TryParse(Console.ReadLine(), out x4);
                            int.TryParse(Console.ReadLine(), out y4);
                            Console.WriteLine("____");
                            figureMassive[i] = new Rectangle(x1, y1, x2, y2, x3, y3, x4, y4);
                            break;
                        case 4:
                            Console.WriteLine("Enter one at a time x, y, r: ");
                            int.TryParse(Console.ReadLine(), out x);
                            int.TryParse(Console.ReadLine(), out y);
                            int.TryParse(Console.ReadLine(), out r);
                            Console.WriteLine("____");
                            figureMassive[i] = new Round(x, y, r);
                            break;
                        case 5:
                            Console.WriteLine("Enter one at a time x, y, r, R: ");
                            int r2;
                            int.TryParse(Console.ReadLine(), out x);
                            int.TryParse(Console.ReadLine(), out y);
                            int.TryParse(Console.ReadLine(), out r);
                            int.TryParse(Console.ReadLine(), out r2);
                            Console.WriteLine("____");
                            figureMassive[i] = new Ring(x, y, r, r2);
                            break;
                    }
                }

                Console.WriteLine($"{Environment.NewLine}Drawing..{Environment.NewLine}");
                for (int i = 0; i < figureMassive.Length; i++)
                {
                    figureMassive[i].DrawFigure();
                }
            }
            catch
            {
                Console.WriteLine("     ERROR. Wrong input data. Incorrect input, or incorrect figure.");
            }
        }
    }
}
