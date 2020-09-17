using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwords.Entities;

namespace UsersAndAwards.DAL
{
    public class AwardDAO : IAwardDAO
    {
        private static Dictionary<int, List<int>> awardIdUserIDs = ReadAwardToUserStorage();

        private static Dictionary<int, Award> repoAwards = ReadAwardStorage();

        public Dictionary<int, List<int>> GetDictionaryOfAwardsAndUsers()
        {
            return awardIdUserIDs;
        }

        public void Add(Award award)
        {
            int lastId = repoAwards.Any() ? repoAwards.Keys.Max() : 0;

            award.ID = ++lastId;

            repoAwards.Add(award.ID, award);
        }

        public void AddAwardToUser(int awardID, int userID)
        {
            if (!awardIdUserIDs.ContainsKey(awardID)) 
            {
                awardIdUserIDs.Add(awardID, new List<int>());
            }

            if (!awardIdUserIDs[awardID].Contains(userID))
            {
                awardIdUserIDs[awardID].Add(userID);
            }
        }

        public bool Delete(int id)
        {
            return repoAwards.Remove(id);
        }

        public IEnumerable<Award> GetAllAwards()
        {
            return repoAwards.Values;
        }

        public Award GetById(int id)
        {
            if (repoAwards.TryGetValue(id, out var award))
            {
                return award;
            }

            return null;
        }

        public void SaveAwardStorage()
        {
            using (StreamWriter streamWriter = new StreamWriter("AwardStorage.txt"))
            {
                foreach (var award in repoAwards)
                {
                    streamWriter.WriteLine($"{award.Value.ID}{Environment.NewLine}" +
                                           $"{award.Value.Title}");
                }
            }
        }

        public void SaveAwardToUserStorage()
        {
            using (StreamWriter streamWriter = new StreamWriter("AwardToUsersStorage.txt"))
            {
                foreach (var item in awardIdUserIDs)
                {
                    streamWriter.WriteLine($"{item.Key}");

                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        streamWriter.Write($"{item.Value[i]} ");
                    }

                    streamWriter.Write($"{Environment.NewLine}");
                }
            }
        }

        private static Dictionary<int, Award> ReadAwardStorage() 
        {
            Dictionary<int, Award> tempRepo = new Dictionary<int, Award>();

            if (!File.Exists("AwardStorage.txt"))
            {
                return tempRepo;
            }

            using (StreamReader sr = new StreamReader("AwardStorage.txt"))
            {
                while (!sr.EndOfStream)
                {
                    int srId = int.Parse(sr.ReadLine());
                    string srTitle = sr.ReadLine();
             
                    Award tempAward = new Award
                    {
                        ID = srId,
                        Title = srTitle,
                    };

                    tempRepo.Add(srId, tempAward);
                }
            }

            return tempRepo;
        }

        private static Dictionary<int, List<int>> ReadAwardToUserStorage()
        {
            Dictionary<int, List<int>> tempRepo = new Dictionary<int, List<int>>();

            if (!File.Exists("AwardToUserStorage.txt"))
            {
                return tempRepo;
            }

            using (StreamReader sr = new StreamReader("AwardToUserStorage.txt"))
            {
                while (!sr.EndOfStream)
                {
                    int aId = int.Parse(sr.ReadLine());
                    string uIds = sr.ReadLine();

                    var nums = uIds
                        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(n => int.Parse(n));

                    List<int> tempList = new List<int>();

                    foreach (var i in nums)
                    {
                        tempList.Add(i);
                    }

                    tempRepo.Add(aId, tempList);
                }
            }

            return tempRepo;
        }
    }
}
