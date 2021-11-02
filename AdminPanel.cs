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
    public partial class AdminPanel : Form
    {
        Client client;
        private void ClientArrToForm()
        {
            ClientArr cArr = new ClientArr();
            cArr.Fill();
            userListBox.DataSource = cArr;
        }
        private void ClientToForm(Client client)
        {
            if (client != null)
            {
                text_Id.Text = client.id.ToString();
                textBox_FirstName.Text = client.firstName.Trim();
                textBox_LastName.Text = client.lastName.Trim();
                textBox_BirthYear.Text = client.birthYear.ToString();
                textBox_PhoneNumber.Text = client.phoneNumber;
                textBox_BtcAddress.Text = client.btcAddress.ToString();
                textBox_BtcAmount.Text = client.btcAmount.ToString();
                textBox_ShoeSize.Text = client.shoeSize.ToString();
            }
            else
            {
                text_Id.Text = "0";
                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_BirthYear.Text = "0";
                textBox_PhoneNumber.Text = "";
                textBox_BtcAddress.Text = "";
                textBox_BtcAmount.Text = "0";
                textBox_ShoeSize.Text = "0";
            }
        }
        private Client FormToClient()
        {
            //Turn the form into a client
            Client client = new Client();
            client.id = int.Parse(text_Id.Text);
            client.firstName = textBox_FirstName.Text;
            client.lastName = textBox_LastName.Text;
            client.phoneNumber = textBox_PhoneNumber.Text;
            client.birthYear = int.Parse(textBox_BirthYear.Text);
            client.btcAmount = double.Parse(textBox_BtcAmount.Text);
            client.btcAddress = textBox_BtcAddress.Text;
            client.shoeSize = int.Parse(textBox_ShoeSize.Text);
            return client;
        }
        public AdminPanel()
        {
            InitializeComponent();
            ClientArrToForm();
            ClientToForm(null);
        }
        private void userListBox_Client_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(userListBox.SelectedItem as Client);
            client = userListBox.SelectedItem as Client;
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
        private void doneButton_Click(object sender, EventArgs e)
        {

            if (CheckForm())
            {
                client = FormToClient();
                if (client.id == 0)
                {
                    if (client.Insert())
                    {
                        MessageBox.Show("Added successfully","Success");
                    }
                    else MessageBox.Show("Something gone wrong wid da adding bruh ;(","Fail");
                }
                else
                {
                    if (client.Update())
                    {
                        MessageBox.Show("Updated successfully","Success");
                        ClientArrToForm();
                    }
                    else MessageBox.Show("Ayo something don gon wron wid da updating kind sir ;)","Fail");
                }
                ClientArrToForm();
            }
            else MessageBox.Show("Ayo u done some wron in the form bro check that stuff for accuracy man this stuff is crucial life or death, you catch my breeze?","You freeked up man");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClientToForm(null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            client = FormToClient();
            if (client.id == 0)
                MessageBox.Show("You need to choose a client");
            else
            {
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (client.Delete()) MessageBox.Show("Deleted Successfully", "Success");
                    else MessageBox.Show("Somtin gon wrong in deletion bro sorry", "Fail");
                    ClientToForm(null);
                    ClientArrToForm();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
