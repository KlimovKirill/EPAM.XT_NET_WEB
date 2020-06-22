using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2._2._1.Game
{
    public class Battlefield
    {
        private int width;
        private int height;

        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 1)
                {
                    throw new Exception("Field params must be > 0");
                }
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 1)
                {
                    throw new Exception("Field params must be > 0");
                }
            }
        }
    }
}
