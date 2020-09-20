using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndAwords.Entities
{
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }
        
        public DateTime DateOfBirth { get; set; }

        public int Age 
        {
            get
            {
                return DateTime.Now.Year - this.DateOfBirth.Year;
            }
        }

        public override string ToString()
        {
            return $"{ID} {Name} {Age}";
        }
    }
}
