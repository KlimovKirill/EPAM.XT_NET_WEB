using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndAwords.Entities
{
    public class Award
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string ImageURL = "https://www.flaticon.com/svg/static/icons/svg/3112/3112946.svg";

        public override string ToString()
        {
            return $"{ID} {Title}";
        }
    }
}
