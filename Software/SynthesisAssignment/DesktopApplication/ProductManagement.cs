 using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
        private CategoryManager categoryManager = new CategoryManager();
        public ProductManagement(LoginForm loginForm, User user)
        {
            this.loginForm = loginForm;
            this.user = user;
            InitializeComponent();
            UpdateCategories();
            Refreshdgv();
            
            lblProductManagerUser.Text ="Welcome, "+ user.UserName +"!";
        }
        
        public void Refreshdgv()
        {
            dgvAllProducts.DataSource = productManager.GetAllProducts();
            dgvAllProducts.Columns[2].Visible = false;
            dgvAllProducts.Columns[4].Visible = false;
            dgvEditProducts.DataSource = productManager.GetAllProducts();
            dgvEditProducts.Columns[2].Visible = false;
            dgvEditProducts.Columns[4].Visible = false;
            dgvCategory.DataSource = categoryManager.GetAllCategories();
            dgvDeleteProduct.DataSource = productManager.GetAllProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            try
            {
               if( productManager.AddProduct(tbxProductName.Text, cbxCategory.Text, cbxSubCategory.Text,tbxPrice.Text, tbxUnit.Text, tbxImage.Text) == true)
                {
                    MessageBox.Show("Product successfully added to the system.");
                    Refreshdgv();
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void UpdateSubCategories()
        {
            if (cbxCategory.SelectedItem != null)
            {
                cbxSubCategory.Items.Clear();
                foreach (Category category in categoryManager.GetAllCategories())
                {
                    if (category.Name == cbxCategory.SelectedItem.ToString())
                    {
                        foreach (Category subcategory in categoryManager.GetSubCategories(category.Id))
                        {
                            cbxSubCategory.Items.Add(subcategory.Name);
                        }
                    }
                }
            }

            if (cbxEditCategory.SelectedItem != null)
            {
                cbxEditSubCategory.Items.Clear();
                foreach (Category category in categoryManager.GetAllCategories())
                {
                    if (category.Name == cbxEditCategory.SelectedItem.ToString())
                    {
                        foreach (Category subcategory in categoryManager.GetSubCategories(category.Id))
                        {
                            cbxEditSubCategory.Items.Add(subcategory.Name);
                        }
                    }
                }
            }
        }

        public void UpdateCategories()
        {
            cbxCategory.Items.Clear();
            cbxSubCategory.Items.Clear();

            foreach(Category category in categoryManager.GetAllCategories())
            {
                cbxCategory.Items.Add(category.Name);
            }

            cbxEditCategory.Items.Clear();
            cbxEditSubCategory.Items.Clear();
            foreach (Category category in categoryManager.GetAllCategories())
            {
                cbxEditCategory.Items.Add(category.Name);
            }
        }
        private void ProductManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSubCategories();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvEditProducts.CurrentRow.Index;
                int productID;
                DataGridViewRow row = dgvEditProducts.Rows[index];
                productID = Convert.ToInt32(row.Cells[0].Value.ToString());
                if(productManager.UpdateProduct(productID, tbxEditName.Text, cbxEditCategory.Text, cbxEditSubCategory.Text, tbxEditPrice.Text, tbxEditUnit.Text, tbxEditImage.Text) == true)
                { MessageBox.Show("Product data successfully updated in the system");
                    Refreshdgv();
                }

                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dgvEditProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxEditName.Clear();
            tbxEditPrice.Clear();
            tbxEditUnit.Clear();
            tbxImage.Clear();
            cbxEditSubCategory.Items.Clear();
            UpdateCategories();
            

            int index = dgvEditProducts.CurrentRow.Index;
            int productID;
            DataGridViewRow row = dgvEditProducts.Rows[index];
            productID = Convert.ToInt32(row.Cells[0].Value.ToString());
            Product editProduct = productManager.GetProduct(productID);
            tbxEditName.Text = editProduct.Name;
            tbxEditPrice.Text = editProduct.Price.ToString();
            tbxEditUnit.Text = editProduct.Unit;
            tbxEditImage.Text = editProduct.ProductImage;
        }

        private void cbxEditCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSubCategories();
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxNewCataegory.Text != String.Empty)
                {
                    categoryManager.CreateCategory(tbxNewCataegory.Text, null);
                    MessageBox.Show("Category added successfully!");
                    UpdateCategories();

                }
                else { MessageBox.Show("Please fill the field first."); }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCreateSubcategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxNewSubcategory.Text != String.Empty)
                {
                    int index = dgvCategory.CurrentRow.Index;
                    int categoryID;
                    DataGridViewRow row = dgvCategory.Rows[index];
                    categoryID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    categoryManager.CreateCategory(tbxNewSubcategory.Text, categoryID);
                    MessageBox.Show("Sub-Category added successfully!");
                    UpdateSubCategories();

                }
                else { MessageBox.Show("Please fill the field first."); }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
             Category category = dgvCategory.CurrentRow.DataBoundItem as Category;

            Category c =  categoryManager.GetCategoryByName(tbxEditCategory.Text);
            if(c == null)
            {
                if (categoryManager.UpdateCategory(category.Id,tbxEditCategory.Text) == true)
                {
                    categoryManager.UpdateProductCategory(tbxEditCategory.Text, category.Name);
                    MessageBox.Show("Category updated successfully");
                    UpdateCategories();
                }
                else { MessageBox.Show("Oops, something went wrong.");}
            }
            else { MessageBox.Show("Category by that name already exists.");}           
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvCategory.CurrentRow.Index;
            int categoryID;
            DataGridViewRow row = dgvCategory.Rows[index];
            categoryID = Convert.ToInt32(row.Cells[0].Value.ToString());
            dgvSubCategory.DataSource = categoryManager.GetSubCategories(categoryID);
            foreach(Category category in categoryManager.CategoryList)
            {
                if(category.Id == categoryID) { tbxEditCategory.Text = category.Name; }
            }
        }

        private void dgvSubCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int subindex = dgvSubCategory.CurrentRow.Index;
            int subcategoryID;
            DataGridViewRow row = dgvSubCategory.Rows[subindex];
            subcategoryID = Convert.ToInt32(row.Cells[0].Value.ToString());

            foreach (Category category in categoryManager.GetAllSubCategories())
            {
                if (category.Id == subcategoryID) { tbxEditSubCategory.Text = category.Name; }
            }
        }

        private void btnEditSubCategory_Click(object sender, EventArgs e)
        {
            Category category= dgvSubCategory.CurrentRow.DataBoundItem as Category;


            Category c = categoryManager.GetCategoryByName(tbxEditSubCategory.Text);
            if (c == null)
            {
                if (categoryManager.UpdateCategory(category.Id, tbxEditSubCategory.Text) == true)
                {
                    categoryManager.UpdateProductSubCategory(tbxEditSubCategory.Text, category.Name);
                    MessageBox.Show("SubCategory updated successfully");
                    UpdateSubCategories();
                }
                else { MessageBox.Show("Oops, something went wrong."); }
            }
            else { MessageBox.Show("SubCategory by that name already exists."); }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
