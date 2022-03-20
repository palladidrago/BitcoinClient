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
        Trade curTrade;
        public TradeForm()
        {
            InitializeComponent();
            CoinArrToForm(listBox_Potential_Coins);
            ClientArrToForm(listBox_Client);
        }
        private void ClientArrToForm(ListBox lb)
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            lb.DataSource = clientArr;
        }
        private void MoveSelectedItemBetweenListBox(ListBox listBox_From, ListBox listBox_To)
        {
            //Moves coins between potential and wanted listbox
            CoinArr coinArr = null;

            //Find the selected coin

            Coin selectedCoin = listBox_From.SelectedItem as Coin;

            //Add the potential coin to the list of coins
            //If the are already coins in the potential list


            if (listBox_To.DataSource != null)
                coinArr = listBox_To.DataSource as CoinArr;
            else
                coinArr = new CoinArr();
            coinArr.Add(selectedCoin);
            CoinArrToForm(listBox_To, coinArr);
        }
        

        private void button_Save_Click(object sender, EventArgs e)
        {

        }
        private void TradeArrToForm()
        {
            //Fill in trade listbox autmatically
            TradeArr tArr = new TradeArr();
            tArr.Fill();
            listBox_Trades.DataSource = tArr;
        }
        private void TradeToForm(Trade trade)
        {
            Client c = trade.client;
            listBox_Trades.SelectedValue = trade.id;
            listBox_Trades.SelectedItem = trade;
        }
        //private bool CheckForm()
        //{
        //    //Check that each of the textboxes on the form are good

        //    bool flag = true;
        //    #region FirstName
        //    if (textBox_FirstName.Text.Length < 2)
        //    {
        //        flag = false;
        //        textBox_FirstName.BackColor = Color.Red;
        //    }
        //    else
        //        textBox_FirstName.BackColor = Color.White;
        //    #endregion 


        //    #region ShoeSize
        //    if (textBox_ShoeSize.Text != "")
        //    {

        //        try
        //        {
        //            int.Parse(textBox_ShoeSize.Text);
        //            textBox_ShoeSize.BackColor = Color.White;
        //        }
        //        catch
        //        {
        //            textBox_ShoeSize.BackColor = Color.Red;
        //            flag = false;
        //        }
        //    }
        //    else
        //    {
        //        textBox_ShoeSize.BackColor = Color.Red;
        //        flag = false;
        //    }

        //    #endregion

        //    #region City
        //    if ((int)comboBox_City.SelectedValue <= 0)
        //    {
        //        flag = false;
        //        comboBox_City.ForeColor = Color.Red;
        //    }
        //    else comboBox_City.ForeColor = Color.Black;

        //    #endregion
        //    return flag;
        //}
        //private void save()
        //{
        //    TradeCoin td = null;
        //    for(; ;) //Incomplete
        //        td = new Trade( trade,  coin);
        //        td.Insert();
        //}
        private void CoinArrToForm(ListBox listBox, CoinArr coinArr = null)
        {

            //מקבלת אוסף פריטים ותיבת רשימה לפריטים ומציבה את האוסף בתוך התיבה
            //אם האוסף ריק - מייצרת אוסף חדש מלא בכל הערכים מהטבלה

            listBox.DataSource = null;
            if (coinArr == null)
            {
                coinArr = new CoinArr();
                coinArr.Fill();
            }
            listBox.DataSource = coinArr;
            listBox.ValueMember = "Id";
            listBox.DisplayMember = "Name";
        }
        private TradeCoinArr FormToTradeCoinArr(Trade curTrade)
        {

            // Creation of TradeCoinArr from form
            // Create pairs of Trade and Coin (the trade is always the same, the coin is fetched from the list)
            TradeCoinArr tradeCoinArr = new TradeCoinArr();
            TradeCoin tradeCoin;

            //סורקים את כל הערכים בתיבת הרשימה של המוצרים שנבחרו להזמנה
            for (int i = 0; i < listBox_Chosen_Coins.Items.Count; i++)
            {
                tradeCoin = new TradeCoin();

                //ההזמנה הנוכחית היא ההזמנה לכל הזוגות באוסף

                tradeCoin.trade = curTrade;

                //מוצר נוכחי לזוג הזמנה-מוצר

                tradeCoin.coin = listBox_Chosen_Coins.Items[i] as Coin;

                //הוספת הזוג הזמנה -מוצר לאוסף

                tradeCoinArr.Add(tradeCoin);
            }
            return tradeCoinArr;
        }
        private void listBox_Trades_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;
            curTrade = lb.SelectedItem as Trade;

            if (curTrade != null)
            {
                TradeToForm(curTrade);
            }
        }
    }
}
