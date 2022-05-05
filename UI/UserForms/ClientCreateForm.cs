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
    public partial class ClientCreateForm : Form
    {
        Login login;
        Client clientToUpdate;
        public ClientCreateForm(Login login = null, Client clientToUpdate = null)
        {
            InitializeComponent();
            CountryArrToForm();
            this.login = login;
            this.clientToUpdate = clientToUpdate;
            if (clientToUpdate != null)
            {
                ClientToForm(clientToUpdate);
            }
        }
        private void ClientToForm(Client c)
        {
            Client client = new Client();
            textBox_FirstName.Text = c.FirstName;
            textBox_LastName.Text = c.LastName;
            textBox_Mail.Text = c.Mail;
            textBox_BirthYear.Text = c.BirthYear.ToString();
            textBox_BtcAmount.Text = c.BtcAmount.ToString();
            textBox_BtcAddress.Text = c.BtcAddress;
            comboBox_Country.SelectedValue = c.Country.Id;
        }
        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

        private bool IsEngLetter(char c)
        {
            //Is it an english letter?
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        private void Form_Client_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en_us")
            {
                MessageBox.Show("You changed your input language, no hebrew please");
            }
        }
        private void textBox_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //When key pressed, check that it is text and english
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' )
                e.KeyChar = char.MinValue;
        }

        private void textBox_MailText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //When key pressed, check that it is text and english
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '@' && e.KeyChar != '.')
                e.KeyChar = char.MinValue;
        }

        private Client FormToClient()
        {
            //Turn the form into a client
            Client client = new Client();
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.Mail = textBox_Mail.Text;
            client.BirthYear = int.Parse(textBox_BirthYear.Text);
            client.BtcAmount = double.Parse(textBox_BtcAmount.Text);
            client.BtcAddress = textBox_BtcAddress.Text;
            client.Country = comboBox_Country.SelectedItem as Country;


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
            int age = 0;
            try
            {
                age = DateTime.Now.Year - Convert.ToInt32(textBox_BirthYear.Text);
            }
            catch 
            {
                flag = false; MessageBox.Show("Year is not a number"); 
            }
            if (age >=18 && age <=120)
            {
                textBox_BirthYear.BackColor = Color.White;
            }
            else
            {
                textBox_BirthYear.BackColor = Color.Red;
                flag = false;
            }
            #endregion 

            #region Mail
            string pattern =
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9]" +
                @"(?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"; //RFC2822 mail validation
            Regex rg = new Regex(pattern);
            if (!rg.IsMatch(textBox_Mail.Text))
            {
                flag = false;
                textBox_Mail.BackColor = Color.Red;
            }
            else
                textBox_Mail.BackColor = Color.White;
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
            return flag;
        }
        private void doneButton_Click(object sender,EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Please fix your errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Client client = FormToClient();
                if (login.Insert()) //First insert the login
                {
                    LoginArr loginArr = new LoginArr();
                    loginArr.Fill();
                    login = loginArr.GetLoginWithMaxId();
                    client.Login = login; //Insert the login with the id
                    if (clientToUpdate == null)
                    {
                        if (client.Insert())
                        {
                            MessageBox.Show("Added successfully");
                            Globals.client = client;
                            UserForm userForm = new UserForm();
                            this.Hide();
                            userForm.ShowDialog();
                            this.Close();
                        }
                        else MessageBox.Show("There was an error inserting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (client.Update())
                        {
                            MessageBox.Show("Updated successfully");
                            Globals.client = client;
                            this.Close(); //UserForm sent us so we will go back to it when done
                        }
                        else MessageBox.Show("There was an error updating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
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
        private void button_AddCountry_Click(object sender, EventArgs e)
        {
            CountryForm countryForm = new CountryForm(comboBox_Country.SelectedItem as Country);

            countryForm.ShowDialog();

            CountryArrToForm(countryForm.SelectedCountry);

        }
    }
}