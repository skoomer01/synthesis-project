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
            User user =new User( userRepository.FindUser(email, password));
            return user;
        }
    }
}
