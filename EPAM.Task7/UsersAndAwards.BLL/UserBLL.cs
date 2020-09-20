using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.BLL.Interface;
using UsersAndAwards.DAL;
using UsersAndAwards.DAL.Dependencies;
using UsersAndAwords.Entities;

namespace UsersAndAwards.BLL
{
    public class UserBLL : IUserBLL
    {
        private readonly IUserDAO _userDAL;

        public UserBLL() 
        {
            _userDAL = UsersAndAwardsDALDependencies.UserDAO;
        }

        public void Add(User user)
        {
            _userDAL.Add(user);
            _userDAL.SaveUserStorage();
        }

        public void Delete(int id)
        {
            _userDAL.Delete(id);
            _userDAL.SaveUserStorage();
        }

        public void Edit(User user)
        {
            _userDAL.Edit(user);
            _userDAL.SaveUserStorage();
        }

        public IEnumerable<User> GetAll()
        {
            return _userDAL.GetAllUsers();
        }

        public User GetById(int id)
        {
            return _userDAL.GetById(id);
        }
       
    }
}
