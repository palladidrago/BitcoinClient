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
using ClientApp.UI;

namespace ClientApp
{
    public partial class ClientForm : Form
    {
        Client client;
        public ClientForm()
        {
            InitializeComponent();
            ClientArrToForm(); //For the list box fill in
            CityArrToForm(); // For the combo box fill in
            ClientToForm(); //For the actual form fill in
            
        }
        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check if is number
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }
        private void textBox_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //When key pressed, check that it is text and english
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }
        private bool IsEngLetter(char c)
        {
            //Is it an english letter?
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        private void Form_Client_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            //If input language changed, issue warning
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en_us")
            {
                MessageBox.Show("U changed your language bro, look out, no hebrew pls");
            }
        }

        public void CityArrToForm(City curCity = null)
        {
            //From city array to form 
            CityArr cityArr = new CityArr();
            City cityDefault = new City();
            cityDefault.Id = -1;
            cityDefault.Name = "Choose a city";


            cityArr.Add(cityDefault);
            cityArr.Fill();

            comboBox_City.DataSource = cityArr;
            comboBox_City.ValueMember = "Id";
            comboBox_City.DisplayMember = "Name";
            if (curCity != null)
                comboBox_City.SelectedValue = curCity.Id;

        }
        private void ClientArrToForm()
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Client.DataSource = clientArr;
        }
        private void ClientToForm(Client client = null)
        {
            if (client != null)
            {
                text_Id.Text = client.Id.ToString();
                textBox_FirstName.Text = client.FirstName.Trim();
                textBox_LastName.Text = client.LastName.Trim();
                textBox_BirthYear.Text = client.BirthYear.ToString();
                textBox_PhoneNumber.Text = client.PhoneNumber;
                textBox_BtcAddress.Text = client.BtcAddress.ToString();
                textBox_BtcAmount.Text = client.BtcAmount.ToString();
                textBox_ShoeSize.Text = client.ShoeSize.ToString();
                //City
                comboBox_City.SelectedValue = client.city.Id;
                comboBox_City.SelectedItem = client;  
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
            client.Id = int.Parse(text_Id.Text);
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.PhoneNumber = textBox_PhoneNumber.Text;
            client.BirthYear = int.Parse(textBox_BirthYear.Text);
            client.BtcAmount = double.Parse(textBox_BtcAmount.Text);
            client.BtcAddress = textBox_BtcAddress.Text;
            client.ShoeSize = int.Parse(textBox_ShoeSize.Text);
            client.city = comboBox_City.SelectedItem as City;
            return client;
        }

        private void clientListBox_Client_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Client.SelectedItem as Client);
            client = listBox_Client.SelectedItem as Client;
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
            #endregion 

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

            #region City
            if ((int)comboBox_City.SelectedValue <= 0)
            {
                flag = false;
                comboBox_City.ForeColor = Color.Red;
            }
            else comboBox_City.ForeColor = Color.Black;

            #endregion
            return flag;
        }
        private void doneButton_Click(object sender, EventArgs e)
        {

            if (CheckForm())
            {
                client = FormToClient();
                if (client.Id == 0)
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
            else MessageBox.Show(
"Ayo u done some wron in the form bro check that stuff for accuracy man this stuff is crucial life or death, you catch my breeze?"
            ,"You freeked up man");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClientToForm(null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            client = FormToClient();
            if (client.Id == 0)
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
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {

            //Create an array of all clients

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //Filter the list of clients according to requests

            clientArr = clientArr.Filter(lastName: textBox_Filter_LastName.Text,
            btcAddress: textBox_Filter_BtcAddress.Text);

            //Put requests in listbox

            listBox_Client.DataSource = clientArr;
        }

        private void button_AddCity_Click(object sender, EventArgs e)
        {
            CityForm cityForm = new CityForm(comboBox_City.SelectedItem as City);

            cityForm.ShowDialog();

            CityArrToForm(cityForm.SelectedCity);

        }

    }
}
