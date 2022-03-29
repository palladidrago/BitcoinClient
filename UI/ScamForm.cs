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
        Scam scam;
        public ScamForm()
        {
            InitializeComponent();
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
            //TODO: Add checkForm
            scam = FormToScam();
            if (scam.Id == 0)
            {
                if (scam.Insert())
                {
                    MessageBox.Show("Added successfully", "Success");
                }
                else MessageBox.Show("Something gone wrong wid da adding bruh ;(", "Fail");
            }
            else
            {
                if (scam.Insert())
                {
                    MessageBox.Show("Updated successfully", "Success");
                    ScamArrToForm();
                }
                else MessageBox.Show("Ayo something don gon wron wid da updating kind sir ;)", "Fail");
            }
            ScamArrToForm();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            scam = FormToScam();
            if (scam.Id == 0)
                MessageBox.Show("You need to choose a scam");
            else
            {
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (scam.Delete()) MessageBox.Show("Deleted Successfully", "Success");
                    else MessageBox.Show("Somtin gon wrong in deletion bro sorry", "Fail");
                    ScamToForm(null);
                    ScamArrToForm();
                }
            }
        }
    }
}
