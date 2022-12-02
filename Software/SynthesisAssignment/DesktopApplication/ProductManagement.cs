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
    public partial class ProductManagement : Form
    {
        private LoginForm loginForm;
        private User user;
        public ProductManagement(LoginForm loginForm, User user)
        {
            this.loginForm = loginForm;
            this.user = user;
            InitializeComponent();
        }
    }
}
