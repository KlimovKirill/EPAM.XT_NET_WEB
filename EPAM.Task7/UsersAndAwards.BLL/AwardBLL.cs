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
    public class AwardBLL : IAwardBLL
    {
        private readonly IAwardDAO _awardDAL;

        public AwardBLL()
        {
            _awardDAL = UsersAndAwardsDALDependencies.AwardDAO;
        }

        public void Add(Award award)
        {
            _awardDAL.Add(award);
            _awardDAL.SaveAwardStorage();
        }

        public void AddAwardToUser(int awardId, int userId)
        {
            _awardDAL.AddAwardToUser(awardId, userId);
            _awardDAL.SaveAwardToUserStorage();
        }

        public void Delete(int id)
        {
            _awardDAL.Delete(id);
            _awardDAL.SaveAwardStorage();
        }

        public void Edit(Award award)
        {
            _awardDAL.Edit(award);
            _awardDAL.SaveAwardStorage();
        }

        public IEnumerable<Award> GetAll()
        {
            return _awardDAL.GetAllAwards();
        }

        public Award GetById(int id)
        {
            return _awardDAL.GetById(id);
        }

        public Dictionary<int, List<int>> GetDictionaryOfAwardsAndUsers()
        {
            return _awardDAL.GetDictionaryOfAwardsAndUsers();
        }

       
    }
}
