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

namespace ClientApp
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

        private bool IsEngLetter(char c)
        {
            //Is it an english letter?
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c >= 'Z');
        }

        private void Form_Client_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en_us")
            {
                MessageBox.Show("U changed your language bro, look out, no hebrew pls");
            }
        }
        private void textBox_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //When key pressed, check that it is text and english
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }

        private Client FormToClient()
        {
            //Turn the form into a client
            Client client = new Client();
            client.firstName = textBox_FirstName.Text;
            client.lastName = textBox_LastName.Text;
            client.phoneNumber = textBox_PhoneNumber.Text;
            client.birthYear = int.Parse(textBox_BirthYear.Text);
            client.btcAmount = double.Parse(textBox_BtcAmount.Text);
            client.btcAddress = textBox_BtcAddress.Text;
            client.shoeSize = int.Parse(textBox_ShoeSize.Text);


            return client;
        }
        private bool CheckForm()
        {
            //Check that each of the textboxes on the form are good

            bool flag = true;
            #region FirstName
            if (textBox_FirstName.Text.Length < 2)
            {
                flag = false;
                textBox_FirstName.BackColor = Color.Red;
            }
            else
                textBox_FirstName.BackColor = Color.White;
            #endregion //Check if long enough

            #region LastName
            if (textBox_LastName.Text.Length < 2)
            {
                flag = false;
                textBox_LastName.BackColor = Color.Red;
            }
            else
                textBox_LastName.BackColor = Color.White;
            #endregion 

            #region BirthYear
            if (textBox_BirthYear.Text.Length >= 4)
            {

                try
                {
                    int.Parse(textBox_BirthYear.Text);
                    textBox_ShoeSize.BackColor = Color.White;
                }
                catch
                {
                    textBox_BirthYear.BackColor = Color.Red;
                    flag = false;
                }
            }
            else
            {
                textBox_BirthYear.BackColor = Color.Red;
                flag = false;
            }
            #endregion 

            #region PhoneNumber
            if (textBox_PhoneNumber.Text.Length < 9)
            {
                flag = false;
                textBox_PhoneNumber.BackColor = Color.Red;
            }
            else
                textBox_PhoneNumber.BackColor = Color.White;
            #endregion

            #region BtcAmount
            if (textBox_BtcAmount.Text.Length < 1)
            {
                flag = false;
                textBox_BtcAmount.BackColor = Color.Red;
            }
            else
                textBox_BtcAmount.BackColor = Color.White;
            #endregion

            #region BtcAddress
            if (textBox_BtcAddress.Text.Length < 10)
            {
                textBox_BtcAddress.BackColor = Color.Red;

                flag = false;
            }
            else
                textBox_BtcAddress.BackColor = Color.White;
            #endregion

            #region ShoeSize
            if (textBox_ShoeSize.Text != "")
            {

                try
                {
                    int.Parse(textBox_ShoeSize.Text);
                    textBox_ShoeSize.BackColor = Color.White;
                }
                catch
                {
                    textBox_ShoeSize.BackColor = Color.Red;
                    flag = false;
                }
            }
            else
            {
                textBox_ShoeSize.BackColor = Color.Red;
                flag = false;
            }
                
            #endregion
            return flag;
        }
        private void doneButton_Click(object sender,EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Please fix your errors comrade");
            }
            else
            {
                Client client = FormToClient();
                client.Insert();
                MessageBox.Show("Added successfully");
                beginForm loginForm = new beginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
//TODO: Check that bitcoin address is correct
//TODO: Add all variables