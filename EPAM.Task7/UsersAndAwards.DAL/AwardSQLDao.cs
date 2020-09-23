using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using UsersAndAwords.Entities;

namespace UsersAndAwards.DAL
{
    public class AwardSQLDao : IAwardDAO
    {
        private string _connectionString;

        public AwardSQLDao()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public void Add(Award award)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "dbo.AddAward";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterTitle = new SqlParameter("@Title", award.Title);
                command.Parameters.Add(parameterTitle);

                SqlParameter parameterImageURL = new SqlParameter("@ImageURL", award.ImageURL);
                command.Parameters.Add(parameterImageURL);

                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AddAwardToUser(int awardID, int userID)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "AddAwardToUser";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterAwardId = new SqlParameter("@AwardId", awardID);
                command.Parameters.Add(parameterAwardId);

                SqlParameter parameterUserId = new SqlParameter("@UserId", userID);
                command.Parameters.Add(parameterUserId);

                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
            }
        }

        public bool Delete(int id)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "DeleteAward";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter("@Id", id);
                command.Parameters.Add(parameterId);

                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
                return true;
            }
        }

        public void Edit(Award award)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "EditAward";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter("@Id", award.ID);
                command.Parameters.Add(parameterId);

                SqlParameter parameterTitle = new SqlParameter("@Title", award.Title);
                command.Parameters.Add(parameterTitle);

                SqlParameter parameterImageURL = new SqlParameter("@ImageURL", award.ImageURL);
                command.Parameters.Add(parameterImageURL);

                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Award> GetAllAwards()
        {
            var result = new List<Award>();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetAllAwards";
                command.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(
                        new Award
                        {
                            ID = (int)reader["Id"],
                            Title = (string)reader["Title"],
                            ImageURL = (string)reader["ImageURL"],
                        });
                }
            }

            return result;
        }

        public Award GetById(int id)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetAwardById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter("@Id", id);
                command.Parameters.Add(parameterId);

                sqlConnection.Open();
                var reader = command.ExecuteReader();

                Award result = new Award();
                while (reader.Read())
                {
                    result =
                        new Award
                        {
                            ID = (int)reader["Id"],
                            Title = (string)reader["Title"],
                            ImageURL = (string)reader["ImageURL"],
                        };
                }

                return result;
            }
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
