using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace ClientApp.UI
{
    public partial class ClientForm : Form
    {
        Client client;
        Login login;

        public ClientForm()
        {
            InitializeComponent();
            ClientArrToForm(); //For the list box fill in
            CountryArrToForm(); // For the combo box fill in
            ClientToForm(); //For the actual form fill in
            button_UpdateLogin.Enabled = false;
            
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

        public void CountryArrToForm(Country curCountry = null)
        {
            //From country array to form 
            CountryArr countryArr = new CountryArr();
            Country countryDefault = new Country();
            countryDefault.Id = -1;
            countryDefault.Name = "Choose a country";


            countryArr.Add(countryDefault);
            countryArr.Fill();

            comboBox_Country.DataSource = countryArr;
            comboBox_Country.ValueMember = "Id";
            comboBox_Country.DisplayMember = "Name";
            if (curCountry != null)
                comboBox_Country.SelectedValue = curCountry.Id;

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
                textBox_Mail.Text = client.Mail;
                textBox_BtcAddress.Text = client.BtcAddress.ToString();
                textBox_BtcAmount.Text = client.BtcAmount.ToString();
                login = client.Login;
                button_UpdateLogin.Enabled = true;


                //Country
                comboBox_Country.SelectedValue = client.Country.Id;
                comboBox_Country.SelectedItem = client.Country;  
            }
            else
            {
                text_Id.Text = "0";
                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_BirthYear.Text = "0";
                textBox_Mail.Text = "";
                textBox_BtcAddress.Text = "";
                textBox_BtcAmount.Text = "0";
                login = null;
                button_UpdateLogin.Enabled = false;

            }
        }
        private Client FormToClient()
        {
            //Turn the form into a client
            Client client = new Client();
            client.Id = int.Parse(text_Id.Text);
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.Mail = textBox_Mail.Text;
            client.BirthYear = int.Parse(textBox_BirthYear.Text);
            client.BtcAmount = double.Parse(textBox_BtcAmount.Text);
            client.BtcAddress = textBox_BtcAddress.Text;
            client.Country = comboBox_Country.SelectedItem as Country;
            client.Login = login;

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
                    textBox_BirthYear.BackColor = Color.White;
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

            #region Mail
            string pattern =
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9]"+
                @"(?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"; //RFC2822 mail validation
            Regex rg = new Regex(pattern);
            if (rg.IsMatch(textBox_Mail.Text))
            {
                textBox_Mail.BackColor = Color.White;
            }
            else
            {
                textBox_Mail.BackColor = Color.Red; flag = false;
            }
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

            
            


            #region Country
            if ((int)comboBox_Country.SelectedValue <= 0)
            {
                flag = false;
                comboBox_Country.ForeColor = Color.Red;
            }
            else comboBox_Country.ForeColor = Color.Black;
            #endregion
            #region Login
            if (login == null)
            {
                flag = false;
                MessageBox.Show("Update the login please");
            }

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
                    else MessageBox.Show("Something went wrong with inserting :(","Fail");
                }
                else
                {
                    if (client.Update())
                    {
                        MessageBox.Show("Updated successfully","Success");
                        ClientArrToForm();
                    }
                    else MessageBox.Show("Something went wrong with updating :(","Fail");
                }
                ClientArrToForm();
            }
            else MessageBox.Show("You made a mistake");
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

        private void button_AddCountry_Click(object sender, EventArgs e)
        {
            CountryForm countryForm = new CountryForm(comboBox_Country.SelectedItem as Country);

            countryForm.ShowDialog();

            CountryArrToForm(countryForm.SelectedCountry);

        }
        private void button_UpdateLogin_Click(object sender, EventArgs e)
        {
            
            SignUpForm signUpForm = new SignUpForm(login.IsAdmin,curLogin: login);

            signUpForm.ShowDialog();

            login = signUpForm.curLogin;



        }
    }
}
