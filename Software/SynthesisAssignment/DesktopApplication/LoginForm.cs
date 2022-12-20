using DataLayer;
using LogicLayer;
using System.Text.RegularExpressions;
namespace DesktopApplication
{
    public partial class LoginForm : Form
    {
        LoginManager loginManager = new LoginManager();
        UserRepository userRepository = new UserRepository();
        UserManager userManager;
        public LoginForm()
        {
            userManager = new UserManager(userRepository);
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                if (EmailValidation.IsValidEmail(tbxEmail.Text) == true)
                {
                    user = loginManager.Login(tbxEmail.Text, tbxPassword.Text);
                }
                else
                {
                    user = null;

                    MessageBox.Show("Email is in the wrong format");
                }
                if (user != null)
                {
                    if (user.EnumUserType == EnumTypeOfUser.PRODUCTEMPLOYEE)
                    {
                        tbxPassword.Text = String.Empty;

                        ProductManagement productManagementForm = new ProductManagement(this, user);
                        productManagementForm.Show();
                        this.Hide();
                    }
                    else if (user.EnumUserType == EnumTypeOfUser.HUMANRESOURCES)
                    {
                        tbxPassword.Text = String.Empty;

                        HumanResources humanResourcesForm = new HumanResources(this, user);
                        humanResourcesForm.Show();
                        this.Hide();
                    }
                    else if (user.EnumUserType == EnumTypeOfUser.ORDERMANAGER)
                    {
                        tbxPassword.Text = String.Empty;

                        OrderManagement orderManagement = new OrderManagement(this, user);
                        orderManagement.Show();
                        this.Hide();
                    }
                    else if (user.EnumUserType == EnumTypeOfUser.CUSTOMER)
                    {
                        throw new Exception("You are not authorized to access the desktop application");
                    }
                    else
                    {
                        throw new Exception("Invalid Credentials");
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
}

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            pnlCreateAccount.Visible = true;
            lblEmail.Visible = false;
            lblPassword.Visible = false;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            pnlCreateAccount.Visible = false;
            lblEmail.Visible = true;
            lblPassword.Visible = true;
        }
        public string employeeType()
        {
            if (cbxUserType.Text == "Human Resources")
            {
                return "HUMANRESOURCES";
            }
            else if (cbxUserType.Text == "Product Manager")
            {
                return "PRODUCTMANAGER";
            }
            else if (cbxUserType.Text == "Order Manager")
            {
                return "ORDERMANAGER";
            }
            else
                return "CUSTOMER";
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if(userManager.CreateUser(tbxCreateEmail.Text, tbxCreatePassword.Text, tbxCreateName.Text, employeeType()) == true)
                {
                    MessageBox.Show("New account successfully created");
                }
                else { MessageBox.Show("Invalid creditentials");}
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}