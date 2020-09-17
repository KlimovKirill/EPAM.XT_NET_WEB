using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UsersAndAwords.Entities;

namespace UsersAndAwards.DAL
{
    public class UserDAO : IUserDAO
    {
        private static Dictionary<int, User> repoUsers = ReadUserStorage();

        public void Add(User user)
        {
            int lastId = repoUsers.Any() ? repoUsers.Keys.Max() : 0;

            user.ID = ++lastId;

            repoUsers.Add(user.ID, user);
        }

        public bool Delete(int id)
        {
            return repoUsers.Remove(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return repoUsers.Values;
        }

        public User GetById(int id)
        {
            if (repoUsers.TryGetValue(id, out var user))
            {
                return user;
            }

            return null;
        }

        public void SaveUserStorage()
        {
            using (StreamWriter streamWriter = new StreamWriter("UserStorage.txt"))
            {
                foreach (var user in repoUsers)
                {
                    streamWriter.WriteLine($"{user.Value.ID}{Environment.NewLine}" +
                                           $"{user.Value.Name}{Environment.NewLine}"+
                                           $"{user.Value.DateOfBirth}");
                }
            }
        }

        private static Dictionary<int, User> ReadUserStorage()
        {
            Dictionary<int, User> tempRepo = new Dictionary<int, User>();

            if (!File.Exists("UserStorage.txt"))
            {
                return tempRepo;
            }

            using (StreamReader sr = new StreamReader("UserStorage.txt"))
            {
                while (!sr.EndOfStream)
                {
                    int srId = int.Parse(sr.ReadLine());
                    string srName = sr.ReadLine();
                    DateTime srDateOfBirth = DateTime.Parse(sr.ReadLine());

                    User tempUser = new User
                    {
                        ID = srId,
                        Name = srName,
                        DateOfBirth = srDateOfBirth,
                    };

                    tempRepo.Add( srId, tempUser);
                }
            }

            return tempRepo;
        }
    }
}
