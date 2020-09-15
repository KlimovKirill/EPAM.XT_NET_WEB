using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.BLL.Interface;
using UsersAndAwards.DAL;
using UsersAndAwords.Entities;

namespace UsersAndAwards.BLL
{
    public class AwardBLL : IAwardBLL
    {
        private IAwardDAO _awardDAO;
        public void Add(Award award)
        {
            throw new NotImplementedException();
        }

        public void AddAwardToUser(int awardId, int userId)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Award> GetAll()
        {
            throw new NotImplementedException();
        }

        public Award GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, List<int>> GetDictionaryOfAwardsAndUsers()
        {
            throw new NotImplementedException();
        }
    }
}
