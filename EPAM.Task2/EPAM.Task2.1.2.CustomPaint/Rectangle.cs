using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2._1._2.CustomPaint
{
    public class Rectangle : Figure
    {
        private Point a = new Point();
        private Point b = new Point();
        private Point c = new Point();
        private Point d = new Point();

        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            double diag1 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double diag2 = Math.Sqrt(Math.Pow(x4 - x2, 2) + Math.Pow(y4 - y2, 2));
            Console.WriteLine($"-----{diag1}----{diag2}----");
            if (diag1 == diag2)
            {
                this.a.X = x1;
                this.b.X = x2;
                this.a.Y = y1;
                this.b.Y = y2;
                this.c.X = x3;
                this.d.X = x4;
                this.c.Y = y3;
                this.d.Y = y4;
            }
            else
            {
                throw new Exception();
            }
        }

        public override void DrawFigure()
        {
            Console.WriteLine($"Rectangle (A,B). A = ({this.a.X}, {this.a.Y}), B = ({this.b.X}, {this.b.Y}), C = ({this.c.X}, {this.c.Y}), D = ({this.d.X}, {this.d.Y})");
        }
    }
}
