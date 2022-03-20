﻿using System;
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
        public Valid selectedValid;

        public ValidForm(Valid valid = null)
        {
            InitializeComponent();
            if (valid != null && valid.id <= 0) valid = null;
            ValidToForm();
            ValidToForm(valid); //Fill the listbox
        }
        private Valid FormToValid()
        {
            Valid valid = new Valid();
            valid.id = int.Parse(text_Id.Text);
            valid.name = textBox_Valid.Text;
            return valid;
        }
        private void ValidToForm(Valid valid = null)
        {
            if (valid != null)
            {
                text_Id.Text = valid.id.ToString();
                textBox_Valid.Text = valid.name.Trim();

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
            //TODO: Add checkForm
            selectedValid = FormToValid();
            if (selectedValid.id == 0)
            {
                if (selectedValid.Insert())
                {
                    MessageBox.Show("Added successfully", "Success");
                }
                else MessageBox.Show("Something gone wrong wid da adding bruh ;(", "Fail");
            }
            else
            {
                if (selectedValid.Insert())
                {
                    MessageBox.Show("Updated successfully", "Success");
                    ValidArrToForm();
                }
                else MessageBox.Show("Ayo something don gon wron wid da updating kind sir ;)", "Fail");
            }
            ValidArrToForm();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            selectedValid = FormToValid();
            if (selectedValid.id == 0)
                MessageBox.Show("You need to choose a valid");
            else
            {
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (selectedValid.Delete()) MessageBox.Show("Deleted Successfully", "Success");
                    else MessageBox.Show("Somtin gon wrong in deletion bro sorry", "Fail");
                    ValidToForm(null);
                    ValidArrToForm();
                }
            }
        }
    }
}
