using LogicLayer;
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
        private ProductManager productManager = new ProductManager();
        public ProductManagement(LoginForm loginForm, User user)
        {
            this.loginForm = loginForm;
            this.user = user;
            InitializeComponent();

            dgvAllProducts.DataSource = productManager.Products;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxProductName.Text != String.Empty &&
                    tbxPrice.Text != String.Empty &&
                    tbxUnit.Text != String.Empty &&
                    cbxCategory.Text != String.Empty &&
                    cbxSubCategory.Text != String.Empty)
                {
                    decimal price;
                    if(Decimal.TryParse(tbxPrice.Text, out price))
                    {
                        productManager.AddProduct(tbxProductName.Text, cbxCategory.Text, cbxSubCategory.Text, price, tbxUnit.Text, tbxImage.Text);
                        MessageBox.Show("Product added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid price. Should be decimal (0.00)");
                    }
                    
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ProductManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
