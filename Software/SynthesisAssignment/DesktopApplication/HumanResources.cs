using SharedLibrary.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class HumanResources : Form
    {
        private User user;
        private LoginForm loginForm;
        private UserManager userManager;
        private List<User> users;
        public HumanResources(LoginForm loginForm, User user)
        {
            this.loginForm = loginForm;
            this.user = user;
            userManager = new UserManager();

            InitializeComponent();

            users = userManager.GetAllUsers();
            lblUserNameDisplay.Text = user.UserName;
        }
    }
}
