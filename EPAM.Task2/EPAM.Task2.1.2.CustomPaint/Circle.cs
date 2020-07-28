using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2._1._2.CustomPaint
{
    public class Circle : Figure
    {
        private Point a = new Point();
        private int r;

        public Circle(int x, int y, int r)
        {
            this.a.X = x;
            this.a.Y = y;
            if (r < 0)
            {
                throw new Exception();
            }

            this.r = r;
        }

        public Circle()
        {
        }

        public int Radius
        {
            get
            {
                return this.r;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }

                this.r = value;
            }
        }

        public int X
        {
            get
            {
                return this.a.X;
            }

            set
            {
                this.a.X = value;
            }
        }

        public int Y
        {
            get
            {
                return this.a.Y;
            }

            set
            {
                this.a.Y = value;
            }
        }

        public override string DrawFigure()
        {
            return $"Circle (A,r). A = ({this.a.X}, {this.a.Y}), r = {this.r}";
        }
    }
}
