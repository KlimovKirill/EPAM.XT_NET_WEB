using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwords.PL.Console;
using UsersAndAwords.PL.Interface;

namespace UsersAndAwards.PL.Dependencies
{
    public static class UsersAndAwardsPLDependencies
    {
        private static IUsersAndAwardsPL _usersAndAwardsPL;

        public static IUsersAndAwardsPL UsersAndAwardsPL => _usersAndAwardsPL ?? (_usersAndAwardsPL = new Program());
    }
}
