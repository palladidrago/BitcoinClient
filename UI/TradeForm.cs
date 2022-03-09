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
        //private void FillForm()
        //{
        //    TradeArr tarr = new TradeArr();
        //    tarr.Fill();
        //}
        private void CoinArrToForm(ListBox listBox, CoinArr coinArr)
        {
            listBox.DataSource = coinArr;
            listBox.ValueMember = "Id";
            listBox.DisplayMember = "Name";
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
        //private void save()
        //{
        //    TradeCoin td = null;
        //    for(; ;) //Incomplete
        //        td = new Trade( trade,  coin);
        //        td.Insert();
        //}
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
