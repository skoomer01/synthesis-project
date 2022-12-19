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
        IUserRepo userRepository;

        public UserManager(IUserRepo userRepository)
        {
            this.userRepository = userRepository;
        }   

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

        public bool CreateUser(string email, string password, string userName, string type)
        {
            try
            {
                if (email != String.Empty &&
                    password != String.Empty &&
                    userName != String.Empty)
                {
                    
                    if (EmailValidation.IsValidEmail(email) == false)
                    {
                        throw new Exception("Invalid email\nExample: john.doe@email.com");
                    }

                    if (userRepository.GetUserByEmail(email) == null)
                    {
                        userRepository.CreateUser(userName, email, password, type);
                        return true;
                    }
                    else { throw new Exception("This email is already taken"); }
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            return false;
        }
        public User GetUserByID(int? ID)
        {
            if(ID != null)
            {
                User user = new User(userRepository.GetUserByID((int)ID));
                return user;
            }
            return null;
        }
        public bool UpdateUser(int id, string name, string email, string type)
        {
            try
            {
                if (email != String.Empty &&
                    name != String.Empty &&
                    type != String.Empty)
                {
                    userRepository.UpdateUser(id, name, email, type);
                    return true;
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            return false;            
        }
    }
}
