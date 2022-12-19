using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserRepository : IUserRepo
    {
        public List<UserDTO> GetUsers()
        {
            List<UserDTO> users = new List<UserDTO>();
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"SELECT UserId, UserName, UserEmail ,UserType
                                FROM s_User
                                ORDER BY UserId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                UserDTO user = null;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    user = new UserDTO();
                    user.UserId = dr.GetInt32("UserId");
                    user.UserName = dr.GetString("UserName");
                    user.UserEmail = dr.GetString("UserEmail");
                    user.EnumUserType = dr.GetString("UserType");
                    users.Add(user);
                }
                conn.Close();
                return users;
            }
        }

        public UserDTO FindUser(string email, string password)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"SELECT   UserId,
                                        UserName,
                                        UserType
                                FROM
                                    s_User
                                WHERE
                                    UserEmail = @UserEmail AND 
                                    UserPassword = hashbytes('SHA2_256', convert(varchar(max), concat(convert(varchar(max), @UserPassword), UserPasswordSalt)))";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserEmail", email);
                cmd.Parameters.AddWithValue("@UserPassword", password);

                conn.Open();
                UserDTO user = null;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    user = new UserDTO();
                    user.UserName = dr.GetString("UserName");
                    user.UserId = dr.GetInt32("UserId");
                    user.EnumUserType = dr.GetString("UserType");
                }
                conn.Close();
                return user;
            }
        }

        public void UpdateUser(int id, string name, string email, string type)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "UPDATE s_User SET UserName=@UserName, UserEmail=@UserEmail, UserType = @UserType WHERE UserId=@UserId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("UserID", id);
                cmd.Parameters.AddWithValue("UserName", name);
                cmd.Parameters.AddWithValue("UserEmail", email);
                cmd.Parameters.AddWithValue("UserType", type);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public UserDTO GetUserByID(int ID)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT * FROM s_User WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("UserId", ID);

                UserDTO user = null;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    user = new UserDTO();
                    user.UserEmail = dr.GetString("UserEmail");
                    user.UserName = dr.GetString("UserName");
                    user.UserId = ID;

                }
                conn.Close();
                return user;
            }
        }

        public UserDTO GetUserByEmail(string email)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT * FROM s_User WHERE UserEmail = @UserEmail";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("UserEmail", email);

                UserDTO user = null;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    user = new UserDTO();
                    user.UserId = dr.GetInt32("UserId");
                    user.UserName = dr.GetString("UserName");
                    user.UserEmail = email;
                }
                conn.Close();
                return user;
            }
        }

        public void CreateUser(string name, string mail, string password, string type)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"DECLARE @UserPasswordSalt varchar(max) = crypt_gen_random(16);
                                INSERT INTO s_User(UserName,
                                                    UserEmail,
                                                    UserPassword,
                                                    UserPasswordSalt,
                                                    UserType)
                                            VALUES(@UserName,
                                                    @UserEmail,
                                                    hashbytes('SHA2_256', convert(varchar(max), concat(convert(varchar(max), @UserPassword), @UserPasswordSalt))),
                                                    @UserPasswordSalt,
                                                    @UserType);";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("UserName", name);
                cmd.Parameters.AddWithValue("UserEmail", mail);
                cmd.Parameters.AddWithValue("UserPassword", password);
                cmd.Parameters.AddWithValue("UserType", type);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdatePassword(UserDTO user) //for password change web part
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"DECLARE @UserPasswordSalt varchar(max) = crypt_gen_random(16);
                                UPDATE s_User
                                SET
                                    UserPassword = hashbytes('SHA2_256', convert(varchar(max), concat(convert(varchar(max), @UserPassword), @UserPasswordSalt))),
                                WHERE
                                    UserId = @UserId;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("UserId", user.UserId);
                cmd.Parameters.AddWithValue("UserPassword", user.UserPassword);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
