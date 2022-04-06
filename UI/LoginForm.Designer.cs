using System.Media;
using System.Drawing;
namespace ClientApp.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_Title_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_DontHaveAccount = new System.Windows.Forms.Label();
            this.label_Signup = new System.Windows.Forms.Label();
            this.pictureBox_Shutoff = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Shutoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(21, 120);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(176, 40);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "Username";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(18, 173);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(454, 48);
            this.textBox_Username.TabIndex = 2;
            this.textBox_Username.Text = " ";
            this.textBox_Username.Click += new System.EventHandler(this.textBox_Click);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Crimson;
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(339, 358);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(133, 47);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_Title_Login
            // 
            this.label_Title_Login.AutoSize = true;
            this.label_Title_Login.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title_Login.Location = new System.Drawing.Point(192, 9);
            this.label_Title_Login.Name = "label_Title_Login";
            this.label_Title_Login.Size = new System.Drawing.Size(246, 93);
            this.label_Title_Login.TabIndex = 1;
            this.label_Title_Login.Text = "Login";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(21, 235);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(169, 40);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(18, 287);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(454, 48);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.Click += new System.EventHandler(this.textBox_Click);
            // 
            // label_DontHaveAccount
            // 
            this.label_DontHaveAccount.AutoSize = true;
            this.label_DontHaveAccount.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DontHaveAccount.Location = new System.Drawing.Point(12, 454);
            this.label_DontHaveAccount.Name = "label_DontHaveAccount";
            this.label_DontHaveAccount.Size = new System.Drawing.Size(356, 34);
            this.label_DontHaveAccount.TabIndex = 1;
            this.label_DontHaveAccount.Text = "Don\'t Have an Account?";
            // 
            // label_Signup
            // 
            this.label_Signup.AutoSize = true;
            this.label_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Signup.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Signup.ForeColor = System.Drawing.Color.Crimson;
            this.label_Signup.Location = new System.Drawing.Point(292, 456);
            this.label_Signup.Name = "label_Signup";
            this.label_Signup.Size = new System.Drawing.Size(115, 34);
            this.label_Signup.TabIndex = 1;
            this.label_Signup.Text = "Sign up";
            this.label_Signup.Click += new System.EventHandler(this.labelSignup_Click);
            // 
            // pictureBox_Shutoff
            // 
            this.pictureBox_Shutoff.Image = global::ClientApp.Properties.Resources.power_power_off_power_on_turn_off_turn_on_icon_189248;
            this.pictureBox_Shutoff.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Shutoff.Name = "pictureBox_Shutoff";
            this.pictureBox_Shutoff.Size = new System.Drawing.Size(103, 94);
            this.pictureBox_Shutoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Shutoff.TabIndex = 4;
            this.pictureBox_Shutoff.TabStop = false;
            this.pictureBox_Shutoff.Click += new System.EventHandler(this.pictureBox_Shutoff_Click);
            this.pictureBox_Shutoff.MouseEnter += new System.EventHandler(this.pictureBox_Shutoff_MouseEnter);
            this.pictureBox_Shutoff.MouseLeave += new System.EventHandler(this.pictureBox_Shutoff_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ClientApp.Properties.Resources.ezgif_3_53a814fc9c;
            this.pictureBox1.Location = new System.Drawing.Point(516, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(896, 497);
            this.Controls.Add(this.pictureBox_Shutoff);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Signup);
            this.Controls.Add(this.label_DontHaveAccount);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Title_Login);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Shutoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_Title_Login;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_DontHaveAccount;
        private System.Windows.Forms.Label label_Signup;
        private System.Windows.Forms.PictureBox pictureBox_Shutoff;
    }
}