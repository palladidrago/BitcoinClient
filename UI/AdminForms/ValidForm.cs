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
    public partial class ValidForm : Form
    {
        public Valid selectedValid { get; set; }

        public ValidForm(Valid valid = null)
        {
            InitializeComponent();
            if (valid != null && valid.Id <= 0) valid = null;
            ValidArrToForm();
            ValidToForm(valid); //Fill the listbox
        }
        private Valid FormToValid()
        {
            Valid valid = new Valid();
            valid.Id = int.Parse(text_Id.Text);
            valid.Name = textBox_Valid.Text;
            return valid;
        }
        private void ValidToForm(Valid valid = null)
        {
            if (valid != null)
            {
                text_Id.Text = valid.Id.ToString();
                textBox_Valid.Text = valid.Name.Trim();

            }
            else
            {
                text_Id.Text = "0";
                textBox_Valid.Text = "";
            }
        }
        private void ValidArrToForm()
        {
            ValidArr validArr = new ValidArr();
            validArr.Fill();
            listBox_Valid.DataSource = validArr;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            selectedValid = FormToValid();
            if (selectedValid.Id == 0)
            {
                if (selectedValid.Insert())
                {
                    MessageBox.Show("Added successfully", "Success");
                }
                else MessageBox.Show("Something went wrong with the inserting", "Fail");
            }
            else
            {
                if (selectedValid.Insert())
                {
                    MessageBox.Show("Updated successfully", "Success");
                    ValidArrToForm();
                }
                else MessageBox.Show("Something went wrong with the deletion", "Fail");
            }
            ValidArrToForm();
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            selectedValid = FormToValid();
            if (selectedValid.Id == 0)
                MessageBox.Show("You need to choose a validation method");
            else
            {
                CoinArr coinArr = new CoinArr();
                coinArr.Fill();
                if (coinArr.Filter(valid: selectedValid).Count > 0)
                {
                    if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                System.Windows.Forms.DialogResult.Yes)
                    {
                        if (selectedValid.Delete()) MessageBox.Show("Deleted Successfully", "Success");
                        else MessageBox.Show("Something went wrong in the deletion :(", "Fail");
                        ValidToForm(null);
                        ValidArrToForm();
                    }
                }
                else
                {
                    MessageBox.Show("You can't delete a validation method that is in use", "Fail");
                    ValidArrToForm();
                }
            }
        }

        private void listBox_Valid_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidToForm((sender as ListBox).SelectedItem as Valid);
        }
    }
}
