using System.Collections.Generic;
using UsersAndAwords.Entities;

namespace UsersAndAwards.DAL
{
    public interface IAwardDAO
    {
        void Add(Award award);

        bool Delete(int id);

        Award GetById(int id);

        void SaveAwardStorage();

        void SaveAwardToUserStorage();

        void AddAwardToUser(int awardID, int userID);

        Dictionary<int, List<int>> GetDictionaryOfAwardsAndUsers();

        IEnumerable<Award> GetAllAwards();

    }
}
