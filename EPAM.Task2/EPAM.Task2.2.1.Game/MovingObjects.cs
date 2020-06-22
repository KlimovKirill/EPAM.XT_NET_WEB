using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2._2._1.Game
{
    public abstract class MovingObjects : ObjectsOnField
    {
        private bool alive = true;

        public bool IsAlive()
        {
            return this.alive;
        }

        public void Kill()
        {
            this.alive = false;
        }

        public abstract void Moving();
    }
}
