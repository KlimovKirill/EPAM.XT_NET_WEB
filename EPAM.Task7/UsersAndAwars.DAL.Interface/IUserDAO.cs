﻿using System.Collections.Generic;
using UsersAndAwords.Entities;

namespace UsersAndAwards.DAL
{
    public interface IUserDAO
    {
        void Add(User user);

        bool Delete(int id);

        void Edit(User user);

        User GetById(int id);

        IEnumerable<User> GetAllUsers();

        void SaveUserStorage();

    }
}
