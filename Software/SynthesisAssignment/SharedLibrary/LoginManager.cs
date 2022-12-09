using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class LoginManager
    {
        UserRepository userRepository = new UserRepository();
        public User Login(string email, string password)
        {  
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Please fill in all blanks.");
            }
            else
            {
                UserDTO userDTO = userRepository.FindUser(email, password);
                if (userDTO != null) { User user = new User(userDTO); return user; }
                else { throw new Exception("Wrong password."); }
            }            
        }
    }
}
