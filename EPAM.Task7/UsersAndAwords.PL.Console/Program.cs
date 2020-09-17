using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.BLL.Dependencies;
using UsersAndAwards.BLL.Interface;
using UsersAndAwords.Entities;
using UsersAndAwords.PL.Interface;

namespace UsersAndAwords.PL.Console
{
    public class Program : IUsersAndAwardsPL
    {
        private static IUserBLL _userBLL;
        private static IAwardBLL _awardBLL;

        public Program()
        {
            _userBLL = UsersAndAwardsBLLDependencies.UserLogic;
            _awardBLL = UsersAndAwardsBLLDependencies.AwardLogic;
        }

        static void Main(string[] args)
        {
            //testing ConsolePL

            var pl = new Program();
            //pl.AddUser();
            //pl.AddUser();
            pl.ShowUsers();
            //pl.ShowUserById();
            //pl.ShowAwards();
            //pl.AddAward();
            //pl.ShowAwards();
            //pl.ShowAwardById();
            pl.AddAwardToUser();
            pl.AddAwardToUser();
            //pl.ShowUsers();
            //pl.DeleteAward();
            pl.ShowUsers();
        }

        public void AddUser()
        {
            var user = new User();

            System.Console.WriteLine("Form for adding user: ");
            System.Console.WriteLine("Enter user name: ");
            user.Name = System.Console.ReadLine();
            System.Console.WriteLine("Enter date of birth: ");

            try
            {
                user.DateOfBirth = DateTime.Parse(System.Console.ReadLine());
                _userBLL.Add(user);
            }
            catch
            {
                System.Console.WriteLine("Error");
            }

        }

        public void DeleteUser()
        {
            System.Console.WriteLine("Enter User ID: ");

            try
            {
                int id = int.Parse(System.Console.ReadLine());
                _userBLL.Delete(id);
            }
            catch 
            {
                System.Console.WriteLine("error");
            }
        }

        public void AddAward()
        {
            var award = new Award();

            System.Console.WriteLine("Form for adding award: ");
            System.Console.WriteLine("Enter award title: ");
            award.Title = System.Console.ReadLine();
            _awardBLL.Add(award);

        }

        public void DeleteAward()
        {
            System.Console.WriteLine("Enter Award ID: ");

            try
            {
                int id = int.Parse(System.Console.ReadLine());
                _awardBLL.Delete(id);
            }
            catch
            {
                System.Console.WriteLine("error");
            }
        }

        private void ShowUsers()
        {
            System.Console.WriteLine("ID|Name|Age");

            foreach (var user in _userBLL.GetAll())
            {
                System.Console.WriteLine(user);
                System.Console.WriteLine("User's awards:");
                Dictionary<int, List<int>> awardIdUserIDs = _awardBLL.GetDictionaryOfAwardsAndUsers();
                foreach (var item in awardIdUserIDs)
                {
                    if (item.Value.Contains(user.ID))
                    {
                        System.Console.WriteLine(_awardBLL.GetById(item.Key));
                    }
                }

                System.Console.WriteLine();
            }
        }

        private void ShowAwards()
        {
            System.Console.WriteLine("ID|Title");
            foreach (var award in _awardBLL.GetAll())
            {
                System.Console.WriteLine(award);
            }
        }

        private void ShowUserById()
        {
            System.Console.WriteLine("Enter user id:");

            try
            {
                int id = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine(_userBLL.GetById(id));
            }
            catch
            {
                System.Console.WriteLine("error");
            }
        }

        private void ShowAwardById()
        {
            System.Console.WriteLine("Enter award id:");

            try
            {
                int id = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine(_awardBLL.GetById(id));
            }
            catch
            {
                System.Console.WriteLine("error");
            }
        }

        private void AddAwardToUser() 
        {
            System.Console.WriteLine("Enter Award Id:");
            int awardId = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Enter User Id:");
            int userId = int.Parse(System.Console.ReadLine());

            _awardBLL.AddAwardToUser(awardId, userId);
        }
    }
}
