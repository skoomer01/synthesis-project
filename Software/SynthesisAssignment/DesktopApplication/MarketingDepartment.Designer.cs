namespace DesktopApplication
{
    partial class MarketingDepartment
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
            this.dgvMostPopular = new System.Windows.Forms.DataGridView();
            this.dgvLeastPopular = new System.Windows.Forms.DataGridView();
            this.nudMost = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateMostPoppular = new System.Windows.Forms.Button();
            this.btnUpdateLeastPopular = new System.Windows.Forms.Button();
            this.nudLeast = new System.Windows.Forms.NumericUpDown();
            this.lblMarketingManagerUser = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabDiscount = new System.Windows.Forms.TabControl();
            this.tabpAddDiscount = new System.Windows.Forms.TabPage();
            this.tabpRemoveDiscount = new System.Windows.Forms.TabPage();
            this.dgvRemoveDiscount = new System.Windows.Forms.DataGridView();
            this.btnRemoveDiscount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostPopular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeastPopular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeast)).BeginInit();
            this.tabDiscount.SuspendLayout();
            this.tabpAddDiscount.SuspendLayout();
            this.tabpRemoveDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemoveDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostPopular
            // 
            this.dgvMostPopular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostPopular.Location = new System.Drawing.Point(6, 57);
            this.dgvMostPopular.Name = "dgvMostPopular";
            this.dgvMostPopular.RowTemplate.Height = 25;
            this.dgvMostPopular.Size = new System.Drawing.Size(340, 150);
            this.dgvMostPopular.TabIndex = 0;
            // 
            // dgvLeastPopular
            // 
            this.dgvLeastPopular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeastPopular.Location = new System.Drawing.Point(6, 249);
            this.dgvLeastPopular.Name = "dgvLeastPopular";
            this.dgvLeastPopular.RowTemplate.Height = 25;
            this.dgvLeastPopular.Size = new System.Drawing.Size(340, 150);
            this.dgvLeastPopular.TabIndex = 1;
            // 
            // nudMost
            // 
            this.nudMost.Location = new System.Drawing.Point(433, 57);
            this.nudMost.Name = "nudMost";
            this.nudMost.ReadOnly = true;
            this.nudMost.Size = new System.Drawing.Size(131, 23);
            this.nudMost.TabIndex = 2;
            // 
            // btnUpdateMostPoppular
            // 
            this.btnUpdateMostPoppular.Location = new System.Drawing.Point(433, 86);
            this.btnUpdateMostPoppular.Name = "btnUpdateMostPoppular";
            this.btnUpdateMostPoppular.Size = new System.Drawing.Size(158, 23);
            this.btnUpdateMostPoppular.TabIndex = 3;
            this.btnUpdateMostPoppular.Text = "Add popular discount";
            this.btnUpdateMostPoppular.UseVisualStyleBackColor = true;
            this.btnUpdateMostPoppular.Click += new System.EventHandler(this.btnUpdateMostPoppular_Click);
            // 
            // btnUpdateLeastPopular
            // 
            this.btnUpdateLeastPopular.Location = new System.Drawing.Point(433, 278);
            this.btnUpdateLeastPopular.Name = "btnUpdateLeastPopular";
            this.btnUpdateLeastPopular.Size = new System.Drawing.Size(158, 23);
            this.btnUpdateLeastPopular.TabIndex = 5;
            this.btnUpdateLeastPopular.Text = "Add least popular discount";
            this.btnUpdateLeastPopular.UseVisualStyleBackColor = true;
            this.btnUpdateLeastPopular.Click += new System.EventHandler(this.btnUpdateLeastPopular_Click);
            // 
            // nudLeast
            // 
            this.nudLeast.Location = new System.Drawing.Point(433, 249);
            this.nudLeast.Name = "nudLeast";
            this.nudLeast.ReadOnly = true;
            this.nudLeast.Size = new System.Drawing.Size(131, 23);
            this.nudLeast.TabIndex = 4;
            // 
            // lblMarketingManagerUser
            // 
            this.lblMarketingManagerUser.AutoSize = true;
            this.lblMarketingManagerUser.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarketingManagerUser.Location = new System.Drawing.Point(52, 23);
            this.lblMarketingManagerUser.Name = "lblMarketingManagerUser";
            this.lblMarketingManagerUser.Size = new System.Drawing.Size(282, 32);
            this.lblMarketingManagerUser.TabIndex = 6;
            this.lblMarketingManagerUser.Text = "Welcome, <UserName>!";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(6, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(328, 21);
            this.label18.TabIndex = 7;
            this.label18.Text = "Top pick by the users based on favourite votes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Least pick by the users based on favourite votes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(568, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(570, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "%";
            // 
            // tabDiscount
            // 
            this.tabDiscount.Controls.Add(this.tabpAddDiscount);
            this.tabDiscount.Controls.Add(this.tabpRemoveDiscount);
            this.tabDiscount.Location = new System.Drawing.Point(5, 75);
            this.tabDiscount.Name = "tabDiscount";
            this.tabDiscount.SelectedIndex = 0;
            this.tabDiscount.Size = new System.Drawing.Size(805, 438);
            this.tabDiscount.TabIndex = 11;
            // 
            // tabpAddDiscount
            // 
            this.tabpAddDiscount.Controls.Add(this.dgvLeastPopular);
            this.tabpAddDiscount.Controls.Add(this.label3);
            this.tabpAddDiscount.Controls.Add(this.dgvMostPopular);
            this.tabpAddDiscount.Controls.Add(this.label2);
            this.tabpAddDiscount.Controls.Add(this.nudMost);
            this.tabpAddDiscount.Controls.Add(this.label1);
            this.tabpAddDiscount.Controls.Add(this.btnUpdateMostPoppular);
            this.tabpAddDiscount.Controls.Add(this.label18);
            this.tabpAddDiscount.Controls.Add(this.nudLeast);
            this.tabpAddDiscount.Controls.Add(this.btnUpdateLeastPopular);
            this.tabpAddDiscount.Location = new System.Drawing.Point(4, 24);
            this.tabpAddDiscount.Name = "tabpAddDiscount";
            this.tabpAddDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.tabpAddDiscount.Size = new System.Drawing.Size(797, 410);
            this.tabpAddDiscount.TabIndex = 0;
            this.tabpAddDiscount.Text = "Add discount";
            this.tabpAddDiscount.UseVisualStyleBackColor = true;
            // 
            // tabpRemoveDiscount
            // 
            this.tabpRemoveDiscount.Controls.Add(this.dgvRemoveDiscount);
            this.tabpRemoveDiscount.Controls.Add(this.btnRemoveDiscount);
            this.tabpRemoveDiscount.Controls.Add(this.label5);
            this.tabpRemoveDiscount.Location = new System.Drawing.Point(4, 24);
            this.tabpRemoveDiscount.Name = "tabpRemoveDiscount";
            this.tabpRemoveDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.tabpRemoveDiscount.Size = new System.Drawing.Size(797, 410);
            this.tabpRemoveDiscount.TabIndex = 1;
            this.tabpRemoveDiscount.Text = "Remove discount";
            this.tabpRemoveDiscount.UseVisualStyleBackColor = true;
            // 
            // dgvRemoveDiscount
            // 
            this.dgvRemoveDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemoveDiscount.Location = new System.Drawing.Point(6, 46);
            this.dgvRemoveDiscount.Name = "dgvRemoveDiscount";
            this.dgvRemoveDiscount.RowTemplate.Height = 25;
            this.dgvRemoveDiscount.Size = new System.Drawing.Size(788, 128);
            this.dgvRemoveDiscount.TabIndex = 11;
            // 
            // btnRemoveDiscount
            // 
            this.btnRemoveDiscount.Location = new System.Drawing.Point(185, 240);
            this.btnRemoveDiscount.Name = "btnRemoveDiscount";
            this.btnRemoveDiscount.Size = new System.Drawing.Size(419, 23);
            this.btnRemoveDiscount.TabIndex = 13;
            this.btnRemoveDiscount.Text = "Remove Discount";
            this.btnRemoveDiscount.UseVisualStyleBackColor = true;
            this.btnRemoveDiscount.Click += new System.EventHandler(this.btnRemoveDiscount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Products with discount";
            // 
            // MarketingDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 516);
            this.Controls.Add(this.tabDiscount);
            this.Controls.Add(this.lblMarketingManagerUser);
            this.Name = "MarketingDepartment";
            this.Text = "MarketingDepartment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarketingDepartment_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostPopular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeastPopular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeast)).EndInit();
            this.tabDiscount.ResumeLayout(false);
            this.tabpAddDiscount.ResumeLayout(false);
            this.tabpAddDiscount.PerformLayout();
            this.tabpRemoveDiscount.ResumeLayout(false);
            this.tabpRemoveDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemoveDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMostPopular;
        private DataGridView dgvLeastPopular;
        private NumericUpDown nudMost;
        private Button btnUpdateMostPoppular;
        private Button btnUpdateLeastPopular;
        private NumericUpDown nudLeast;
        private Label lblMarketingManagerUser;
        private Label label18;
        private Label label1;
        private Label label2;
        private Label label3;
        private TabControl tabDiscount;
        private TabPage tabpAddDiscount;
        private TabPage tabpRemoveDiscount;
        private DataGridView dgvRemoveDiscount;
        private Button btnRemoveDiscount;
        private Label label5;
    }
}