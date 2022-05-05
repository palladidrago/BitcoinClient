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
            coin.Supply = (long)numericUpDown_Supply.Value;
            Helpers.SetCoinInfoFromApi(coin);
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
                numericUpDown_Supply.Value = coin.Supply;
                if (coin.LogoUrl != null) pictureBox_Logo.ImageLocation = coin.LogoUrl; 
                else pictureBox_Logo.Image = Properties.Resources.Bitcoin_Logo1;
                comboBox_Valid.SelectedValue = coin.Valid.Id;
                comboBox_Scam.SelectedValue = coin.Scam.Id;
                this.coin = coin;

            }
            else
            {
                text_Id.Text = "0";
                textBox_Symbol.Text = "";
                textBox_Name.Text = "";
                numericUpDown_Supply.Value = 0;
                pictureBox_Logo.Image = null;
                comboBox_Valid.SelectedItem = null;
                comboBox_Scam.SelectedItem = null;
                coin = null;
            }
        }
        private void QuoteToForm(Quote q = null)
        {
            if (q != null) {
                text_Price.Text = string.Format("{0:0.00}", q.Price) + "$";
                text_Volume.Text = string.Format("{0:n0}", q.Volume) + "$";

                text_MarketCap.Text = string.Format("{0:n0}", q.MarketCap) + "$";
                text_PercentChanged.Text = string.Format("{0:0.0}", q.PercentChange) + "%";
                if (q.PercentChange > 0) text_PercentChanged.ForeColor = Color.Green;
                else text_PercentChanged.ForeColor = Color.Red;
            }
            else
            {
                text_Price.Text =  "";
                text_Volume.Text = "";
                text_PercentChanged.Text =  "";
                text_MarketCap.Text = "";
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
            if (textBox_Symbol.Text.Length < 2)
            {
                flag = false;
                textBox_Symbol.BackColor = Color.Red;
            }
            else
                textBox_Name.BackColor = Color.White;
            return flag;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //TODO: Add checkForm
            bool flag = true;
            try
            {
                coin = FormToCoin();
            }
            catch { 
                flag = false;
                MessageBox.Show("The symbol you entered doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (CheckForm() && flag) {
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
                    if (coin.Update())
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
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                System.Windows.Forms.DialogResult.Yes) //If he's sure he wants to delete
                {
                    TradeCoinArr tradeCoinArr = new TradeCoinArr();
                    tradeCoinArr.Fill();
                    tradeCoinArr.Filter(coin);
                    if (tradeCoinArr.Count == 0) //Don't delete coins that are part of trades
                    {
                        CoinQuoteArr coinQuoteArr = new CoinQuoteArr();
                        coinQuoteArr.Fill();
                        coinQuoteArr.Filter(coin); //We can't only delete the coin, we also have to delete all its' quotes

                        coinQuoteArr = coinQuoteArr.Filter(coin); //We can't only delete the coin, we also have to delete all its' quotes

                        if (coinQuoteArr.Delete() && coin.Delete()) MessageBox.Show("Deleted Successfully", "Success");
                        else MessageBox.Show("Something went wrong in the deletion :(", "Fail");
                    }
                    else MessageBox.Show("You can't delete a coin that is also in a trade", "Fail");
                    CoinToForm(null);
                    CoinArrToForm();
                }
            }
        }

        private void button_AddValid_Click(object sender, EventArgs e)
        {
            //Add validation method
            ValidForm validForm = new ValidForm(comboBox_Valid.SelectedItem as Valid);

            validForm.ShowDialog();

            ValidArrToForm(validForm.selectedValid);
        }
        private void button_AddScam_Click(object sender, EventArgs e)
        {
            //Add scam level
            ScamForm scamForm = new ScamForm(comboBox_Scam.SelectedItem as Scam);

            scamForm.ShowDialog();

            ScamArrToForm(scamForm.selectedScam);
        }
        public void ValidArrToForm(Valid curValid = null)
        {//Fill validation method combobox

            Valid validDefault = new Valid();
            validDefault.Id = -1;
            validDefault.Name = "Choose a validation method";

            //From Valid array to form 
            ValidArr validArr1 = new ValidArr();



            validArr1.Add(validDefault);
            validArr1.Fill();

            comboBox_Valid.DataSource = validArr1;
            comboBox_Valid.ValueMember = "Id";
            comboBox_Valid.DisplayMember = "";

            ValidArr validArr2 = new ValidArr();
            validArr2.Add(validDefault);
            validArr2.Fill();
            comboBox_Filter_Valid.DataSource = validArr2;
            comboBox_Filter_Valid.ValueMember = "Id";
            comboBox_Filter_Valid.DisplayMember = "";

        }
        public void ScamArrToForm(Scam curScam = null)
        {//Fill scam level combobox
            Scam scamDefault = new Scam();
            scamDefault.Id = -1;
            scamDefault.Name = "Choose a scam level";

            //From Scam array to form 
            ScamArr scamArr1 = new ScamArr();



            scamArr1.Add(scamDefault);
            scamArr1.Fill();

            comboBox_Scam.DataSource = scamArr1;
            comboBox_Scam.ValueMember = "Id";
            comboBox_Scam.DisplayMember = "";

            ScamArr scamArr2 = new ScamArr();
            scamArr2.Add(scamDefault);
            scamArr2.Fill();
            comboBox_Filter_Scam.DataSource = scamArr2;
            comboBox_Filter_Scam.ValueMember = "Id";
            comboBox_Filter_Scam.DisplayMember = "";

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
        private void button_FetchPriceInfo_Click(object sender, EventArgs e)
        {
            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            CoinQuoteArr cqArr = Helpers.FillCoinQuoteArrFromApi(coinArr);
            cqArr.Insert();
            QuoteToForm(cqArr.LatestQuote(listBox_Coins.SelectedItem as Coin));
        }


        private void listBox_Coins_SelectedIndexChanged(object sender, EventArgs e)
        {
            coin = ((sender as ListBox).SelectedItem as Coin);

            CoinQuoteArr qArr = new CoinQuoteArr();
            qArr.Fill();
            qArr.Filter(coin);
            Quote q = qArr.LatestQuote(coin);
            QuoteToForm(q);
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            CoinToForm(null);
            QuoteToForm(null);
        }

       
    }
}
