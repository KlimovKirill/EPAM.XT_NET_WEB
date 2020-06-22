using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2._2._1.Game
{
    public abstract class ObjectsOnField
    {
        private Position position;

        public Position Position
        {
            get
            {
                return this.position;
            }

            set
            {
              
                if (value.X < 0 || value.Y < 0)
                {
                    throw new Exception("Object on filed position params must be >= 0");
                }
                else
                {
                    this.position = value;
                }
            }
        }
    }
}
