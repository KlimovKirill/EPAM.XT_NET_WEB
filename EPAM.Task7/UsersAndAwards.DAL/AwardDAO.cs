using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwords.Entities;

namespace UsersAndAwards.DAL
{
    public class AwardDAO : IAwardDAO
    {
        public void Add(Award award)
        {
            throw new NotImplementedException();
        }

        public void AddAwardToUser(int awardID, int userID)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Award> GetAllAwards()
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

        public void SaveAwardStorage()
        {
            throw new NotImplementedException();
        }

        public void SaveAwardToUserStorage()
        {
            throw new NotImplementedException();
        }
    }
}
