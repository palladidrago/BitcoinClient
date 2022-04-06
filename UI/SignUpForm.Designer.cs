namespace ClientApp.UI
{
    partial class SignUpForm
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
            this.label_DontHaveAccount = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Title_Signup = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Signup = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DontHaveAccount
            // 
            this.label_DontHaveAccount.AutoSize = true;
            this.label_DontHaveAccount.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DontHaveAccount.Location = new System.Drawing.Point(40, 463);
            this.label_DontHaveAccount.Name = "label_DontHaveAccount";
            this.label_DontHaveAccount.Size = new System.Drawing.Size(356, 34);
            this.label_DontHaveAccount.TabIndex = 7;
            this.label_DontHaveAccount.Text = "Don\'t Have an Account?";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(46, 296);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(454, 48);
            this.textBox_Password.TabIndex = 11;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label_Title_Signup
            // 
            this.label_Title_Signup.AutoSize = true;
            this.label_Title_Signup.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title_Signup.Location = new System.Drawing.Point(40, 12);
            this.label_Title_Signup.Name = "label_Title_Signup";
            this.label_Title_Signup.Size = new System.Drawing.Size(325, 93);
            this.label_Title_Signup.TabIndex = 9;
            this.label_Title_Signup.Text = "Sign up";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(49, 129);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(176, 40);
            this.label_Username.TabIndex = 10;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(49, 244);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(169, 40);
            this.label_Password.TabIndex = 8;
            this.label_Password.Text = "Password";
            // 
            // label_Signup
            // 
            this.label_Signup.AutoSize = true;
            this.label_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Signup.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Signup.ForeColor = System.Drawing.Color.Crimson;
            this.label_Signup.Location = new System.Drawing.Point(320, 465);
            this.label_Signup.Name = "label_Signup";
            this.label_Signup.Size = new System.Drawing.Size(115, 34);
            this.label_Signup.TabIndex = 6;
            this.label_Signup.Text = "Sign up";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(46, 182);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(454, 48);
            this.textBox_Username.TabIndex = 12;
            this.textBox_Username.Text = " ";
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Crimson;
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(367, 367);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(133, 47);
            this.button_Login.TabIndex = 13;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(200, ((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.textBox_Password);
            this.panel1.Controls.Add(this.label_Username);
            this.panel1.Controls.Add(this.button_Login);
            this.panel1.Controls.Add(this.label_Title_Signup);
            this.panel1.Controls.Add(this.label_Password);
            this.panel1.Controls.Add(this.textBox_Username);
            this.panel1.Controls.Add(this.label_DontHaveAccount);
            this.panel1.Controls.Add(this.label_Signup);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 519);
            this.panel1.TabIndex = 15;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1284, 586);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUpForm";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_DontHaveAccount;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Title_Signup;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Signup;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Panel panel1;
    }
}