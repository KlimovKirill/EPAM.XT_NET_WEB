using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2._2._1.Game
{
    public class Position
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Position params must be >= 0");
                }
                else
                {
                    this.x = value;
                }
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Position params must be >= 0");
                }
                else
                {
                    this.y = value;
                }
            }
        }
    }
}
