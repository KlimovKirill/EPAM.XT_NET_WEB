using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2._2._1.Game
{
    public class Player : MovingObjects
    {
        private Dictionary<string, int> bonuses = new Dictionary<string, int>(0); // Key - class name of a particular bonus, Value - number of this bonuses

        public void GetBonus(string bonusName)
        {
            this.bonuses[bonusName]++;
        }

        public int NumberOfBonuses()
        {
            int bonusesCount = 0;
            foreach (var item in this.bonuses)
            {
                bonusesCount += item.Value;
            }

            return bonusesCount;
        }

        public List<string> ListOfBonuses()
        {
            List<string> listOfBonuses = new List<string>(0);
            foreach (var item in this.bonuses)
            {
                listOfBonuses.Add(item.Key);
            }

            return listOfBonuses;
        }

        public override void Moving()
        {
        }
    }
}
