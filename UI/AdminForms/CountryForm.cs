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
    public partial class CountryForm : Form
    {
        public Country SelectedCountry { get => listBox_Country.SelectedItem as Country; }
        public CountryForm(Country country = null)
        {
            InitializeComponent();
            if (country != null && country.Id <= 0) country = null;
            CountryToForm();
            CountryArrToForm(country); //Fill the listbox
        }
        private void CountryToForm(Country country = null)
        {
            if (country == null) 
            {
                text_Id.Text = "0";
                textBox_Name.Text = "";
            }
            else
            {
                text_Id.Text = country.Id.ToString();
                textBox_Name.Text = country.Name;
            }
        }
        private Country FormToCountry()
        {
            Country country = new Country();
            country.Id = int.Parse(text_Id.Text);
            country.Name = textBox_Name.Text;
            return country;
        }
        private void CountryArrToForm(Country curCountry = null)
        {
            CountryArr countryArr = new CountryArr();
            countryArr.Fill();
            listBox_Country.DataSource = countryArr;
            listBox_Country.ValueMember = "Id";
            listBox_Country.DisplayMember = "Name";
            if (curCountry != null)
                listBox_Country.SelectedValue = curCountry.Id;
        }
        private bool CheckForm()
        {
            bool flag = true;
            if (textBox_Name.Text.Length < 2)
            {
                flag = false;
                textBox_Name.BackColor = Color.Red;
            }
            else
                textBox_Name.BackColor = Color.White;
            return flag;
        }
        private void button_Update_Click(object sender, EventArgs e)
        {
            Country country = FormToCountry();
            CountryArr oldCountryArr = new CountryArr();
            oldCountryArr.Fill();
            if (CheckForm())
            {
                if (!oldCountryArr.IsContains(country.Name))
                {
                    //Check if country already exists
                    if (country.Insert())
                    {
                        //MessageBox.Show("Added successfully :)");

                        //Update listbox

                        CountryArrToForm();
                        CountryToForm(null);

                    }
                    else
                        MessageBox.Show("You did something wrong");

                }
                else
                    MessageBox.Show("Already exist");
            }
            else { MessageBox.Show("Your Country name is too short"); }
            CountryArr countryArr = new CountryArr();
            countryArr.Fill();
            country = countryArr.GetCountryWithMaxId();
            CountryArrToForm(country);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (text_Id.Text == "0")
                MessageBox.Show("You must select a country");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Country country = FormToCountry();

                    //Check that there isn't already a client with that country

                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(country))
                        MessageBox.Show("You can’t delete a country that is related to a client");

                    else if (country.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CountryToForm(null);
                        CountryArrToForm();
                    }
                    else
                        MessageBox.Show("Error");
                }
            }
        }

        private void listBox_Country_Click(object sender, EventArgs e)
        {
            Country selCountry = listBox_Country.SelectedItem as Country;
            CountryToForm(selCountry);
        }


        
        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                button_Update_Click(null, null);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            CountryToForm(null);
        }
    }
}
