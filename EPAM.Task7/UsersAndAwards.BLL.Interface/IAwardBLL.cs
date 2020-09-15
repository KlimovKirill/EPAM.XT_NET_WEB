using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwords.Entities;

namespace UsersAndAwards.BLL.Interface
{
    public interface IAwardBLL
    {
        void Add(Award award);

        void Delete(int id);

        Award GetById(int id);

        IEnumerable<Award> GetAll();

        void AddAwardToUser(int awardId, int userId);

        Dictionary<int, List<int>> GetDictionaryOfAwardsAndUsers();
    }
}
