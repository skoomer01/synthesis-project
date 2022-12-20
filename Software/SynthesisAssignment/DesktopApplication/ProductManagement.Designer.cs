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
            this.label18 = new System.Windows.Forms.Label();
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
            this.label16 = new System.Windows.Forms.Label();
            this.dgvEditProducts = new System.Windows.Forms.DataGridView();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxEditImage = new System.Windows.Forms.TextBox();
            this.tbxEditUnit = new System.Windows.Forms.TextBox();
            this.cbxEditSubCategory = new System.Windows.Forms.ComboBox();
            this.cbxEditCategory = new System.Windows.Forms.ComboBox();
            this.tbxEditPrice = new System.Windows.Forms.TextBox();
            this.tbxEditName = new System.Windows.Forms.TextBox();
            this.tabpDeleteProduct = new System.Windows.Forms.TabPage();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvDeleteProduct = new System.Windows.Forms.DataGridView();
            this.tabpCategoryManager = new System.Windows.Forms.TabPage();
            this.btnEditSubCategory = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxEditSubCategory = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvSubCategory = new System.Windows.Forms.DataGridView();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxEditCategory = new System.Windows.Forms.TextBox();
            this.btnCreateSubcategory = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.tbxNewSubcategory = new System.Windows.Forms.TextBox();
            this.tbxNewCataegory = new System.Windows.Forms.TextBox();
            this.lblProductManagerUser = new System.Windows.Forms.Label();
            this.tabcProductManagement.SuspendLayout();
            this.tbpViewAllProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).BeginInit();
            this.tabpCreateProduct.SuspendLayout();
            this.tbpEditProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditProducts)).BeginInit();
            this.tabpDeleteProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteProduct)).BeginInit();
            this.tabpCategoryManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcProductManagement
            // 
            this.tabcProductManagement.Controls.Add(this.tbpViewAllProducts);
            this.tabcProductManagement.Controls.Add(this.tabpCreateProduct);
            this.tabcProductManagement.Controls.Add(this.tbpEditProduct);
            this.tabcProductManagement.Controls.Add(this.tabpDeleteProduct);
            this.tabcProductManagement.Controls.Add(this.tabpCategoryManager);
            this.tabcProductManagement.Location = new System.Drawing.Point(43, 74);
            this.tabcProductManagement.Name = "tabcProductManagement";
            this.tabcProductManagement.SelectedIndex = 0;
            this.tabcProductManagement.Size = new System.Drawing.Size(1147, 527);
            this.tabcProductManagement.TabIndex = 0;
            // 
            // tbpViewAllProducts
            // 
            this.tbpViewAllProducts.Controls.Add(this.label18);
            this.tbpViewAllProducts.Controls.Add(this.dgvAllProducts);
            this.tbpViewAllProducts.Location = new System.Drawing.Point(4, 24);
            this.tbpViewAllProducts.Name = "tbpViewAllProducts";
            this.tbpViewAllProducts.Size = new System.Drawing.Size(1139, 499);
            this.tbpViewAllProducts.TabIndex = 2;
            this.tbpViewAllProducts.Text = "View all  Products";
            this.tbpViewAllProducts.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(4, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(225, 21);
            this.label18.TabIndex = 4;
            this.label18.Text = "View all products in the system";
            // 
            // dgvAllProducts
            // 
            this.dgvAllProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProducts.Location = new System.Drawing.Point(4, 58);
            this.dgvAllProducts.Name = "dgvAllProducts";
            this.dgvAllProducts.ReadOnly = true;
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
            this.btnAddProduct.Location = new System.Drawing.Point(397, 337);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(317, 23);
            this.btnAddProduct.TabIndex = 18;
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Product image:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Unit of measurement:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sub-Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product Name:";
            // 
            // tbxImage
            // 
            this.tbxImage.Location = new System.Drawing.Point(534, 282);
            this.tbxImage.Name = "tbxImage";
            this.tbxImage.Size = new System.Drawing.Size(180, 23);
            this.tbxImage.TabIndex = 11;
            // 
            // tbxUnit
            // 
            this.tbxUnit.Location = new System.Drawing.Point(534, 253);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.Size = new System.Drawing.Size(180, 23);
            this.tbxUnit.TabIndex = 10;
            // 
            // cbxSubCategory
            // 
            this.cbxSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubCategory.FormattingEnabled = true;
            this.cbxSubCategory.Location = new System.Drawing.Point(534, 195);
            this.cbxSubCategory.Name = "cbxSubCategory";
            this.cbxSubCategory.Size = new System.Drawing.Size(180, 23);
            this.cbxSubCategory.TabIndex = 9;
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(534, 166);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(180, 23);
            this.cbxCategory.TabIndex = 8;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(534, 224);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(180, 23);
            this.tbxPrice.TabIndex = 7;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(534, 137);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(180, 23);
            this.tbxProductName.TabIndex = 4;
            // 
            // lblAllUsers
            // 
            this.lblAllUsers.AutoSize = true;
            this.lblAllUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAllUsers.Location = new System.Drawing.Point(6, 13);
            this.lblAllUsers.Name = "lblAllUsers";
            this.lblAllUsers.Size = new System.Drawing.Size(238, 21);
            this.lblAllUsers.TabIndex = 3;
            this.lblAllUsers.Text = "Add a new product to the system";
            // 
            // tbpEditProduct
            // 
            this.tbpEditProduct.Controls.Add(this.label16);
            this.tbpEditProduct.Controls.Add(this.dgvEditProducts);
            this.tbpEditProduct.Controls.Add(this.btnEditProduct);
            this.tbpEditProduct.Controls.Add(this.label7);
            this.tbpEditProduct.Controls.Add(this.label8);
            this.tbpEditProduct.Controls.Add(this.label9);
            this.tbpEditProduct.Controls.Add(this.label10);
            this.tbpEditProduct.Controls.Add(this.label11);
            this.tbpEditProduct.Controls.Add(this.label12);
            this.tbpEditProduct.Controls.Add(this.tbxEditImage);
            this.tbpEditProduct.Controls.Add(this.tbxEditUnit);
            this.tbpEditProduct.Controls.Add(this.cbxEditSubCategory);
            this.tbpEditProduct.Controls.Add(this.cbxEditCategory);
            this.tbpEditProduct.Controls.Add(this.tbxEditPrice);
            this.tbpEditProduct.Controls.Add(this.tbxEditName);
            this.tbpEditProduct.Location = new System.Drawing.Point(4, 24);
            this.tbpEditProduct.Name = "tbpEditProduct";
            this.tbpEditProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEditProduct.Size = new System.Drawing.Size(1139, 499);
            this.tbpEditProduct.TabIndex = 1;
            this.tbpEditProduct.Text = "Edit Product";
            this.tbpEditProduct.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(6, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(289, 21);
            this.label16.TabIndex = 33;
            this.label16.Text = "Edit an existing product from the system";
            // 
            // dgvEditProducts
            // 
            this.dgvEditProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditProducts.Location = new System.Drawing.Point(3, 52);
            this.dgvEditProducts.Name = "dgvEditProducts";
            this.dgvEditProducts.ReadOnly = true;
            this.dgvEditProducts.RowTemplate.Height = 25;
            this.dgvEditProducts.Size = new System.Drawing.Size(1132, 186);
            this.dgvEditProducts.TabIndex = 32;
            this.dgvEditProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditProducts_CellClick);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(432, 457);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(258, 23);
            this.btnEditProduct.TabIndex = 31;
            this.btnEditProduct.Text = "Editt product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
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
            // tbxEditImage
            // 
            this.tbxEditImage.Location = new System.Drawing.Point(569, 402);
            this.tbxEditImage.Name = "tbxEditImage";
            this.tbxEditImage.Size = new System.Drawing.Size(121, 23);
            this.tbxEditImage.TabIndex = 24;
            // 
            // tbxEditUnit
            // 
            this.tbxEditUnit.Location = new System.Drawing.Point(569, 373);
            this.tbxEditUnit.Name = "tbxEditUnit";
            this.tbxEditUnit.Size = new System.Drawing.Size(121, 23);
            this.tbxEditUnit.TabIndex = 23;
            // 
            // cbxEditSubCategory
            // 
            this.cbxEditSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditSubCategory.FormattingEnabled = true;
            this.cbxEditSubCategory.Location = new System.Drawing.Point(569, 315);
            this.cbxEditSubCategory.Name = "cbxEditSubCategory";
            this.cbxEditSubCategory.Size = new System.Drawing.Size(121, 23);
            this.cbxEditSubCategory.TabIndex = 22;
            // 
            // cbxEditCategory
            // 
            this.cbxEditCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditCategory.FormattingEnabled = true;
            this.cbxEditCategory.Location = new System.Drawing.Point(569, 286);
            this.cbxEditCategory.Name = "cbxEditCategory";
            this.cbxEditCategory.Size = new System.Drawing.Size(121, 23);
            this.cbxEditCategory.TabIndex = 21;
            this.cbxEditCategory.SelectedIndexChanged += new System.EventHandler(this.cbxEditCategory_SelectedIndexChanged);
            // 
            // tbxEditPrice
            // 
            this.tbxEditPrice.Location = new System.Drawing.Point(569, 344);
            this.tbxEditPrice.Name = "tbxEditPrice";
            this.tbxEditPrice.Size = new System.Drawing.Size(121, 23);
            this.tbxEditPrice.TabIndex = 20;
            // 
            // tbxEditName
            // 
            this.tbxEditName.Location = new System.Drawing.Point(569, 257);
            this.tbxEditName.Name = "tbxEditName";
            this.tbxEditName.Size = new System.Drawing.Size(121, 23);
            this.tbxEditName.TabIndex = 19;
            // 
            // tabpDeleteProduct
            // 
            this.tabpDeleteProduct.Controls.Add(this.btnDeleteProduct);
            this.tabpDeleteProduct.Controls.Add(this.label20);
            this.tabpDeleteProduct.Controls.Add(this.dgvDeleteProduct);
            this.tabpDeleteProduct.Location = new System.Drawing.Point(4, 24);
            this.tabpDeleteProduct.Name = "tabpDeleteProduct";
            this.tabpDeleteProduct.Size = new System.Drawing.Size(1139, 499);
            this.tabpDeleteProduct.TabIndex = 4;
            this.tabpDeleteProduct.Text = "Delete Product";
            this.tabpDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(388, 379);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(317, 23);
            this.btnDeleteProduct.TabIndex = 36;
            this.btnDeleteProduct.Text = "Mark as unaivalable";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(3, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(289, 21);
            this.label20.TabIndex = 35;
            this.label20.Text = "Edit an existing product from the system";
            // 
            // dgvDeleteProduct
            // 
            this.dgvDeleteProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeleteProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteProduct.Location = new System.Drawing.Point(0, 52);
            this.dgvDeleteProduct.Name = "dgvDeleteProduct";
            this.dgvDeleteProduct.ReadOnly = true;
            this.dgvDeleteProduct.RowTemplate.Height = 25;
            this.dgvDeleteProduct.Size = new System.Drawing.Size(1132, 186);
            this.dgvDeleteProduct.TabIndex = 34;
            // 
            // tabpCategoryManager
            // 
            this.tabpCategoryManager.Controls.Add(this.btnEditSubCategory);
            this.tabpCategoryManager.Controls.Add(this.label19);
            this.tabpCategoryManager.Controls.Add(this.tbxEditSubCategory);
            this.tabpCategoryManager.Controls.Add(this.label17);
            this.tabpCategoryManager.Controls.Add(this.dgvSubCategory);
            this.tabpCategoryManager.Controls.Add(this.btnEditCategory);
            this.tabpCategoryManager.Controls.Add(this.label15);
            this.tabpCategoryManager.Controls.Add(this.tbxEditCategory);
            this.tabpCategoryManager.Controls.Add(this.btnCreateSubcategory);
            this.tabpCategoryManager.Controls.Add(this.btnCreateCategory);
            this.tabpCategoryManager.Controls.Add(this.label14);
            this.tabpCategoryManager.Controls.Add(this.label13);
            this.tabpCategoryManager.Controls.Add(this.dgvCategory);
            this.tabpCategoryManager.Controls.Add(this.tbxNewSubcategory);
            this.tabpCategoryManager.Controls.Add(this.tbxNewCataegory);
            this.tabpCategoryManager.Location = new System.Drawing.Point(4, 24);
            this.tabpCategoryManager.Name = "tabpCategoryManager";
            this.tabpCategoryManager.Size = new System.Drawing.Size(1139, 499);
            this.tabpCategoryManager.TabIndex = 3;
            this.tabpCategoryManager.Text = "Category Manager";
            this.tabpCategoryManager.UseVisualStyleBackColor = true;
            // 
            // btnEditSubCategory
            // 
            this.btnEditSubCategory.Location = new System.Drawing.Point(203, 432);
            this.btnEditSubCategory.Name = "btnEditSubCategory";
            this.btnEditSubCategory.Size = new System.Drawing.Size(177, 23);
            this.btnEditSubCategory.TabIndex = 37;
            this.btnEditSubCategory.Text = "Edit";
            this.btnEditSubCategory.UseVisualStyleBackColor = true;
            this.btnEditSubCategory.Click += new System.EventHandler(this.btnEditSubCategory_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(203, 385);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(159, 15);
            this.label19.TabIndex = 36;
            this.label19.Text = "Edit an existing Subcategory:";
            // 
            // tbxEditSubCategory
            // 
            this.tbxEditSubCategory.Location = new System.Drawing.Point(203, 403);
            this.tbxEditSubCategory.Name = "tbxEditSubCategory";
            this.tbxEditSubCategory.Size = new System.Drawing.Size(177, 23);
            this.tbxEditSubCategory.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(4, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(207, 21);
            this.label17.TabIndex = 34;
            this.label17.Text = "Category management page";
            // 
            // dgvSubCategory
            // 
            this.dgvSubCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategory.Location = new System.Drawing.Point(543, 258);
            this.dgvSubCategory.Name = "dgvSubCategory";
            this.dgvSubCategory.ReadOnly = true;
            this.dgvSubCategory.RowTemplate.Height = 25;
            this.dgvSubCategory.Size = new System.Drawing.Size(409, 125);
            this.dgvSubCategory.TabIndex = 10;
            this.dgvSubCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubCategory_CellClick);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(203, 339);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(177, 23);
            this.btnEditCategory.TabIndex = 9;
            this.btnEditCategory.Text = "Edit";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(203, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "Edit an existing Category:\r\n";
            // 
            // tbxEditCategory
            // 
            this.tbxEditCategory.Location = new System.Drawing.Point(203, 310);
            this.tbxEditCategory.Name = "tbxEditCategory";
            this.tbxEditCategory.Size = new System.Drawing.Size(177, 23);
            this.tbxEditCategory.TabIndex = 7;
            // 
            // btnCreateSubcategory
            // 
            this.btnCreateSubcategory.Location = new System.Drawing.Point(203, 258);
            this.btnCreateSubcategory.Name = "btnCreateSubcategory";
            this.btnCreateSubcategory.Size = new System.Drawing.Size(177, 23);
            this.btnCreateSubcategory.TabIndex = 6;
            this.btnCreateSubcategory.Text = "Create a subcategory";
            this.btnCreateSubcategory.UseVisualStyleBackColor = true;
            this.btnCreateSubcategory.Click += new System.EventHandler(this.btnCreateSubcategory_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Location = new System.Drawing.Point(203, 151);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(177, 23);
            this.btnCreateCategory.TabIndex = 5;
            this.btnCreateCategory.Text = "Create a category";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(203, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(232, 30);
            this.label14.TabIndex = 4;
            this.label14.Text = "Add a new subcategory for a category\r\nFirst select an existing category to add it" +
    " to\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(203, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Add a new category for the products:";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(543, 101);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowTemplate.Height = 25;
            this.dgvCategory.Size = new System.Drawing.Size(409, 125);
            this.dgvCategory.TabIndex = 2;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // tbxNewSubcategory
            // 
            this.tbxNewSubcategory.Location = new System.Drawing.Point(203, 229);
            this.tbxNewSubcategory.Name = "tbxNewSubcategory";
            this.tbxNewSubcategory.Size = new System.Drawing.Size(177, 23);
            this.tbxNewSubcategory.TabIndex = 1;
            // 
            // tbxNewCataegory
            // 
            this.tbxNewCataegory.Location = new System.Drawing.Point(203, 122);
            this.tbxNewCataegory.Name = "tbxNewCataegory";
            this.tbxNewCataegory.Size = new System.Drawing.Size(177, 23);
            this.tbxNewCataegory.TabIndex = 0;
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
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 629);
            this.Controls.Add(this.lblProductManagerUser);
            this.Controls.Add(this.tabcProductManagement);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductManagement_FormClosed);
            this.tabcProductManagement.ResumeLayout(false);
            this.tbpViewAllProducts.ResumeLayout(false);
            this.tbpViewAllProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).EndInit();
            this.tabpCreateProduct.ResumeLayout(false);
            this.tabpCreateProduct.PerformLayout();
            this.tbpEditProduct.ResumeLayout(false);
            this.tbpEditProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditProducts)).EndInit();
            this.tabpDeleteProduct.ResumeLayout(false);
            this.tabpDeleteProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteProduct)).EndInit();
            this.tabpCategoryManager.ResumeLayout(false);
            this.tabpCategoryManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
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
        private TextBox tbxEditImage;
        private TextBox tbxEditUnit;
        private ComboBox cbxEditSubCategory;
        private ComboBox cbxEditCategory;
        private TextBox tbxEditPrice;
        private TextBox tbxEditName;
        private Label label18;
        private Label label16;
        private Label label17;
        private DataGridView dgvSubCategory;
        private Button btnEditCategory;
        private Label label15;
        private TextBox tbxEditCategory;
        private Button btnCreateSubcategory;
        private Button btnCreateCategory;
        private Label label14;
        private Label label13;
        private DataGridView dgvCategory;
        private TextBox tbxNewSubcategory;
        private TextBox tbxNewCataegory;
        private Button btnEditSubCategory;
        private Label label19;
        private TextBox tbxEditSubCategory;
        private TabPage tabpDeleteProduct;
        private Button btnDeleteProduct;
        private Label label20;
        private DataGridView dgvDeleteProduct;
    }
}