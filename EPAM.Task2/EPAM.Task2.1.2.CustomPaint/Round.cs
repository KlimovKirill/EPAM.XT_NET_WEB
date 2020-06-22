using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2._1._2.CustomPaint
{
    public class Round : Circle
    {
        public Round(int x, int y, int r)
        {
            this.X = x;
            this.Y = y;
            if (r < 0)
            {
                throw new Exception();
            }

            this.Radius = r;
        }

        public override void DrawFigure()
        {
            Console.WriteLine($"Round (A,r). A = ({this.X}, {this.Y}), r = {this.Radius}");
        }
    }
}
