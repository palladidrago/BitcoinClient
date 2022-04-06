using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace ClientApp.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox_Shutoff_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox_Shutoff_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Azure;
        }

        private void pictureBox_Shutoff_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = this.BackColor;
        }

        private void labelSignup_Click(object sender, EventArgs e)
        {
            LoginArr loginArr = new LoginArr();
            loginArr.Fill();
            if (loginArr.Count > 0) 
            {
                SignUpForm signUpForm = new SignUpForm(false); //If first to sign up, he's the admin
                this.Hide();
                signUpForm.ShowDialog();
                this.Show();
            }
            else
            {
                SignUpForm signUpForm = new SignUpForm(false); //If first to sign up, he's the admin
                this.Hide();
                signUpForm.ShowDialog();
                this.Show();
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //No need to check the form
            string user = textBox_Username.Text;
            string pass = textBox_Password.Text;
            LoginArr loginArr = new LoginArr();
            loginArr.Fill();
            Login login = loginArr.Auth(user, Helpers.sha256(pass)); // Hash the password 

            if (login == null) {
                textBox_Username.BackColor = Color.Red; 
                textBox_Password.BackColor = Color.Red; 
            }
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }
    }
}
