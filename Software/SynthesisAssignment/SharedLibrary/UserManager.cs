using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class UserManager
    {
        UserRepository userRepository = new UserRepository();
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            foreach(UserDTO userDTO in userRepository.GetUsers())
            {
                User user = new User(userDTO);
                users.Add(user);
            }
            return users;
        }

        public void CreateUser(string email, string password, string userName, string type)
        {
            User user = new User(userRepository.GetUserByEmail(email));
            if (user == null)
            {
                userRepository.CreateUser(userName, email, password, type);
            }
            else
            {
                throw new Exception("This email is already taken");
            }

        }
        public User GetUserByID(int ID)
        {
            User user = new User(userRepository.GetUserByID(ID));
            return user;
        }
        public void UpdateUser(int id, string name, string email, string type)
        {
                userRepository.UpdateUser(id, name, email, type);
        }

        public void DeleteUser(int id)
        {
            userRepository.DeleteUser(id);
        }
    }
}
