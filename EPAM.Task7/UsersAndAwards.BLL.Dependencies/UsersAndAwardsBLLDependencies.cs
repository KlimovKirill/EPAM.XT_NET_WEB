using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.BLL.Interface;
using UsersAndAwards.DAL;

namespace UsersAndAwards.BLL.Dependencies
{
    public static class UsersAndAwardsBLLDependencies
    {
        private static IAwardBLL _awardLogic;

        private static IUserBLL _userLogic;
        public static IAwardBLL AwardLogic => _awardLogic ?? (_awardLogic = new AwardBLL());

        public static IUserBLL UserLogic => _userLogic ?? (_userLogic = new UserBLL());
    }
}
