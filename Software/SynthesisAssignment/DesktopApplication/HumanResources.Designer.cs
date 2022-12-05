namespace DesktopApplication
{
    partial class HumanResources
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
            this.lblUserNameDisplay = new System.Windows.Forms.Label();
            this.tabcUserManagement = new System.Windows.Forms.TabControl();
            this.tabpAllUsers = new System.Windows.Forms.TabPage();
            this.lblAllUsers = new System.Windows.Forms.Label();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.tabpEditUserInfo = new System.Windows.Forms.TabPage();
            this.cbxEditUserType = new System.Windows.Forms.ComboBox();
            this.tbxEditEmail = new System.Windows.Forms.TextBox();
            this.tbxEditName = new System.Windows.Forms.TextBox();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.dgvEditUsers = new System.Windows.Forms.DataGridView();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.lblEditType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabcUserManagement.SuspendLayout();
            this.tabpAllUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.tabpEditUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserNameDisplay
            // 
            this.lblUserNameDisplay.AutoSize = true;
            this.lblUserNameDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserNameDisplay.Location = new System.Drawing.Point(31, 27);
            this.lblUserNameDisplay.Name = "lblUserNameDisplay";
            this.lblUserNameDisplay.Size = new System.Drawing.Size(289, 32);
            this.lblUserNameDisplay.TabIndex = 0;
            this.lblUserNameDisplay.Text = "Welcome, <UserName> !";
            // 
            // tabcUserManagement
            // 
            this.tabcUserManagement.Controls.Add(this.tabpAllUsers);
            this.tabcUserManagement.Controls.Add(this.tabpEditUserInfo);
            this.tabcUserManagement.Location = new System.Drawing.Point(31, 83);
            this.tabcUserManagement.Name = "tabcUserManagement";
            this.tabcUserManagement.SelectedIndex = 0;
            this.tabcUserManagement.Size = new System.Drawing.Size(1176, 534);
            this.tabcUserManagement.TabIndex = 1;
            // 
            // tabpAllUsers
            // 
            this.tabpAllUsers.Controls.Add(this.lblAllUsers);
            this.tabpAllUsers.Controls.Add(this.dgvAllUsers);
            this.tabpAllUsers.Location = new System.Drawing.Point(4, 24);
            this.tabpAllUsers.Name = "tabpAllUsers";
            this.tabpAllUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabpAllUsers.Size = new System.Drawing.Size(1168, 506);
            this.tabpAllUsers.TabIndex = 0;
            this.tabpAllUsers.Text = "View all Users";
            this.tabpAllUsers.UseVisualStyleBackColor = true;
            // 
            // lblAllUsers
            // 
            this.lblAllUsers.AutoSize = true;
            this.lblAllUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAllUsers.Location = new System.Drawing.Point(6, 19);
            this.lblAllUsers.Name = "lblAllUsers";
            this.lblAllUsers.Size = new System.Drawing.Size(165, 21);
            this.lblAllUsers.TabIndex = 2;
            this.lblAllUsers.Text = "All users in the system";
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.Location = new System.Drawing.Point(6, 71);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.RowTemplate.Height = 25;
            this.dgvAllUsers.Size = new System.Drawing.Size(1159, 429);
            this.dgvAllUsers.TabIndex = 0;
            // 
            // tabpEditUserInfo
            // 
            this.tabpEditUserInfo.Controls.Add(this.label1);
            this.tabpEditUserInfo.Controls.Add(this.lblEditType);
            this.tabpEditUserInfo.Controls.Add(this.lblEditEmail);
            this.tabpEditUserInfo.Controls.Add(this.lblEditName);
            this.tabpEditUserInfo.Controls.Add(this.cbxEditUserType);
            this.tabpEditUserInfo.Controls.Add(this.tbxEditEmail);
            this.tabpEditUserInfo.Controls.Add(this.tbxEditName);
            this.tabpEditUserInfo.Controls.Add(this.btnEditUser);
            this.tabpEditUserInfo.Controls.Add(this.dgvEditUsers);
            this.tabpEditUserInfo.Location = new System.Drawing.Point(4, 24);
            this.tabpEditUserInfo.Name = "tabpEditUserInfo";
            this.tabpEditUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabpEditUserInfo.Size = new System.Drawing.Size(1168, 506);
            this.tabpEditUserInfo.TabIndex = 1;
            this.tabpEditUserInfo.Text = "Edit User Info";
            this.tabpEditUserInfo.UseVisualStyleBackColor = true;
            // 
            // cbxEditUserType
            // 
            this.cbxEditUserType.FormattingEnabled = true;
            this.cbxEditUserType.Items.AddRange(new object[] {
            "Human Resources",
            "Product Manager",
            "Customer"});
            this.cbxEditUserType.Location = new System.Drawing.Point(98, 288);
            this.cbxEditUserType.Name = "cbxEditUserType";
            this.cbxEditUserType.Size = new System.Drawing.Size(139, 23);
            this.cbxEditUserType.TabIndex = 10;
            // 
            // tbxEditEmail
            // 
            this.tbxEditEmail.Location = new System.Drawing.Point(98, 246);
            this.tbxEditEmail.Name = "tbxEditEmail";
            this.tbxEditEmail.Size = new System.Drawing.Size(139, 23);
            this.tbxEditEmail.TabIndex = 4;
            // 
            // tbxEditName
            // 
            this.tbxEditName.Location = new System.Drawing.Point(98, 201);
            this.tbxEditName.Name = "tbxEditName";
            this.tbxEditName.Size = new System.Drawing.Size(139, 23);
            this.tbxEditName.TabIndex = 3;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(19, 339);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(218, 23);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Text = "Update user information";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // dgvEditUsers
            // 
            this.dgvEditUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditUsers.Location = new System.Drawing.Point(3, 49);
            this.dgvEditUsers.Name = "dgvEditUsers";
            this.dgvEditUsers.RowTemplate.Height = 25;
            this.dgvEditUsers.Size = new System.Drawing.Size(1159, 136);
            this.dgvEditUsers.TabIndex = 1;
            this.dgvEditUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditUsers_CellClick);
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Location = new System.Drawing.Point(19, 204);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(68, 15);
            this.lblEditName.TabIndex = 11;
            this.lblEditName.Text = "User Name:";
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.AutoSize = true;
            this.lblEditEmail.Location = new System.Drawing.Point(19, 249);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(65, 15);
            this.lblEditEmail.TabIndex = 12;
            this.lblEditEmail.Text = "User Email:";
            // 
            // lblEditType
            // 
            this.lblEditType.AutoSize = true;
            this.lblEditType.Location = new System.Drawing.Point(19, 291);
            this.lblEditType.Name = "lblEditType";
            this.lblEditType.Size = new System.Drawing.Size(60, 15);
            this.lblEditType.TabIndex = 13;
            this.lblEditType.Text = "User Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Editr user data here";
            // 
            // HumanResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 629);
            this.Controls.Add(this.tabcUserManagement);
            this.Controls.Add(this.lblUserNameDisplay);
            this.Name = "HumanResources";
            this.Text = "HumanResources";
            this.tabcUserManagement.ResumeLayout(false);
            this.tabpAllUsers.ResumeLayout(false);
            this.tabpAllUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.tabpEditUserInfo.ResumeLayout(false);
            this.tabpEditUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUserNameDisplay;
        private TabControl tabcUserManagement;
        private TabPage tabpAllUsers;
        private Label lblAllUsers;
        private DataGridView dgvAllUsers;
        private TabPage tabpEditUserInfo;
        private DataGridView dgvEditUsers;
        private TextBox tbxEditEmail;
        private TextBox tbxEditName;
        private Button btnEditUser;
        private ComboBox cbxEditUserType;
        private Label lblEditType;
        private Label lblEditEmail;
        private Label lblEditName;
        private Label label1;
    }
}