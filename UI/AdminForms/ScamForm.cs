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
    public partial class ScamForm : Form
    {
        public Scam selectedScam { get; set; }

        public ScamForm(Scam scam = null)
        {
            InitializeComponent();
            if (scam != null && scam.Id <= 0) scam = null;
            ScamArrToForm();
            ScamToForm(scam); 
        }
        private Scam FormToScam()
        {
            Scam scam = new Scam();
            scam.Id = int.Parse(text_Id.Text);
            scam.Name = textBox_Scam.Text;
            return scam;
        }
        private void ScamToForm(Scam scam = null)
        {
            if (scam != null)
            {
                text_Id.Text = scam.Id.ToString();
                textBox_Scam.Text = scam.Name.Trim();

            }
            else
            {
                text_Id.Text = "0";
                textBox_Scam.Text = "";
            }
        }
        private void ScamArrToForm()
        {
            ScamArr scamArr = new ScamArr();
            scamArr.Fill();
            listBox_Scam.DataSource = scamArr;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            selectedScam = FormToScam();
            if (selectedScam.Id == 0)
            {
                if (selectedScam.Insert())
                {
                    MessageBox.Show("Added successfully", "Success");
                }
                else MessageBox.Show("Something went wroing with the inserting :(", "Fail");
            }
            else
            {
                if (selectedScam.Insert())
                {
                    MessageBox.Show("Updated successfully", "Success");
                    ScamArrToForm();
                }
                else MessageBox.Show("Something went wroing with the Updating", "Fail");
            }
            ScamArrToForm();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            selectedScam = FormToScam();
            if (selectedScam.Id == 0)
                MessageBox.Show("You need to choose a scam");
            else
            {
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    CoinArr coinArr = new CoinArr();
                    coinArr.Fill();
                    if (coinArr.Filter(scam: selectedScam).Count > 0)
                    {
                        if (selectedScam.Delete()) MessageBox.Show("Deleted Successfully", "Success");
                        else MessageBox.Show("Something went wrong in the deletion", "Fail");
                        ScamToForm(null);
                        ScamArrToForm();
                    }
                    else
                    {                       
                        MessageBox.Show("You can't delete a validation method that is in use", "Fail");
                        ScamToForm(null);

                    }
                }
            }
        }

        private void listBox_Scam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScamToForm((sender as ListBox).SelectedItem as Scam);
        }
    }
}
