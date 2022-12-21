namespace DesktopApplication
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.tbxCreateEmail = new System.Windows.Forms.TextBox();
            this.tbxCreatePassword = new System.Windows.Forms.TextBox();
            this.tbxCreateName = new System.Windows.Forms.TextBox();
            this.pnlCreateAccount = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.btn_CreateAccount = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlCreateAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(347, 176);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(156, 23);
            this.tbxEmail.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(347, 215);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(156, 23);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(263, 258);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(117, 23);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(386, 258);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(117, 23);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // tbxCreateEmail
            // 
            this.tbxCreateEmail.Location = new System.Drawing.Point(128, 66);
            this.tbxCreateEmail.Name = "tbxCreateEmail";
            this.tbxCreateEmail.Size = new System.Drawing.Size(139, 23);
            this.tbxCreateEmail.TabIndex = 4;
            // 
            // tbxCreatePassword
            // 
            this.tbxCreatePassword.Location = new System.Drawing.Point(128, 95);
            this.tbxCreatePassword.Name = "tbxCreatePassword";
            this.tbxCreatePassword.Size = new System.Drawing.Size(139, 23);
            this.tbxCreatePassword.TabIndex = 5;
            this.tbxCreatePassword.UseSystemPasswordChar = true;
            // 
            // tbxCreateName
            // 
            this.tbxCreateName.Location = new System.Drawing.Point(128, 37);
            this.tbxCreateName.Name = "tbxCreateName";
            this.tbxCreateName.Size = new System.Drawing.Size(139, 23);
            this.tbxCreateName.TabIndex = 6;
            // 
            // pnlCreateAccount
            // 
            this.pnlCreateAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCreateAccount.Controls.Add(this.btn_Back);
            this.pnlCreateAccount.Controls.Add(this.label4);
            this.pnlCreateAccount.Controls.Add(this.label3);
            this.pnlCreateAccount.Controls.Add(this.label2);
            this.pnlCreateAccount.Controls.Add(this.label1);
            this.pnlCreateAccount.Controls.Add(this.cbxUserType);
            this.pnlCreateAccount.Controls.Add(this.btn_CreateAccount);
            this.pnlCreateAccount.Controls.Add(this.tbxCreatePassword);
            this.pnlCreateAccount.Controls.Add(this.tbxCreateName);
            this.pnlCreateAccount.Controls.Add(this.tbxCreateEmail);
            this.pnlCreateAccount.Location = new System.Drawing.Point(240, 89);
            this.pnlCreateAccount.Name = "pnlCreateAccount";
            this.pnlCreateAccount.Size = new System.Drawing.Size(303, 206);
            this.pnlCreateAccount.TabIndex = 7;
            this.pnlCreateAccount.Visible = false;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(33, 167);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(56, 23);
            this.btn_Back.TabIndex = 13;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Employee Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // cbxUserType
            // 
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "Human Resources",
            "Product Manager",
            "Order Manager",
            "Marketing Manager"});
            this.cbxUserType.Location = new System.Drawing.Point(128, 124);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(139, 23);
            this.cbxUserType.TabIndex = 9;
            // 
            // btn_CreateAccount
            // 
            this.btn_CreateAccount.Location = new System.Drawing.Point(95, 167);
            this.btn_CreateAccount.Name = "btn_CreateAccount";
            this.btn_CreateAccount.Size = new System.Drawing.Size(172, 23);
            this.btn_CreateAccount.TabIndex = 8;
            this.btn_CreateAccount.Text = "Create Account";
            this.btn_CreateAccount.UseVisualStyleBackColor = true;
            this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(263, 184);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(263, 223);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 15);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pnlCreateAccount);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxEmail);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.pnlCreateAccount.ResumeLayout(false);
            this.pnlCreateAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxEmail;
        private TextBox tbxPassword;
        private Button btnLogIn;
        private Button btnSignIn;
        private TextBox tbxCreateEmail;
        private TextBox tbxCreatePassword;
        private TextBox tbxCreateName;
        private Panel pnlCreateAccount;
        private Button btn_CreateAccount;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbxUserType;
        private Label lblEmail;
        private Label lblPassword;
        private Button btn_Back;
    }
}