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
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Title_Signup = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Rockwell Nova", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(46, 296);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(454, 51);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

            // 
            // label_Title_Signup
            // 
            this.label_Title_Signup.AutoSize = true;
            this.label_Title_Signup.BackColor = System.Drawing.Color.Transparent;
            this.label_Title_Signup.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title_Signup.Location = new System.Drawing.Point(40, 12);
            this.label_Title_Signup.Name = "label_Title_Signup";
            this.label_Title_Signup.Size = new System.Drawing.Size(326, 95);
            this.label_Title_Signup.TabIndex = 9;
            this.label_Title_Signup.Text = "Sign up";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.BackColor = System.Drawing.Color.Transparent;
            this.label_Username.Font = new System.Drawing.Font("Rockwell Nova", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(49, 129);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(180, 44);
            this.label_Username.TabIndex = 10;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Font = new System.Drawing.Font("Rockwell Nova", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(49, 244);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(169, 44);
            this.label_Password.TabIndex = 8;
            this.label_Password.Text = "Password";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("Rockwell Nova", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(46, 182);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(454, 51);
            this.textBox_Username.TabIndex = 1;
            // 
            // button_SignUp
            // 
            this.button_SignUp.BackColor = System.Drawing.Color.Crimson;
            this.button_SignUp.FlatAppearance.BorderSize = 0;
            this.button_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SignUp.ForeColor = System.Drawing.Color.White;
            this.button_SignUp.Location = new System.Drawing.Point(367, 367);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(133, 47);
            this.button_SignUp.TabIndex = 13;
            this.button_SignUp.Text = "Sign up";
            this.button_SignUp.UseVisualStyleBackColor = false;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.pictureBox_Back);
            this.panel1.Controls.Add(this.textBox_Password);
            this.panel1.Controls.Add(this.label_Username);
            this.panel1.Controls.Add(this.button_SignUp);
            this.panel1.Controls.Add(this.label_Title_Signup);
            this.panel1.Controls.Add(this.label_Password);
            this.panel1.Controls.Add(this.textBox_Username);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 447);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Back.Image = global::ClientApp.Properties.Resources.windows_media_player_back_button;
            this.pictureBox_Back.Location = new System.Drawing.Point(541, 0);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Size = new System.Drawing.Size(103, 94);
            this.pictureBox_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Back.TabIndex = 16;
            this.pictureBox_Back.TabStop = false;
            this.pictureBox_Back.Click += new System.EventHandler(this.pictureBox_Back_Click);
            this.pictureBox_Back.MouseEnter += new System.EventHandler(this.pictureBox_Back_MouseEnter);
            this.pictureBox_Back.MouseLeave += new System.EventHandler(this.pictureBox_Back_MouseLeave);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ClientApp.Properties.Resources.Cryptowave_Vaporwave;
            this.ClientSize = new System.Drawing.Size(986, 487);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUpForm";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Title_Signup;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Back;
    }
}