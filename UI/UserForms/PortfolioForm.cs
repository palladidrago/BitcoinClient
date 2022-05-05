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
    public partial class PortfolioForm : Form
    {

        public PortfolioForm()
        {
            InitializeComponent();
            CoinArrToForm(ClientToTradeCoinArr(Globals.client).GetCoinArr());
            PortfolioValueToForm();

            
        }
        private void PortfolioValueToForm()
        {
            TradeCoinArr tradeCoinArr = ClientToTradeCoinArr(Globals.client);
            double sum = 0;
            long coinAmount;
            CoinQuoteArr coinQuoteArr = new CoinQuoteArr(); coinQuoteArr.Fill();


            foreach (TradeCoin tradeCoin in tradeCoinArr)
            {
                coinAmount = tradeCoin.Count;
                sum += (double) (coinQuoteArr.LatestQuote(tradeCoin.Coin).Price * coinAmount);
            }
            text_PortfolioValue.Text = sum.ToString("0.00") + "$";
        }
        private TradeCoinArr ClientToTradeCoinArr(Client client)
        {
            TradeCoinArr tradeCoinArr = new TradeCoinArr();
            tradeCoinArr.Fill();
            return tradeCoinArr.Filter(client).FilterNoDuplicates();
            
        }
        private void CoinArrToForm(CoinArr coinArr)
        {
            listBox_Coins.DataSource = coinArr;
            listBox_Coins.DisplayMember = "Name";
        }


        private void listBox_Coins_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Coin
            ListBox lb = sender as ListBox;
            Coin c = (Coin)lb.SelectedItem;
            if (c == null) return;
            pictureBox_Coin.ImageLocation =  c.LogoUrl;
            text_Name.Text = c.Name;

            //Quote
            CoinQuoteArr coinQuoteArr = new CoinQuoteArr();
            coinQuoteArr.Fill();
            Quote q = coinQuoteArr.LatestQuote(c);
            QuoteToForm(q);

            //Amount
            TradeCoinArr tradeCoinArr = new TradeCoinArr();
            tradeCoinArr.Fill();
            tradeCoinArr =  tradeCoinArr.Filter(Globals.client).Filter(c);
            long count = tradeCoinArr.SumOfAllCounts();
            text_Amount.Text = "Amount: " + count.ToString();

            //CoinValue
            text_Amount.Text += "- " + String.Format("{0:0.##}", (q.Price * (double)count)) + "$";
        }
        private void QuoteToForm(Quote q)
        {
            if (q != null && q.Price != 0)
            {
                text_Price.Text = string.Format("{0:0.##}", q.Price) + "$";
                text_Volume.Text = string.Format("{0:n0}", q.Volume) + "$";

                text_MarketCap.Text = string.Format("{0:n0}", q.MarketCap) + "$";
                text_PercentChanged.Text = string.Format("{0:n0}", q.PercentChange) + "%";
                if (q.PercentChange > 0) text_PercentChanged.ForeColor = Color.Green;
                else text_PercentChanged.ForeColor = Color.Red;

            }
            else
            {
                text_Price.Text = "";
                text_Volume.Text = "";
                text_MarketCap.Text = "";
                text_PercentChanged.Text = "";
            }
        }

        private void button_FetchCoinPrice_Click(object sender, EventArgs e)
        {
            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            CoinQuoteArr cqArr = Helpers.FillCoinQuoteArrFromApi(coinArr);
            cqArr.Insert();

            //Refresh form
            Coin c = (Coin)listBox_Coins.SelectedItem;
            CoinQuoteArr coinQuoteArr = new CoinQuoteArr();
            coinQuoteArr.Fill();
            Quote q = coinQuoteArr.LatestQuote(c);
            QuoteToForm(q);
            PortfolioValueToForm();
        }
    }
}
