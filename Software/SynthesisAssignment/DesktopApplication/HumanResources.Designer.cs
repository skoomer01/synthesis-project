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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAllUsers = new System.Windows.Forms.Label();
            this.tabcUserManagement.SuspendLayout();
            this.tabpAllUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabcUserManagement.Controls.Add(this.tabPage2);
            this.tabcUserManagement.Location = new System.Drawing.Point(31, 83);
            this.tabcUserManagement.Name = "tabcUserManagement";
            this.tabcUserManagement.SelectedIndex = 0;
            this.tabcUserManagement.Size = new System.Drawing.Size(1176, 534);
            this.tabcUserManagement.TabIndex = 1;
            // 
            // tabpAllUsers
            // 
            this.tabpAllUsers.Controls.Add(this.lblAllUsers);
            this.tabpAllUsers.Controls.Add(this.dataGridView1);
            this.tabpAllUsers.Location = new System.Drawing.Point(4, 24);
            this.tabpAllUsers.Name = "tabpAllUsers";
            this.tabpAllUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabpAllUsers.Size = new System.Drawing.Size(1168, 506);
            this.tabpAllUsers.TabIndex = 0;
            this.tabpAllUsers.Text = "View all users";
            this.tabpAllUsers.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 72);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 429);
            this.dataGridView1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUserNameDisplay;
        private TabControl tabcUserManagement;
        private TabPage tabpAllUsers;
        private Label lblAllUsers;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
    }
}