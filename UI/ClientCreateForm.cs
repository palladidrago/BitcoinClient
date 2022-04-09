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
    public partial class ClientCreateForm : Form
    {
        Login login;
        public ClientCreateForm(Login login)
        {
            InitializeComponent();
            CityArrToForm();
            this.login = login;
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
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.PhoneNumber = textBox_PhoneNumber.Text;
            client.BirthYear = int.Parse(textBox_BirthYear.Text);
            client.BtcAmount = double.Parse(textBox_BtcAmount.Text);
            client.BtcAddress = textBox_BtcAddress.Text;
            client.ShoeSize = int.Parse(textBox_ShoeSize.Text);
            client.City = comboBox_City.SelectedItem as City;
            client.Login = this.login;


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
        private void doneButton_Click(object sender,EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Please fix your errors comrade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Client client = FormToClient();
                if (client.Insert() && login.Insert())
                {
                    MessageBox.Show("Added successfully");
                    Globals.client = client;
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Close();
                }
                else MessageBox.Show("There was an error inserting", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
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
        private void button_AddCity_Click(object sender, EventArgs e)
        {
            CityForm cityForm = new CityForm(comboBox_City.SelectedItem as City);

            cityForm.ShowDialog();

            CityArrToForm(cityForm.SelectedCity);

        }
    }
}