using SharedLibrary.LogicLayer;
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
        public HumanResources(LoginForm loginForm, User user)
        {
            this.loginForm = loginForm;
            this.user = user;
            userManager = new UserManager();

            InitializeComponent();

            users = userManager.GetAllUsers();
            lblUserNameDisplay.Text = user.UserName;

            RefreshUserData();
        }

        public void RefreshUserData()
        {
            dgvAllUsers.DataSource = users;
            dgvEditUsers.DataSource = users;
        }

        public string employeeType()
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
                    string userID;
                    DataGridViewRow row = dgvEditUsers.Rows[index];
                    userID = row.Cells[0].Value.ToString();
                    User editUser = userManager.GetUserByID(Convert.ToInt32(userID));   
                    editUser.UserEmail = tbxEditEmail.Text;
                    editUser.UserName = tbxEditName.Text;
                    editUser.EnumUserType =  editUser.SetType(employeeType());
                    if (EmailValidation.IsValidEmail(tbxEditEmail.Text) == true)
                    {
                        editUser.UserEmail = tbxEditEmail.Text;
                    }
                    else
                    {
                        throw new Exception("Invalid Email");
                    }

                    userManager.UpdateUser(editUser);
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
        }
    }
}
