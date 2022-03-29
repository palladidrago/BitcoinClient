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
            ValidArrToForm();
            ScamArrToForm();
            CoinArrToForm();
        }
        private Coin FormToCoin()
        {
            Coin coin = new Coin();
            coin.Id = int.Parse(text_Id.Text);
            coin.Name = textBox_Name.Text;
            coin.Symbol = textBox_Symbol.Text;
            coin.Scam = comboBox_Scam.SelectedItem as Scam;
            coin.Valid = comboBox_Valid.SelectedItem as Valid;
            return coin;
        }
        private void CoinToForm(Coin coin = null)
        {
            if (coin != null)
            {
                text_Id.Text = coin.Id.ToString();
                textBox_Symbol.Text = coin.Symbol.Trim();
                textBox_Name.Text = coin.Name.Trim();
                //Valid
                comboBox_Valid.SelectedValue = coin.Valid.Id;
                comboBox_Scam.SelectedValue = coin.Scam.Id;

            }
            else
            {
                text_Id.Text = "0";
                textBox_Symbol.Text = "";
                textBox_Name.Text = "";

                comboBox_Valid.SelectedItem = null;
                comboBox_Scam.SelectedItem = null;
            }
        }
        private void CoinArrToForm()
        {
            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            listBox_Coins.DataSource = coinArr;
            listBox_Coins.ValueMember = "Id";
            listBox_Coins.DisplayMember = "Name";
            if (coin != null)
                listBox_Coins.SelectedValue = coin.Id;
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
                if (coin.Id == 0)
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
            if (coin.Id == 0)
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

        private void button_AddValid_Click(object sender, EventArgs e)
        {
            ValidForm validForm = new ValidForm(comboBox_Valid.SelectedItem as Valid);

            validForm.ShowDialog();

            ValidArrToForm(validForm.selectedValid);
        }
        public void ValidArrToForm(Valid curValid = null)
        {
            //From Valid array to form 
            ValidArr validArr = new ValidArr();
            Valid validDefault = new Valid();
            validDefault.Id = -1;
            validDefault.Name = "Choose a validation method";


            validArr.Add(validDefault);
            validArr.Fill();

            comboBox_Valid.DataSource = validArr;
            comboBox_Valid.ValueMember = "Id";
            comboBox_Valid.DisplayMember = "";
            comboBox_Filter_Valid.DataSource = validArr;
            comboBox_Filter_Valid.ValueMember = "Id";
            comboBox_Filter_Valid.DisplayMember = "";

        }
        public void ScamArrToForm(Scam curScam = null)
        {
            //From Scam array to form 
            ScamArr scamArr = new ScamArr();
            Scam scamDefault = new Scam();
            scamDefault.Id = -1;
            scamDefault.Name = "Choose a scam level";


            scamArr.Add(scamDefault);
            scamArr.Fill();

            comboBox_Scam.DataSource = scamArr;
            comboBox_Scam.ValueMember = "Id";
            comboBox_Scam.DisplayMember = "Name";
            comboBox_Filter_Scam.DataSource = scamArr;
            comboBox_Filter_Scam.ValueMember = "Id";
            comboBox_Filter_Scam.DisplayMember = "Name";

        }

        private void listBox_Coins_DoubleClick(object sender, EventArgs e)
        {
            CoinToForm(listBox_Coins.SelectedItem as Coin);
        }

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            //Create an array of Coins

            CoinArr coinArr = new CoinArr();
            coinArr.Fill();

            //Filter the coins according to name

            coinArr = coinArr.Filter((sender as TextBox).Text );

            //Change datasource

            listBox_Coins.DataSource = coinArr;
        }

        private void comboBox_Filter_Valid_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            coinArr = coinArr.Filter(valid: (sender as ComboBox).SelectedItem as Valid);
            listBox_Coins.DataSource = coinArr;
        }

        private void comboBox_Filter_Scam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            coinArr = coinArr.Filter(scam: (sender as ComboBox).SelectedItem as Scam);
            listBox_Coins.DataSource = coinArr;
        }
        
    }
}
