namespace DesktopApplication
{
    partial class ProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabcProductManagement = new System.Windows.Forms.TabControl();
            this.tbpViewAllProducts = new System.Windows.Forms.TabPage();
            this.dgvAllProducts = new System.Windows.Forms.DataGridView();
            this.tabpCreateProduct = new System.Windows.Forms.TabPage();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxImage = new System.Windows.Forms.TextBox();
            this.tbxUnit = new System.Windows.Forms.TextBox();
            this.cbxSubCategory = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblAllUsers = new System.Windows.Forms.Label();
            this.tbpEditProduct = new System.Windows.Forms.TabPage();
            this.tabpCategoryManager = new System.Windows.Forms.TabPage();
            this.lblProductManagerUser = new System.Windows.Forms.Label();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dgvEditProducts = new System.Windows.Forms.DataGridView();
            this.tabcProductManagement.SuspendLayout();
            this.tbpViewAllProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).BeginInit();
            this.tabpCreateProduct.SuspendLayout();
            this.tbpEditProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcProductManagement
            // 
            this.tabcProductManagement.Controls.Add(this.tbpViewAllProducts);
            this.tabcProductManagement.Controls.Add(this.tabpCreateProduct);
            this.tabcProductManagement.Controls.Add(this.tbpEditProduct);
            this.tabcProductManagement.Controls.Add(this.tabpCategoryManager);
            this.tabcProductManagement.Location = new System.Drawing.Point(43, 74);
            this.tabcProductManagement.Name = "tabcProductManagement";
            this.tabcProductManagement.SelectedIndex = 0;
            this.tabcProductManagement.Size = new System.Drawing.Size(1147, 527);
            this.tabcProductManagement.TabIndex = 0;
            // 
            // tbpViewAllProducts
            // 
            this.tbpViewAllProducts.Controls.Add(this.dgvAllProducts);
            this.tbpViewAllProducts.Location = new System.Drawing.Point(4, 24);
            this.tbpViewAllProducts.Name = "tbpViewAllProducts";
            this.tbpViewAllProducts.Size = new System.Drawing.Size(1139, 499);
            this.tbpViewAllProducts.TabIndex = 2;
            this.tbpViewAllProducts.Text = "View all  Products";
            this.tbpViewAllProducts.UseVisualStyleBackColor = true;
            // 
            // dgvAllProducts
            // 
            this.dgvAllProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProducts.Location = new System.Drawing.Point(4, 58);
            this.dgvAllProducts.Name = "dgvAllProducts";
            this.dgvAllProducts.RowTemplate.Height = 25;
            this.dgvAllProducts.Size = new System.Drawing.Size(1132, 438);
            this.dgvAllProducts.TabIndex = 0;
            // 
            // tabpCreateProduct
            // 
            this.tabpCreateProduct.Controls.Add(this.btnAddProduct);
            this.tabpCreateProduct.Controls.Add(this.label6);
            this.tabpCreateProduct.Controls.Add(this.label5);
            this.tabpCreateProduct.Controls.Add(this.label4);
            this.tabpCreateProduct.Controls.Add(this.label3);
            this.tabpCreateProduct.Controls.Add(this.label2);
            this.tabpCreateProduct.Controls.Add(this.label1);
            this.tabpCreateProduct.Controls.Add(this.tbxImage);
            this.tabpCreateProduct.Controls.Add(this.tbxUnit);
            this.tabpCreateProduct.Controls.Add(this.cbxSubCategory);
            this.tabpCreateProduct.Controls.Add(this.cbxCategory);
            this.tabpCreateProduct.Controls.Add(this.tbxPrice);
            this.tabpCreateProduct.Controls.Add(this.tbxProductName);
            this.tabpCreateProduct.Controls.Add(this.lblAllUsers);
            this.tabpCreateProduct.Location = new System.Drawing.Point(4, 24);
            this.tabpCreateProduct.Name = "tabpCreateProduct";
            this.tabpCreateProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabpCreateProduct.Size = new System.Drawing.Size(1139, 499);
            this.tabpCreateProduct.TabIndex = 0;
            this.tabpCreateProduct.Text = "Add Product";
            this.tabpCreateProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(443, 332);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(258, 23);
            this.btnAddProduct.TabIndex = 18;
            this.btnAddProduct.Text = "Add new Product to the System";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Product image:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Unit of measurement:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sub-Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product Name:";
            // 
            // tbxImage
            // 
            this.tbxImage.Location = new System.Drawing.Point(580, 277);
            this.tbxImage.Name = "tbxImage";
            this.tbxImage.Size = new System.Drawing.Size(121, 23);
            this.tbxImage.TabIndex = 11;
            // 
            // tbxUnit
            // 
            this.tbxUnit.Location = new System.Drawing.Point(580, 248);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.Size = new System.Drawing.Size(121, 23);
            this.tbxUnit.TabIndex = 10;
            // 
            // cbxSubCategory
            // 
            this.cbxSubCategory.FormattingEnabled = true;
            this.cbxSubCategory.Location = new System.Drawing.Point(580, 190);
            this.cbxSubCategory.Name = "cbxSubCategory";
            this.cbxSubCategory.Size = new System.Drawing.Size(121, 23);
            this.cbxSubCategory.TabIndex = 9;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(580, 161);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 23);
            this.cbxCategory.TabIndex = 8;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(580, 219);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(121, 23);
            this.tbxPrice.TabIndex = 7;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(580, 132);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(121, 23);
            this.tbxProductName.TabIndex = 4;
            // 
            // lblAllUsers
            // 
            this.lblAllUsers.AutoSize = true;
            this.lblAllUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAllUsers.Location = new System.Drawing.Point(18, 32);
            this.lblAllUsers.Name = "lblAllUsers";
            this.lblAllUsers.Size = new System.Drawing.Size(238, 21);
            this.lblAllUsers.TabIndex = 3;
            this.lblAllUsers.Text = "Add a new product to the system";
            // 
            // tbpEditProduct
            // 
            this.tbpEditProduct.Controls.Add(this.dgvEditProducts);
            this.tbpEditProduct.Controls.Add(this.btnEditProduct);
            this.tbpEditProduct.Controls.Add(this.label7);
            this.tbpEditProduct.Controls.Add(this.label8);
            this.tbpEditProduct.Controls.Add(this.label9);
            this.tbpEditProduct.Controls.Add(this.label10);
            this.tbpEditProduct.Controls.Add(this.label11);
            this.tbpEditProduct.Controls.Add(this.label12);
            this.tbpEditProduct.Controls.Add(this.textBox1);
            this.tbpEditProduct.Controls.Add(this.textBox2);
            this.tbpEditProduct.Controls.Add(this.comboBox1);
            this.tbpEditProduct.Controls.Add(this.comboBox2);
            this.tbpEditProduct.Controls.Add(this.textBox3);
            this.tbpEditProduct.Controls.Add(this.textBox4);
            this.tbpEditProduct.Location = new System.Drawing.Point(4, 24);
            this.tbpEditProduct.Name = "tbpEditProduct";
            this.tbpEditProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEditProduct.Size = new System.Drawing.Size(1139, 499);
            this.tbpEditProduct.TabIndex = 1;
            this.tbpEditProduct.Text = "Edit Product";
            this.tbpEditProduct.UseVisualStyleBackColor = true;
            // 
            // tabpCategoryManager
            // 
            this.tabpCategoryManager.Location = new System.Drawing.Point(4, 24);
            this.tabpCategoryManager.Name = "tabpCategoryManager";
            this.tabpCategoryManager.Size = new System.Drawing.Size(1139, 499);
            this.tabpCategoryManager.TabIndex = 3;
            this.tabpCategoryManager.Text = "Category Manager";
            this.tabpCategoryManager.UseVisualStyleBackColor = true;
            // 
            // lblProductManagerUser
            // 
            this.lblProductManagerUser.AutoSize = true;
            this.lblProductManagerUser.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductManagerUser.Location = new System.Drawing.Point(51, 28);
            this.lblProductManagerUser.Name = "lblProductManagerUser";
            this.lblProductManagerUser.Size = new System.Drawing.Size(282, 32);
            this.lblProductManagerUser.TabIndex = 1;
            this.lblProductManagerUser.Text = "Welcome, <UserName>!";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(432, 457);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(258, 23);
            this.btnEditProduct.TabIndex = 31;
            this.btnEditProduct.Text = "Edit product from the system";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Product image:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Unit of measurement:\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Sub-Category:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Category:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(432, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Product Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(569, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(569, 373);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 23);
            this.textBox2.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(569, 315);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 22;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(569, 286);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(569, 344);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 23);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(569, 257);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 23);
            this.textBox4.TabIndex = 19;
            // 
            // dgvEditProducts
            // 
            this.dgvEditProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditProducts.Location = new System.Drawing.Point(3, 52);
            this.dgvEditProducts.Name = "dgvEditProducts";
            this.dgvEditProducts.RowTemplate.Height = 25;
            this.dgvEditProducts.Size = new System.Drawing.Size(1132, 186);
            this.dgvEditProducts.TabIndex = 32;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 629);
            this.Controls.Add(this.lblProductManagerUser);
            this.Controls.Add(this.tabcProductManagement);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.tabcProductManagement.ResumeLayout(false);
            this.tbpViewAllProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).EndInit();
            this.tabpCreateProduct.ResumeLayout(false);
            this.tabpCreateProduct.PerformLayout();
            this.tbpEditProduct.ResumeLayout(false);
            this.tbpEditProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabcProductManagement;
        private TabPage tabpCreateProduct;
        private TabPage tbpEditProduct;
        private Label lblProductManagerUser;
        private Label lblAllUsers;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbxImage;
        private TextBox tbxUnit;
        private ComboBox cbxSubCategory;
        private ComboBox cbxCategory;
        private TextBox tbxPrice;
        private TextBox tbxProductName;
        private TabPage tbpViewAllProducts;
        private DataGridView dgvAllProducts;
        private Button btnAddProduct;
        private TabPage tabpCategoryManager;
        private DataGridView dgvEditProducts;
        private Button btnEditProduct;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}