using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwords.Entities;

namespace UsersAndAwards.BLL.Interface
{
    public interface IUserBLL
    {
        void Add(User user);

        void Delete(int id);

        User GetById(int id);

        IEnumerable<User> GetAll();
    }
}
