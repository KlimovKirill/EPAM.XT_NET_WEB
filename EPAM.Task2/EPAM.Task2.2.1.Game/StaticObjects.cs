using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2._2._1.Game
{
    public abstract class StaticObjects : ObjectsOnField
    {
        private bool presence = true;

        public bool IsOnField()
        {
            return this.presence;
        }

        protected void DeleteFromField()
        {
            this.presence = false;
        }
    }
}
