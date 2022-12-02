using SharedLibrary.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.LogicLayer
{
    public  class LoginManager
    {
        UserRepository userRepository = new UserRepository();
        public User Login(string email, string password)
        {
            User user = userRepository.FindUser(email, password);
            return user;
        }
    }
}
