using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using LogicLayer;

namespace DesktopApplication
{
    public partial class MarketingDepartment : Form
    {
        private LoginForm loginForm;
        private User user;
        private ProductManager productManager;
        ProductRepository productRepository = new ProductRepository();
        AdvertisementManager advertisementManager;
        AdvertisementRepo advertisementRepo = new AdvertisementRepo();
        public MarketingDepartment(LoginForm loginForm, User user)
        {
            productManager = new ProductManager(productRepository);
            advertisementManager = new AdvertisementManager(advertisementRepo, productRepository);
            this.loginForm = loginForm;
            this.user = user;
            InitializeComponent();
            lblMarketingManagerUser.Text = "Welcome, " + user.UserName + "!";
            DGVfill();
        }

        public void DGVfill()
        {
            dgvMostPopular.DataSource = advertisementManager.GetMostPopularItems();
            dgvLeastPopular.DataSource = advertisementManager.GetLeastPopularItems();
            dgvRemoveDiscount.DataSource = advertisementManager.GetDiscountedItems();
            dgvLeastPopular.Columns[2].Visible = false;
            dgvLeastPopular.Columns[4].Visible = false;
            dgvMostPopular.Columns[2].Visible = false;
            dgvMostPopular.Columns[4].Visible = false;
            dgvRemoveDiscount.Columns[2].Visible = false;
            dgvRemoveDiscount.Columns[4].Visible = false;
            
        }

        private void MarketingDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdateMostPoppular_Click(object sender, EventArgs e)
        {
            int index = dgvMostPopular.CurrentRow.Index;
            int productID;
            DataGridViewRow row = dgvMostPopular.Rows[index];
            productID = Convert.ToInt32(row.Cells[0].Value.ToString());
            decimal discount = nudMost.Value;
            if(discount > 0)
            {
                advertisementManager.UpdateProductDiscount(productID, discount);
                MessageBox.Show("Discount added successfully");
            }
            
            DGVfill();
        }

        private void btnUpdateLeastPopular_Click(object sender, EventArgs e)
        {
            int index = dgvLeastPopular.CurrentRow.Index;
            int productID;
            DataGridViewRow row = dgvLeastPopular.Rows[index];
            productID = Convert.ToInt32(row.Cells[0].Value.ToString());
            decimal discount = nudLeast.Value;
            if (discount > 0)
            {
                advertisementManager.UpdateProductDiscount(productID, discount);
                MessageBox.Show("Discount added successfully");
            }
            DGVfill();
        }

        private void btnRemoveDiscount_Click(object sender, EventArgs e)
        {
            int index = dgvRemoveDiscount.CurrentRow.Index;
            int productID;
            DataGridViewRow row = dgvRemoveDiscount.Rows[index];
            productID = Convert.ToInt32(row.Cells[0].Value.ToString());
            advertisementManager.RevertProductDiscount(productID);
            DGVfill();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
