using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class User
    {
        public User()
        {

        }

        public User(UserDTO userDTO)
        {
            UserId = userDTO.UserId;
            UserName = userDTO.UserName;
            UserEmail = userDTO.UserEmail;
            UserPassword = userDTO.UserPassword;
            EnumUserType = SetType(userDTO.EnumUserType);
        }
        [DisplayName("Identification number")]
        public int UserId { get; set; }
        [DisplayName("Name")]
        public string UserName { get; set; }
        [DisplayName("Email address")]
        public string UserEmail { get; set; }
        [Browsable(false)]
        public string UserPassword { get; set; }
        [DisplayName("Type of user")]
        public EnumTypeOfUser EnumUserType { get; set; }

        public override string ToString()
        {
            return $"{UserId}, {UserName}, {UserEmail}";
        }

        public EnumTypeOfUser SetType(string type)
        {
            EnumTypeOfUser setType = EnumTypeOfUser.CUSTOMER;

            switch (type)
            {
                case "PRODUCTMANAGER":
                    setType = EnumTypeOfUser.PRODUCTEMPLOYEE;
                    break;

                case "HUMANRESOURCES":
                    setType = EnumTypeOfUser.HUMANRESOURCES;
                    break;

            }
            return setType;
        }

        public string GetType(EnumTypeOfUser type)
        {
            string setType = "CUSTOMER";
            switch (type)
            {
                case EnumTypeOfUser.PRODUCTEMPLOYEE:
                    setType = "PRODUCTMANAGER";
                    break;

                case EnumTypeOfUser.HUMANRESOURCES:
                    setType = "HUMANRESOURCES";
                    break;

            }
            return setType;
        }
    }
}
