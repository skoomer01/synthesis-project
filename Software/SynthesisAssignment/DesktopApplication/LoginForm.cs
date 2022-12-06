using SharedLibrary.LogicLayer;
using System.Text.RegularExpressions;
namespace DesktopApplication
{
    public partial class LoginForm : Form
    {
        LoginManager loginManager = new LoginManager();
        UserManager userManager = new UserManager();
        public LoginForm()
        {
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
                    else if (user.EnumUserType == EnumTypeOfUser.CUSTOMER)
                    {
                        throw new Exception("You are not authorized to access the desktop application");
                    }
                    else
                    {
                        throw new Exception("Invalid Credentials");
                    }

                }
                else
                {
                    throw new Exception("Invalid Credentials");
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
            else
                return "CUSTOMER";
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxCreateName.Text != String.Empty &&
                    tbxCreateEmail.Text != String.Empty &&
                    tbxCreatePassword.Text != String.Empty)
                {

                    if (EmailValidation.IsValidEmail(tbxCreateEmail.Text) == false)
                    {
                        throw new Exception("Invalid email\nExample: john.doe@email.com");
                    }

                    userManager.CreateUser(tbxCreateEmail.Text, tbxCreatePassword.Text, tbxCreateName.Text, employeeType());
                    MessageBox.Show("Account created successfully!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}