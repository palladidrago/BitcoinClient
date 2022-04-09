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
            (sender as PictureBox).BackColor = Color.Transparent;
        }

        private void labelSignup_Click(object sender, EventArgs e)
        {
            LoginArr loginArr = new LoginArr();
            loginArr.Fill();
            if (loginArr.Count > 0) 
            {
                SignUpForm signUpForm = new SignUpForm(false); //If there are already signups, he's not the admin
                this.Hide();
                signUpForm.ShowDialog();
                this.Close();
            }
            else
            {
                SignUpForm signUpForm = new SignUpForm(true); //If first to sign up, he's the admin
                this.Hide();
                signUpForm.ShowDialog();
                this.Show();
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            LoginClick();
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) { LoginClick(); }
        }
        private void LoginClick()
        {
            //No need to check the form
            string user = textBox_Username.Text;
            string pass = textBox_Password.Text;
            LoginArr loginArr = new LoginArr();
            loginArr.Fill();
            Login login = loginArr.Auth(user, Helpers.sha256(pass)); // Hash the password 

            if (login == null)
            {
                textBox_Username.BackColor = Color.Red;
                textBox_Password.BackColor = Color.Red;
            }
            else if (login.IsAdmin)
            {
                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.ShowDialog();
                this.Close();
            }
            else {
                //Get the client with given login
                ClientArr cArr = new ClientArr();
                cArr.Fill();
                Client client = cArr.GetClientWithLogin(login);
                if (client != null)
                {
                    UserForm userForm = new UserForm();
                    Globals.client = client;
                    this.Hide();
                    userForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    textBox_Username.BackColor = Color.Red;
                    textBox_Password.BackColor = Color.Red;
                    MessageBox.Show("The login you entered doesn't have a corresponding client to it",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
