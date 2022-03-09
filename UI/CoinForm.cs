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
    public partial class CoinForm : Form
    {
        Coin coin;
        public CoinForm()
        {
            InitializeComponent();
        }
        private Coin FormToCoin()
        {
            Coin coin = new Coin();
            coin.id = int.Parse(text_Id.Text);
            coin.name = textBox_Name.Text;
            coin.symbol = textBox_Symbol.Text;
            coin.scam = comboBox_Scam.SelectedItem as Scam;
            coin.valid = comboBox_Valid.SelectedItem as Valid;
            return coin;
        }
        private void CoinToForm(Coin coin = null)
        {
            if (coin != null)
            {
                text_Id.Text = coin.id.ToString();
                textBox_Symbol.Text = coin.symbol.Trim();
                textBox_Name.Text = coin.name.Trim();
                //City
                comboBox_Valid.SelectedValue = coin.valid.id;
                comboBox_Scam.SelectedValue = coin.scam.id;

                comboBox_Valid.SelectedItem = null;
                comboBox_Scam.SelectedItem = null;
            }
            else
            {
                text_Id.Text = "0";
                textBox_Symbol.Text = "";
                textBox_Name.Text = "";
            }
        }
        private void CoinArrToForm()
        {
            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            listBox_Coins.DataSource = coinArr;
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

        private void button_Save_Click(object sender, EventArgs e)
        {
            //TODO: Add checkForm
            coin = FormToCoin();
            if (CheckForm()) {
                if (coin.id == 0)
                {
                    if (coin.Insert())
                    {
                        MessageBox.Show("Added successfully", "Success");
                    }
                    else MessageBox.Show("Something gone wrong wid da adding bruh ;(", "Fail");
                }
                else
                {
                    if (coin.Insert())
                    {
                        MessageBox.Show("Updated successfully", "Success");
                        CoinArrToForm();
                    }
                    else MessageBox.Show("Ayo something don gon wron wid da updating kind sir ;)", "Fail");
                }
                CoinArrToForm();
            }
        
            else Console.WriteLine("You did something Wrong");
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            coin = FormToCoin();
            if (coin.id == 0)
                MessageBox.Show("You need to choose a coin");
            else
            {
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (coin.Delete()) MessageBox.Show("Deleted Successfully", "Success");
                    else MessageBox.Show("Somtin gon wrong in deletion bro sorry", "Fail");
                    CoinToForm(null);
                    CoinArrToForm();
                }
            }
        }
    }
}
