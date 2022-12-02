using SharedLibrary.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.LogicLayer
{
    public  class UserManager
    {
        UserRepository userRepository = new UserRepository();
        public List<User> GetAllUsers()
        {
            return userRepository.GetUsers();
        }

        public void CreateUser(string email, string password, string userName, string type)
        {
            User user = userRepository.GetUserByEmail(email);
            if (user == null)
            {
                userRepository.CreateUser(userName, email, password, type);
            }
            else
            {
                throw new Exception("This email is already taken");
            }

        }

        public void UpdateEmployee(User user)
        {
            if (user == null)
            {
                throw new Exception("Please select a user first");
            }
            else
            {
                userRepository.UpdateUser(user);
            }
        }

        public void DeleteUser(User user)
        {
            userRepository.DeleteUser(user);
        }
    }
}
