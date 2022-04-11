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
    public partial class CityForm : Form
    {
        public City SelectedCity { get => listBox_City.SelectedItem as City; }
        public CityForm(City city = null)
        {
            InitializeComponent();
            if (city != null && city.Id <= 0) city = null;
            CityToForm();
            CityArrToForm(city); //Fill the listbox
        }
        private void CityToForm(City city = null)
        {
            if (city == null) 
            {
                text_Id.Text = "0";
                textBox_Name.Text = "";
            }
            else
            {
                text_Id.Text = city.Id.ToString();
                textBox_Name.Text = city.Name;
            }
        }
        private City FormToCity()
        {
            City city = new City();
            city.Id = int.Parse(text_Id.Text);
            city.Name = textBox_Name.Text;
            return city;
        }
        private void CityArrToForm(City curCity = null)
        {
            CityArr cityArr = new CityArr();
            cityArr.Fill();
            listBox_City.DataSource = cityArr;
            listBox_City.ValueMember = "Id";
            listBox_City.DisplayMember = "Name";
            if (curCity != null)
                listBox_City.SelectedValue = curCity.Id;
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
            City city = FormToCity();
            CityArr oldCityArr = new CityArr();
            oldCityArr.Fill();
            if (CheckForm())
            {
                if (!oldCityArr.IsContains(city.Name))
                {
                    //Check if city already exists
                    if (city.Insert())
                    {
                        //MessageBox.Show("Added successfully :)");

                        //Update listbox

                        CityArrToForm();
                        CityToForm(null);

                    }
                    else
                        MessageBox.Show("You did something wrong");

                }
                else
                    MessageBox.Show("Already exist");
            }
            else { MessageBox.Show("Your City name is too short"); }
            CityArr cityArr = new CityArr();
            cityArr.Fill();
            city = cityArr.GetCityWithMaxId();
            CityArrToForm(city);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (text_Id.Text == "0")
                MessageBox.Show("You must select a city");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    City city = FormToCity();

                    //Check that there isn't already a client with that city

                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(city))
                        MessageBox.Show("You can’t delete a city that is related to a client");

                    else if (city.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CityToForm(null);
                        CityArrToForm();
                    }
                    else
                        MessageBox.Show("Error");
                }
            }
        }

        private void listBox_City_Click(object sender, EventArgs e)
        {
            City selCity = listBox_City.SelectedItem as City;
            CityToForm(selCity);
        }


        
        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                button_Update_Click(null, null);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            CityToForm(null);
        }
    }
}
