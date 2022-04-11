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
    public partial class SignUpForm : Form
    {
        bool isAdmin;
        public Login curLogin { get; set; } //Received login (must be public)
        public SignUpForm(bool isAdmin,Login curLogin = null)
        {
            this.isAdmin = isAdmin;
            this.curLogin = curLogin;
            InitializeComponent();
            if (curLogin != null) { 
                label_Title_Signup.Text = "Update login"; button_SignUp.Text = "Update";
            }
            if (isAdmin) { label_Title_Signup.Text += "(Admin)"; }
        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox_Back_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Azure;
        }

        private void pictureBox_Back_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Transparent;
        }
        private Login FormToLogin()
        {
            Login login = new Login();
            login.Username = textBox_Username.Text;
            login.PasswordHash = Helpers.sha256(textBox_Password.Text);
            login.IsAdmin = isAdmin;
            if (curLogin != null) login.Id = curLogin.Id;
            return login;
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            SignUp();
        }
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return) { SignUp(); }
        }
        private void SignUp()
        {
            
            Login login = FormToLogin(); //Get login info
            //Check if username already exists
            LoginArr lArr = new LoginArr();
            lArr.Fill();
            if (lArr.IsUsernameExists(login.Username))
            {
                textBox_Username.BackColor = Color.Red;
                MessageBox.Show("Username already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                login.Insert();
                lArr = new LoginArr();
                lArr.Fill();
                login = lArr.GetLoginWithMaxId(); //Get the login we just made 
                if (curLogin != null) login.Update(); //If changing an existing login, update
                else if (isAdmin)
                { //If admin go back to login 
                    login.Insert();
                    AdminForm aForm = new AdminForm();
                    aForm.Show();
                    this.Close();
                }
                else //If it's new user
                {

                    ClientCreateForm cForm = new ClientCreateForm(login); //Login will be inserted by client form
                    this.Hide();
                    cForm.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
