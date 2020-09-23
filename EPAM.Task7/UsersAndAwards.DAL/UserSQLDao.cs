using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using UsersAndAwords.Entities;

namespace UsersAndAwards.DAL
{
    public class UserSQLDao : IUserDAO
    {
        private string _connectionString;

        public UserSQLDao()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public void Add(User user)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "AddUser";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterName = new SqlParameter("@Name", user.Name);
                command.Parameters.Add(parameterName);

                SqlParameter parameterImageURL = new SqlParameter("@UserImageURL", user.ImageURL);
                command.Parameters.Add(parameterImageURL);

                SqlParameter parameterDateOfBirth = new SqlParameter("@DateOfBirth", user.DateOfBirth);
                command.Parameters.Add(parameterDateOfBirth);

                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
            }
        }

        public bool Delete(int id)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "DeleteUser";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter("@Id", id);
                command.Parameters.Add(parameterId);

                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
                return true;
            }
        }

        public void Edit(User user)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "EditUser";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter("@Id", user.ID);
                command.Parameters.Add(parameterId);

                SqlParameter parameterName = new SqlParameter("@Name", user.Name);
                command.Parameters.Add(parameterName);

                SqlParameter parameterImageURL = new SqlParameter("@UserImageURL", user.ImageURL);
                command.Parameters.Add(parameterImageURL);

                SqlParameter parameterDateOfBirth = new SqlParameter("@DateOfBirth", user.DateOfBirth);
                command.Parameters.Add(parameterDateOfBirth);

                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            var result = new List<User>();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetAllUsers";
                command.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(
                        new User
                        {
                            ID = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            ImageURL = (string)reader["UserImageURL"],
                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                        });
                }
            }

            return result;
        }

        public User GetById(int id)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetUserById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter("@Id", id);
                command.Parameters.Add(parameterId);

                sqlConnection.Open();
                var reader = command.ExecuteReader();

                User result = new User();
                while (reader.Read())
                {
                    result =
                        new User
                        {
                            ID = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            ImageURL = (string)reader["UserImageURL"],
                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                        };
                }

                return result;
            }
        }

        public void SaveUserStorage()
        {
            throw new NotImplementedException();
        }
    }
}
