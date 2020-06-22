using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2._1._2.CustomPaint
{
    public class Line : Figure
    {
        private Point a = new Point();
        private Point b = new Point();

        public Line()
        {
        }

        public Line(int x1, int y1, int x2, int y2)
        {
            this.a.X = x1;
            this.b.X = x2;
            this.a.Y = y1;
            this.b.Y = y2;
        }

        public override void DrawFigure()
        {
            Console.WriteLine($"Line (A,B). A = ({this.a.X}, {this.a.Y}), B = ({this.b.X}, {this.b.Y})");
        }
    }
}
