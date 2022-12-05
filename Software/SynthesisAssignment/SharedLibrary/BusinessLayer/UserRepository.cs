using SharedLibrary.LogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.BusinessLayer
{
    public class UserRepository
    {
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"SELECT UserId, UserName, UserEmail ,UserType
                                FROM s_User
                                ORDER BY UserId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                User user = null;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    user = new User();
                    user.UserId = dr.GetInt32("UserId");
                    user.UserName = dr.GetString("UserName");
                    user.UserEmail = dr.GetString("UserEmail");
                    user.EnumUserType = user.SetType(dr.GetString("UserType"));
                    users.Add(user);
                }
                return users;
            }
        }

        public User FindUser(string email, string password)
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
                User user = null;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    user = new User();
                    user.UserName = dr.GetString("UserName");
                    user.UserId = dr.GetInt32("UserId");
                    user.EnumUserType = user.SetType(dr.GetString("UserType"));
                }
                return user;
            }
        }

        public void UpdateUser(User user)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "UPDATE s_User SET UserName=@UserName, UserEmail=@UserEmail, UserType = @UserType WHERE UserId=@UserId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("UserID", user.UserId);
                cmd.Parameters.AddWithValue("UserName", user.UserName);
                cmd.Parameters.AddWithValue("UserEmail", user.UserEmail);
                cmd.Parameters.AddWithValue("UserType", user.GetType(user.EnumUserType));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public User GetUserByID(int ID)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT * FROM s_User WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("UserId", ID);

                User user = null;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    user = new User();
                    user.UserEmail = dr.GetString("UserEmail");
                    user.UserName = dr.GetString("UserName");
                    user.UserId = ID;

                }
                return user;
            }
        }

        public User GetUserByEmail(string email)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT * FROM s_User WHERE UserEmail = @UserEmail";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("UserEmail", email);

                User user = null;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    user = new User();
                    user.UserId = dr.GetInt32("UserId");
                    user.UserName = dr.GetString("UserName");
                    user.UserEmail = email;
                }
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
            }
        }

        public void UpdatePassword(User user) //for password change web part
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
            }
        }

        public void DeleteUser(User user)
        {
            using (SqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = @"DELETE from s_User
                                WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("UserId", user.UserId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
