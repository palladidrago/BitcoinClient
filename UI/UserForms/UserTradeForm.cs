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

    public partial class UserTradeForm : Form
    {
        Coin curCoin;
        #region Helpers
        #region Clear Helpers
        private void ClearDetails()
        {
            //Clear Filter
            foreach (TextBox tb in groupBox_Filter_Details.Controls.OfType<TextBox>())
                tb.Text = String.Empty;
            text_Id.Text = "0";
            textBox_Memo.Text = String.Empty;
            dateTimePicker_Date.Value = DateTime.Now;

        }
        private void ClearItems()
        {
            textBox_Coin_Filter_Name.Text = String.Empty;
            comboBox_Coin_Filter_Valid.SelectedValue = -1;
            comboBox_Coin_Filter_Scam.SelectedValue = -1;
            listBox_Chosen_Coins.DataSource = null; listBox_Chosen_Coins.Items.Clear(); //Clear coins listbox
            listBox_Chosen_Coins_Supply.Items.Clear(); //Clear count listbox
            QuoteToForm(null);
            curCoin = null;
            SetCoinsByFilter();



        }
        private void ClearAll() { ClearDetails(); ClearItems(); }
        #endregion
        private void SetCoinsByFilter()
        {
            //Create new coin array
            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            //Filter according to what the user asked
            coinArr = coinArr.Filter(name: textBox_Coin_Filter_Name.Text, scam: comboBox_Coin_Filter_Scam.SelectedItem as Scam,
                valid: comboBox_Coin_Filter_Valid.SelectedItem as Valid);
            if (listBox_Chosen_Coins.DataSource != null)
                coinArr.Remove(listBox_Chosen_Coins.DataSource as CoinArr); //Remove all the chosen coins from the potential listbox
            CoinArrToForm(listBox_Potential_Coins, coinArr);
        }
        private void MoveSelectedItemBetweenListBox(ListBox listBox_From, ListBox listBox_To, bool isToTrade)
        {
            if (listBox_From.SelectedItem == null) return;

            // Moves coins between potential and wanted listbox
            CoinArr coinArr = null;
            Coin selectedItem = listBox_From.SelectedItem as Coin;
            //Find selected coin

            Coin selectedCoin = listBox_From.SelectedItem as Coin;
            if (isToTrade)
            {
                selectedItem.Supply--;
                listBox_Chosen_Coins_Supply.Items.Add(1);
            }
            else
            {
                (selectedItem as Coin).Supply += (int)listBox_Chosen_Coins_Supply.SelectedItem;
                listBox_Chosen_Coins_Supply.Items.RemoveAt(listBox_Chosen_Coins_Supply.SelectedIndex);
            }


            //Add the potential coin to the list of coins
            //If the are already coins in the potential list

            if (listBox_To.DataSource != null)
                coinArr = listBox_To.DataSource as CoinArr;
            else
                coinArr = new CoinArr();
            coinArr.Add(selectedCoin);
            CoinArrToForm(listBox_To, coinArr);

            ///Remove chosen item from list of chose items (NEW)

            coinArr = listBox_From.DataSource as CoinArr;
            coinArr.Remove(selectedCoin);
            CoinArrToForm(listBox_From, coinArr);
            // If is to trade, change selected indexes
            if (isToTrade)
            {
                int k = listBox_To.Items.Count - 1;
                listBox_To.SelectedIndex = k;
                listBox_Chosen_Coins_Supply.SelectedIndex = k;
            }
        }
        #endregion
        public UserTradeForm()
        {
            InitializeComponent();
            CoinArrToForm(listBox_Potential_Coins);
            ValidArrToForm();
            ScamArrToForm();
            TradeArrToForm();
        }
        #region XToForm
        private void QuoteToForm(Quote q)
        {
            if (q != null && q.Price != 0)
            {
                text_Price.Text = string.Format("{0:n0}", q.Price) + "$";
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

        private void TradeToForm(Trade trade = null)
        {
            if (trade != null)
            {
                Client c = trade.Client;
                //listBox_Trades.SelectedValue = trade.Id;
                text_Id.Text = trade.Id.ToString();
                textBox_Memo.Text = trade.Memo;

            }
            else
            {
                //listBox_Trades.SelectedValue = -1;
                text_Id.Text = "0";
                textBox_Memo.Text = String.Empty;
            }
        }

        private void TradeArrToForm(TradeArr tArr = null)
        {
            //Fill in trade listbox autmatically
            if (tArr == null)
            {
                tArr = new TradeArr();
                tArr.Fill();
            }
            tArr = tArr.Filter(client: Globals.client); //Only get trades for current client
            listBox_Trades.DataSource = tArr;
            //listBox_Trades.ValueMember = "Id";
            listBox_Trades.DisplayMember = "Name";
        }

        private void ValidArrToForm(Valid curValid = null)
        {
            //From Valid array to form 
            ValidArr validArr = new ValidArr();
            Valid validDefault = new Valid();
            validDefault.Id = -1;
            validDefault.Name = "Choose a validation method";


            validArr.Add(validDefault);
            validArr.Fill();


            comboBox_Coin_Filter_Valid.DataSource = validArr;
            comboBox_Coin_Filter_Valid.ValueMember = "ID";
            comboBox_Coin_Filter_Valid.DisplayMember = "";
            if (curValid != null)
            {
                comboBox_Coin_Filter_Valid.SelectedValue = curValid.Id;
            }
        }
        private void ScamArrToForm(Scam curScam = null)
        {
            //From Scam array to form 
            ScamArr scamArr = new ScamArr();
            Scam scamDefault = new Scam();
            scamDefault.Id = -1;
            scamDefault.Name = "Choose a scam level";


            scamArr.Add(scamDefault);
            scamArr.Fill();


            comboBox_Coin_Filter_Scam.DataSource = scamArr;
            comboBox_Coin_Filter_Scam.ValueMember = "ID";
            comboBox_Coin_Filter_Scam.DisplayMember = "";
            if (curScam != null)
            {
                comboBox_Coin_Filter_Scam.SelectedValue = curScam.Id;
            }
        }

        private void CoinArrToForm(ListBox listBox, CoinArr coinArr = null)
        {

            //Takes a list of coins and listobox and puts the coins in the listbox
            //If coinArr empty, creates one and fills it

            listBox.DataSource = null;
            if (coinArr == null)
            {
                coinArr = new CoinArr();
                coinArr.Fill(); //Add all coins
            }
            listBox.DataSource = coinArr;
            if (coinArr.Count > 0)
            {
                listBox.ValueMember = "Id";
            }
            listBox.DisplayMember = "";
        }
        private void CoinArrSupplyToForm(TradeCoinArr curTradeCoinArr)
        {
            listBox_Chosen_Coins_Supply.Items.Clear(); //Clear listbox
            for (int i = 0; i < curTradeCoinArr.Count; i++)
            {
                listBox_Chosen_Coins_Supply.Items.Add((curTradeCoinArr[i] as TradeCoin).Count); //Add count manually (not datasource)
            }

            //Select the first line right away

            if (listBox_Chosen_Coins_Supply.Items.Count > 0)
                listBox_Chosen_Coins_Supply.SelectedIndex = 0;
        }
        #endregion
        #region FormToX
        private TradeCoinArr FormToTradeCoinArr(Trade curTrade)
        {

            // Creation of TradeCoinArr from form
            // Create pairs of Trade and Coin (the trade is always the same, the coin is fetched from the list)
            TradeCoinArr tradeCoinArr = new TradeCoinArr();
            TradeCoin tradeCoin;

            //Scan the listbox for coins
            for (int i = 0; i < listBox_Chosen_Coins.Items.Count; i++)
            {
                tradeCoin = new TradeCoin();

                //The current trade is the same for all coins in the array

                tradeCoin.Trade = curTrade;

                //Current product for trade coin pair

                tradeCoin.Coin = listBox_Chosen_Coins.Items[i] as Coin;

                //Supply of Coins for current TradeCoin
                tradeCoin.Count = Convert.ToInt64(listBox_Chosen_Coins_Supply.Items[i]);

                //Add current tradecoin pair to array

                tradeCoinArr.Add(tradeCoin);
            }
            return tradeCoinArr;
        }
        private Trade FormToTrade()
        {
            Trade trade = new Trade();
            trade.Id = int.Parse(text_Id.Text);
            trade.Client = Globals.client;
            trade.Date = dateTimePicker_Date.Value;
            trade.Memo = textBox_Memo.Text;
            return trade;
        }
        #endregion
        #region Bottom Buttons

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

            //Create an trade from the form

            Trade trade = FormToTrade();

            //Add trade to db 

            TradeCoinArr tradeCoinArr_New;
            if (trade.Id == 0)
            {
                if (trade.Insert()) //Insert the trade into the db
                {

                    //Find the newest trade using the highest id

                    TradeArr tradeArr = new TradeArr();
                    tradeArr.Fill();
                    trade = tradeArr.GetTradeWithMaxId(); //Pull the newest trade out
                    tradeCoinArr_New = FormToTradeCoinArr(trade);

                    //Add new coins to the trade

                    if (tradeCoinArr_New.Insert())
                    {
                        MessageBox.Show("Successfully saved");
                        (listBox_Chosen_Coins.DataSource as CoinArr).UpdateSupply();

                    }

                    else
                        MessageBox.Show("Error in insert");

                    ClearAll();
                    TradeArrToForm(); // Do this add the new trade to the list

                }
            }
            else if (trade.Update()) //Update the trade in db
            {
                //If successful, need to update trade in TradeCoin db as well!
                TradeCoinArr tradeCoinArr_Old = new TradeCoinArr();
                tradeCoinArr_Old.Fill();
                tradeCoinArr_Old = tradeCoinArr_Old.Filter(trade);
                //Delete all TradeCoin (all items of trade itself) for this trade
                tradeCoinArr_Old.Delete();
                tradeCoinArr_New = FormToTradeCoinArr(trade); //Update TradeCoinArr with new trade items
                if (tradeCoinArr_New.Insert())
                {
                    MessageBox.Show("Updated successfully");
                    (listBox_Chosen_Coins.DataSource as CoinArr).UpdateSupply();

                    (listBox_Potential_Coins.DataSource as CoinArr).UpdateSupply();
                }
                else { MessageBox.Show("Update Failed"); }//Finally, insert the TradeCoinArr to db

                ClearAll();
            }
            else MessageBox.Show("Error in insert/update");
        
            
        }
        #endregion
        #region Event Functions
        private void listBox_Trades_MouseClick(object sender, MouseEventArgs e)
        {
            //When Trade selected:
            ListBox lb = sender as ListBox;
            Trade curTrade = lb.SelectedItem as Trade;

            if (curTrade != null)
            {
                //Trade to form (First Page)
                TradeToForm(curTrade);



                //Find current trade coins and put them in the listbox
                TradeCoinArr tradeCoinArr = new TradeCoinArr();
                tradeCoinArr.Fill();

                //Filter by trade

                tradeCoinArr = tradeCoinArr.Filter(curTrade);

                //Only the coins in the trade coin arr
                //Update Chosen listbox, all the chosen coins
                CoinArr coinArrInTrade = tradeCoinArr.GetCoinArr();
                CoinArrToForm(listBox_Chosen_Coins, coinArrInTrade);
                //Update the count (in addition to the list) of coins
                CoinArrSupplyToForm(tradeCoinArr);

                //Update Potential listbox: all coins, except already chosen     ones

                CoinArr coinArrNotInTrade = new CoinArr();
                coinArrNotInTrade.Fill();


                coinArrNotInTrade.Remove(coinArrInTrade); //Remove all coins already in the trade
                CoinArrToForm(listBox_Potential_Coins, coinArrNotInTrade); //Put them in the potential listbox
            }
        }

        private void listBox_Potential_Coins_DoubleClick(object sender, EventArgs e)
        {
            //Move selected coin from potential list of coins to list of chosen coins

            ListBox potentialListBox = sender as ListBox;
            MoveSelectedItemBetweenListBox(potentialListBox, listBox_Chosen_Coins, true);
        }



        private void textBox_Coin_Filter_Name_KeyUp(object sender, KeyEventArgs e)
        {
            SetCoinsByFilter();
        }

        private void comboBox_Coin_Filter_Valid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCoinsByFilter();
        }

        private void comboBox_Coin_Filter_Scam_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCoinsByFilter();
        }

        private void listBox_Chosen_Coins_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox_Chosen_Coins_Supply.SelectedIndex = listBox_Chosen_Coins.SelectedIndex;
            }
            catch (Exception ex) { ex.ToString(); }
            listBox_Potential_Coins_SelectedIndexChanged(sender, e);
        }

        private void listBox_Chosen_Coins_Supply_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox_Chosen_Coins.SelectedIndex = listBox_Chosen_Coins_Supply.SelectedIndex;
            }
            catch (Exception ex) { ex.ToString(); }
        }
        private void listBox_Potential_Coins_SelectedIndexChanged(object sender, EventArgs e)
        {

            curCoin = ((sender as ListBox).SelectedItem as Coin);

            CoinQuoteArr qArr = new CoinQuoteArr();
            qArr.Fill();
            qArr.Filter(curCoin);
            Quote q = qArr.LatestQuote(curCoin);
            if (curCoin != null && curCoin.LogoUrl != null)
            {
                pictureBox_Logo.ImageLocation = curCoin.LogoUrl;

            }
            QuoteToForm(q);
        }

        #endregion
        #region Coin buttons
        private void button_Plus_Coin_Click(object sender, EventArgs e)
        {
            if (listBox_Chosen_Coins_Supply.SelectedIndex >= 0)
            {
                if ((listBox_Chosen_Coins.SelectedItem as Coin).Supply > 0) //Check if at least one in stock (or trade?)
                { //If yes, add to TradeCoin and remove from stock
                    int k = listBox_Chosen_Coins_Supply.SelectedIndex;
                    //Update the product inside the chosen coins listbox
                    listBox_Chosen_Coins_Supply.Items[k] = Convert.ToInt64(listBox_Chosen_Coins_Supply.Items[k]) + 1;
                    //Remove from stock, update coin amount in list of coins in trade
                    CoinArr coinArr = listBox_Chosen_Coins.DataSource as CoinArr;
                    Coin coin = listBox_Chosen_Coins.SelectedItem as Coin;
                    coin.Supply--;
                    coinArr.UpdateSupply(coin);
                    CoinArrToForm(listBox_Chosen_Coins, coinArr);
                }
                else MessageBox.Show("There aren't enough in stock for that", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_Minus_Coin_Click(object sender, EventArgs e)
        {
             if (listBox_Chosen_Coins_Supply.SelectedIndex >= 0)
            {
                if (Convert.ToInt64(listBox_Chosen_Coins_Supply.SelectedItem) > 1) //Check if at least one in stock (or trade?)
                { //If yes, add to TradeCoin and remove from stock
                    int k = listBox_Chosen_Coins_Supply.SelectedIndex;
                    //Update the product inside the chosen coins listbox
                    listBox_Chosen_Coins_Supply.Items[k] = Convert.ToInt64(listBox_Chosen_Coins_Supply.Items[k]) - 1;
                    //Remove from stock, update coin amount in list of coins in trade
                    CoinArr coinArr = listBox_Chosen_Coins.DataSource as CoinArr;
                    Coin coin = listBox_Chosen_Coins.SelectedItem as Coin;
                    coin.Supply++; //Update stock
                    coinArr.UpdateSupply(coin);
                    CoinArrToForm(listBox_Chosen_Coins, coinArr);
                }
                else
                {
                    //Update the product inside the chosen coins listbox
                    //Remove from stock, update coin amount in list of coins in trade
                    CoinArr coinArr = listBox_Chosen_Coins.DataSource as CoinArr;
                    Coin coin = listBox_Chosen_Coins.SelectedItem as Coin;
                    MoveSelectedItemBetweenListBox(listBox_Chosen_Coins, listBox_Potential_Coins, false);

                    coinArr.Remove(coin);
                    CoinArrToForm(listBox_Chosen_Coins, coinArr);
                }
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {

            //Create an trade from the form

            Trade trade = FormToTrade();
            TradeCoinArr tradeCoinArr_Old = new TradeCoinArr();
            tradeCoinArr_Old.Fill();

            if (trade.Id != 0)
            {
                if (trade.Delete()) //Update the trade in db
                {
                    //If successful, need to update trade in TradeCoin db as well!

                    tradeCoinArr_Old = tradeCoinArr_Old.Filter(trade);
                    //Delete all TradeCoin (all items of trade itself) for this trade
                    if (tradeCoinArr_Old.Delete())
                    {
                        MessageBox.Show("Deleted successfully", "Success", MessageBoxButtons.OK);
                        TradeArrToForm();
                    }
                }//Finally, insert the TradeCoinArr to db
                
                ClearAll();
            }
            else { MessageBox.Show("Please select a trade before deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }



        private void button_FetchCoinPrice_Click(object sender, EventArgs e)
        {
            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            CoinQuoteArr cqArr = Helpers.FillCoinQuoteArrFromApi(coinArr);
            cqArr.Insert();
            QuoteToForm(cqArr.LatestQuote(curCoin));
        }
        #endregion




        private void textBox_Filter_Id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32((sender as TextBox).Text);
                TradeArr tradeArr = new TradeArr();
                tradeArr.Fill();
                tradeArr = tradeArr.Filter(id: id);
                TradeArrToForm(tradeArr);
            }
            catch { TradeArrToForm(); } //If it's not a number, just put all the trades
        }
        private void textBox_Filter_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || char.IsControl(e.KeyChar))) //If is not number
                e.KeyChar = Char.MinValue; //Don't let him write
        }

    }
}
