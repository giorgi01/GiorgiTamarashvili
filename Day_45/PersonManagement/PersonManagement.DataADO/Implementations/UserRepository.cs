using Microsoft.Extensions.Options;
using PersonManagement.Data;
using PersonManagement.DataADO.Models;
using PersonManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.DataADO.Implementations
{
    public class UserRepository : IUserRepository
    {
        const string SECRET_KEY = "asldij23324";

        private readonly string _connection;

        private string GenerateMD5Hash(string input)
        {
            using(MD5 md5 = MD5.Create())
            {
                byte[] bytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public UserRepository(IOptions<ConnectionStrings> options)
        {
            _connection = options.Value.DefaultConnection;
        }

        public async Task<string> CreateAsync(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                string insertQuery = "INSERT INTO Users(FirstName, LastName, Username, Password) OUTPUT INSERTED.Username VALUES(@FirstName, @LastName, @Username, @Password)";

                SqlCommand command = new SqlCommand(insertQuery, connection);

                command.Parameters.AddWithValue("FirstName", user.FirstName);
                command.Parameters.AddWithValue("LastName", user.LastName);
                command.Parameters.AddWithValue("Username", user.Username);

                var newPass = GenerateMD5Hash(user.Password + SECRET_KEY);
                command.Parameters.AddWithValue("Password", newPass);

                connection.Open();

                return (string)await command.ExecuteScalarAsync().ConfigureAwait(false);
            }
           
        }

        public async Task<bool> Exists(string username)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                string existQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";

                SqlCommand command = new SqlCommand(existQuery, connection);

                command.Parameters.AddWithValue("username", username);

                connection.Open();

                int count = (int)await command.ExecuteScalarAsync().ConfigureAwait(false);

                return count > 0;

            }
        }

        public async Task<User> GetAsync(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                string existQuery = "SELECT * FROM Users WHERE Username = @username AND Password = @password";

                SqlCommand command = new SqlCommand(existQuery, connection);

                command.Parameters.AddWithValue("username", username);

                var newPass = GenerateMD5Hash(password + SECRET_KEY);
                command.Parameters.AddWithValue("Password", newPass);

                connection.Open();

                SqlDataReader reader = await command.ExecuteReaderAsync();

                User user = null;

                while (reader.Read())
                {
                    user = new User
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Username = reader.GetString(3),
                    };
                }
                reader.Close();

                return user;
            }
        }
    }
}
