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

    public partial class TradeForm : Form
    {
        #region Helpers
        #region Clear Helpers
        private void ClearDetails()
        {
            //Clear Filter
            foreach (TextBox tb in groupBox_Filter_Details.Controls.OfType<TextBox>())
                tb.Text = String.Empty;
            dateTimePicker_Filter_From.Checked = false;
            dateTimePicker_Filter_To.Checked = false;
            dateTimePicker_Filter_To.Value = DateTime.Now;
            dateTimePicker_Filter_From.Value = DateTime.Now;
            text_Id.Text = "0";
            textBox_Memo.Text = String.Empty;
            dateTimePicker_Date.Value = DateTime.Now;
        }
        private void ClearClient()
        {
            foreach (TextBox tb in groupBox_Filter_Client.Controls.OfType<TextBox>())
                tb.Text = String.Empty;
            ClientToForm(null);
            ClientArrToForm(listBox_Clients);

        }
        private void ClearItems()
        {
            textBox_Coin_Filter_Name.Text = String.Empty;
            comboBox_Coin_Filter_Valid.SelectedValue = -1;
            comboBox_Coin_Filter_Scam.SelectedValue = -1;
            listBox_Chosen_Coins.Items.Clear(); //Clear coins listbox
            listBox_Chosen_Coins_Count.Items.Clear(); //Clear count listbox

            SetCoinsByFilter();


        }
        private void ClearAll() { ClearClient(); ClearDetails(); ClearItems(); }
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
        private void MoveSelectedItemBetweenListBox(ListBox listBox_From, ListBox listBox_To,bool isToTrade)
        {
            // Moves coins between potential and wanted listbox
            CoinArr coinArr = null;
            Coin selectedItem = listBox_From.SelectedItem as Coin;
            if (isToTrade)
            {
                selectedItem.Count--;
                listBox_Chosen_Coins_Count.Items.Add(1);
            }
            else
            {
                (selectedItem as Coin).Count += (int)listBox_Chosen_Coins_Count.SelectedItem;
                listBox_Chosen_Coins_Count.Items.RemoveAt(listBox_Chosen_Coins_Count.SelectedIndex);
            }
            //Find selected coin

            Coin selectedCoin = listBox_From.SelectedItem as Coin;

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
            if ( isToTrade)
            {
                int k = listBox_To.Items.Count - 1;
                listBox_To.SelectedIndex = k;
                listBox_Chosen_Coins_Count.SelectedIndex = k;
            }
        }
        #endregion
        public TradeForm()
        {
            InitializeComponent();
            CoinArrToForm(listBox_Potential_Coins);
            ClientArrToForm(listBox_Clients);
            ValidArrToForm();
            ScamArrToForm();
            TradeArrToForm();
        }
        #region XToForm

        private void ClientArrToForm(ListBox lb)
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            lb.DataSource = clientArr;
            listBox_Clients.ValueMember = "ID"; //Value is client ID
            listBox_Clients.DisplayMember = ""; //Use the ToString
        }
        private void ClientToForm(Client c = null)
        {
            if (c == null) {
                text_ClientInfo_BtcAddress.Text = "";
                text_ClientInfo_FirstName.Text = "";
                text_ClientInfo_LastName.Text = "";
                text_Client.Text = "No client chosen";
            }
            else{
                text_ClientInfo_BtcAddress.Text = c.BtcAddress;
                text_ClientInfo_FirstName.Text = c.LastName;
                text_ClientInfo_LastName.Text = c.FirstName;
                text_Client.Text = c.ToString();

            }
        }

        private void TradeToForm(Trade trade = null)
        {
            if (trade != null)
            {
                Client c = trade.Client;
                listBox_Trades.SelectedValue = trade.Id;
                text_Id.Text = trade.Id.ToString();
                textBox_Memo.Text = trade.Memo;
                
            }
            else
            {
                listBox_Trades.SelectedValue = -1;
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
            listBox_Trades.DataSource = tArr;
            listBox_Trades.ValueMember = "Id";
            listBox_Trades.DisplayMember = "";
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
            listBox.ValueMember = "Id";
            listBox.DisplayMember = "";
        }
        private void CoinArrCountToForm(TradeCoinArr curTradeCoinArr)
        {
            listBox_Chosen_Coins_Count.Items.Clear(); //Clear listbox
            for (int i = 0; i < curTradeCoinArr.Count; i++)
            {
                listBox_Chosen_Coins_Count.Items.Add((curTradeCoinArr[i] as TradeCoin).Count); //Add count manually (not datasource)
            }

            //Select the first line right away

            if (listBox_Chosen_Coins_Count.Items.Count > 0)
                listBox_Chosen_Coins_Count.SelectedIndex = 0;
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

                //Count of Coins for current TradeCoin
                tradeCoin.Count = (long) listBox_Chosen_Coins_Count.Items[i];

                //Add current tradecoin pair to array

                tradeCoinArr.Add(tradeCoin);
            }
            return tradeCoinArr;
        }
        private Trade FormToTrade()
        {
            Trade trade = new Trade();
            trade.Client = listBox_Clients.SelectedItem as Client;
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

        private void button_Save_Click(object sender, EventArgs e) { 
        
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
                        (listBox_Chosen_Coins.DataSource as CoinArr).UpdateCount();

                    }

                    else
                        MessageBox.Show("Error in insert");

                    ClearAll();
                    TradeArr tradeArr_New = new TradeArr();
                    tradeArr_New.Fill();
                    TradeArrToForm(tradeArr); // Do this add the new trade to the list

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
                    if (tradeCoinArr_New.Insert()) {
                        MessageBox.Show("Updated successfully");
                        (listBox_Chosen_Coins.DataSource as CoinArr).UpdateCount();

                        (listBox_Potential_Coins.DataSource as CoinArr).UpdateCount();
                    }
                    else { MessageBox.Show("Update Failed"); }//Finally, insert the TradeCoinArr to db
          
                    ClearAll();
                }
                else MessageBox.Show("Error in insert/update");
            }
        }
        #endregion
        #region Event Functions
        private void listBox_Trades_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //When Trade selected:
            ListBox lb = sender as ListBox;
            Trade curTrade = lb.SelectedItem as Trade;

            if (curTrade != null)
            {
                //Trade to form (First Page)
                TradeToForm(curTrade);
            }
            ClientToForm(curTrade.Client); //Client to form with current trade
            listBox_Clients.SelectedValue = curTrade.Client.Id; //Change selected value for client listbox
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
            CoinArrCountToForm(tradeCoinArr);

            //Update Potential listbox: all coins, except already chosen     ones

            CoinArr coinArrNotInTrade = new CoinArr();
            coinArrNotInTrade.Fill();


            coinArrNotInTrade.Remove(coinArrInTrade); //Remove all coins already in the trade
            CoinArrToForm(listBox_Potential_Coins, coinArrNotInTrade); //Put them in the potential listbox
        }

        private void listBox_Potential_Coins_DoubleClick(object sender, EventArgs e)
        {
            //Move selected coin from potential list of coins to list of chosen coins

            ListBox potentialListBox = sender as ListBox;
            MoveSelectedItemBetweenListBox(potentialListBox, listBox_Chosen_Coins,true);
        }
        private void listBox_Client_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm((sender as ListBox).SelectedItem as Client);
        }

        private void textBox_Filter_LastName_KeyUp(object sender, KeyEventArgs e)
        {
            //Create an array of Coins

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //Filter the array in the fields that the user requested

            clientArr = clientArr.Filter(lastName: (sender as TextBox).Text);

            //Put it in the listbox

            listBox_Clients.DataSource = clientArr;
        }
        private void textBox_Filter_BtcAddress_KeyUp(object sender, KeyEventArgs e)
        {
            //Create an array of Coins

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //Filter the array in the fields that the user requested

            clientArr = clientArr.Filter(btcAddress: (sender as TextBox).Text);

            //Put it in the listbox

            listBox_Clients.DataSource = clientArr;
        }
        #endregion

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
            listBox_Chosen_Coins_Count.SelectedIndex = listBox_Chosen_Coins.SelectedIndex;
        }

        private void listBox_Chosen_Coins_Count_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Chosen_Coins.SelectedIndex = listBox_Chosen_Coins_Count.SelectedIndex;

        }


        private void button_Plus_Coin_Click(object sender, EventArgs e)
        {
            if (listBox_Chosen_Coins_Count.SelectedIndex >= 0)
            {
                if ((listBox_Chosen_Coins.SelectedItem as Coin).Count > 0) //Check if at least one in stock (or trade?)
                { //If yes, add to TradeCoin and remove from stock
                    int k = listBox_Chosen_Coins_Count.SelectedIndex;
                    //Update the product inside the chosen coins listbox
                    listBox_Chosen_Coins_Count.Items[k] = (int)listBox_Chosen_Coins_Count.Items[k] + 1;
                    //Remove from stock, update coin amount in list of coins in trade
                    CoinArr coinArr = listBox_Chosen_Coins.DataSource as CoinArr;
                    Coin coin = listBox_Chosen_Coins.SelectedItem as Coin;
                    coin.Count--;
                    coinArr.UpdateCoin(coin);
                    CoinArrToForm(listBox_Chosen_Coins, coinArr);
                }
                else MessageBox.Show("There aren't enough in stock for that","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button_Minus_Coin_Click(object sender, EventArgs e)
        {
            if (listBox_Chosen_Coins_Count.SelectedIndex >= 0)
            {
                if (Convert.ToInt64(listBox_Chosen_Coins_Count.SelectedItem) > 1) //Check if at least one in stock (or trade?)
                { //If yes, add to TradeCoin and remove from stock
                    int k = listBox_Chosen_Coins_Count.SelectedIndex;
                    //Update the product inside the chosen coins listbox
                    listBox_Chosen_Coins_Count.Items[k] = (int)listBox_Chosen_Coins_Count.Items[k] - 1;
                    //Remove from stock, update coin amount in list of coins in trade
                    CoinArr coinArr = listBox_Chosen_Coins.DataSource as CoinArr;
                    Coin coin = listBox_Chosen_Coins.SelectedItem as Coin;
                    coin.Count++; //Update stock
                    coinArr.UpdateCoin(coin);
                    CoinArrToForm(listBox_Chosen_Coins, coinArr);
                }
                else MessageBox.Show("There aren't enough selected for that", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
