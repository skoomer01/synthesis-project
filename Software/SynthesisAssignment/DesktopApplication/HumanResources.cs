using DataLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        UserRepository userRepository = new UserRepository();
        public HumanResources(LoginForm loginForm, User user)
        {
            this.loginForm = loginForm;
            this.user = user;
            userManager = new UserManager(userRepository);

            InitializeComponent();

            users = userManager.GetAllUsers();
            lblUserNameDisplay.Text = "Welcome, " + user.UserName + "!";

            RefreshUserData();
        }

        public void RefreshUserData()
        {
            dgvAllUsers.DataSource = users;
            dgvEditUsers.DataSource = users;
        }

        public string userType()
        {
            if (cbxEditUserType.Text == "Human Resources")
            {
                return "HUMANRESOURCES";
            }
            else if (cbxEditUserType.Text == "Product Manager")
            {
                return "PRODUCTMANAGER";
            }
            else
                return "CUSTOMER";
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxEditName.Text != String.Empty &&
                    tbxEditEmail.Text != String.Empty &&
                    cbxEditUserType.SelectedItem != null)
                {
                    int index = dgvEditUsers.CurrentRow.Index;
                    int userID;
                    DataGridViewRow row = dgvEditUsers.Rows[index];
                    userID =Convert.ToInt32(row.Cells[0].Value.ToString());
                    string email;
                    string type = userType();
                    if (EmailValidation.IsValidEmail(tbxEditEmail.Text) == true)
                    {
                        email = tbxEditEmail.Text;
                    }
                    else
                    {
                        throw new Exception("Invalid Email");
                    }

                    userManager.UpdateUser(userID, tbxEditName.Text, tbxEditEmail.Text, type);
                    RefreshUserData();
                    MessageBox.Show("User data updated successfully :)");
                }
                else
                {
                    MessageBox.Show("Please fill in all fields");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dgvEditUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvEditUsers.CurrentRow.Index;
            string userID;
            DataGridViewRow row = dgvEditUsers.Rows[index];
            userID = row.Cells[0].Value.ToString();
            User editUser = userManager.GetUserByID(Convert.ToInt32(userID));
            tbxEditEmail.Text = editUser.UserEmail;
            tbxEditName.Text = editUser.UserName;
            RefreshUserData();
        }

        private void HumanResources_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
