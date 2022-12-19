using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IUserRepo
    {
        public List<UserDTO> GetUsers();
        public UserDTO FindUser(string email, string password);
        public void UpdateUser(int id, string name, string email, string type);
        public UserDTO GetUserByID(int ID);
        public UserDTO GetUserByEmail(string email);
        public void CreateUser(string name, string mail, string password, string type);
        public void UpdatePassword(UserDTO user);

    }
}
