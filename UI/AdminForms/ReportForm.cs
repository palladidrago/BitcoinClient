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
    public partial class ReportForm : Form
    {
        int curReport = 1;
        private void EnableFilters(bool firstFilter, bool secondFilter)
        {
            label_Filter_1.Visible = firstFilter;
            textBox_Filter_1.Visible = firstFilter;

            label_Filter_1.Enabled = firstFilter;
            textBox_Filter_1.Enabled = firstFilter;

            label_Filter_2.Visible = secondFilter;
            textBox_Filter_2.Visible = secondFilter;

            label_Filter_2.Enabled = secondFilter;
            textBox_Filter_2.Enabled = secondFilter;
        }
        //public void ScamArrToForm()
        //{
        //    //From Scam array to form 
        //    ScamArr scamArr = new ScamArr();
        //    Scam scamDefault = new Scam();
        //    scamDefault.Id = -1;
        //    scamDefault.Name = "Choose a scam level";


        //    scamArr.Add(scamDefault);
        //    scamArr.Fill();


        //}
        //public void ValidArrToForm()
        //{
        //    //From Valid array to form 
        //    ValidArr validArr = new ValidArr();
        //    Valid validDefault = new Valid();
        //    validDefault.Id = -1;
        //    validDefault.Name = "Choose a validation method";


        //    validArr.Add(validDefault);
        //    validArr.Fill();

        //    comboBox_Filter_Valid.DataSource = validArr;
        //    comboBox_Filter_Valid.ValueMember = "Id";
        //    comboBox_Filter_Valid.DisplayMember = "";

        //}
        Bitmap bmp;
        Color buttonColor;
        private int lastColumnSortBy = -1;
        private SortOrder lastSortOrder = SortOrder.Ascending;
        Button curButton;
        public ReportForm()
        {
            InitializeComponent();
            FillListView1();
            curButton = button_CoinReport as Button;
            curButton.Enabled = false;
        }

      

        //private void comboBox_Filter_Valid_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //Create array
        //    CoinArr coinArr = new CoinArr();
        //    coinArr.Fill();
        //    //Filter by valid
        //    coinArr = coinArr.Filter(valid: (sender as ComboBox).SelectedItem as Valid);

        //    listView_Report.Items.Clear();
        //    FillListView1(coinArr);
        //}

        //private void comboBox_Filter_Scam_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //Create array
        //    CoinArr coinArr = new CoinArr();
        //    coinArr.Fill();
        //    //Filter by scam
        //    coinArr = coinArr.Filter(scam: (sender as ComboBox).SelectedItem as Scam);

        //    listView_Report.Items.Clear();
        //    FillListView1(coinArr);
        //}

        //private void numericUpDown_Supply_ValueChanged(object sender, EventArgs e)
        //{
        //    //Create array
        //    CoinArr coinArr = new CoinArr();
        //    coinArr.Fill();
        //    //Filter by scam
        //    coinArr = coinArr.Filter(count: Convert.ToInt64((sender as NumericUpDown).Value));

        //    listView_Report.Items.Clear();
        //    FillListView1(coinArr);
        //}




        private void CaptureScreen()
        {
            GroupBox c = groupBox1 as GroupBox;
            bmp = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));

        }
        private void button_Print_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Width = 800; printPreviewDialog.Height = 800;
            printPreviewDialog.ShowDialog();
        }
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }


        private void pictureBox_Print_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = buttonColor;
        }

        private void pictureBox_Print_MouseEnter(object sender, EventArgs e)
        {
            buttonColor = (sender as PictureBox).BackColor;
            (sender as PictureBox).BackColor = Color.Azure;
        }
        private void listView_Report_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_Report.ListViewItemSorter = sorter;
            sorter = listView_Report.ListViewItemSorter as ListViewSorter;
            sorter.ByColumn = e.Column;

            // If click on the same column, the sort will be backwards to what it was 
            if (lastColumnSortBy == e.Column)
                if (lastSortOrder == SortOrder.Ascending)
                    sorter.SortOrder = SortOrder.Descending;
                else
                    sorter.SortOrder = SortOrder.Ascending;

            // If it's a new column, it will be in ascending order

            else
                sorter.SortOrder = SortOrder.Ascending;
            listView_Report.Sort();

            // ??
            lastColumnSortBy = e.Column;

            //Save the last sort
            lastSortOrder = sorter.SortOrder;
        }

        private void button_CoinReport_Click(object sender, EventArgs e)
        {
            listView_Report.Items.Clear();
            curButton.Enabled = true;
            curButton = sender as Button;
            curButton.Enabled = false;
            label_Title_Report.Text = "Coin Report";
            curReport = 1;
            EnableFilters(true, false); //Enable first filter only
            label_Filter_1.Text = "Coin Name";
            FillListView1();
        }

        private void button_ClientCoinReport_Click(object sender, EventArgs e)
        {
            listView_Report.Items.Clear();
            curButton.Enabled = true;
            curButton = sender as Button;
            curButton.Enabled = false;
            label_Title_Report.Text = "Client Coin Report";
            curReport = 2;
            EnableFilters(true, true);
            label_Filter_1.Text = "Coin Name";
            label_Filter_2.Text = "Client Name";
            FillListView2();
        }

        private void button_ClientCountryReport_Click(object sender, EventArgs e)
        {
            listView_Report.Items.Clear();
            curButton.Enabled = true;
            curButton = sender as Button;
            curButton.Enabled = false;
            label_Title_Report.Text = "Client Country Report";
            curReport = 3;
            EnableFilters(true, false);
            label_Filter_1.Text = "Country Name";
            FillListView3();
        }

        private void button_ValidReport_Click(object sender, EventArgs e)
        {
            listView_Report.Items.Clear();
            curButton.Enabled = true;
            curButton = sender as Button;
            curButton.Enabled = false;
            label_Title_Report.Text = "Valid Report";
            curReport = 4;
            EnableFilters(true, false);
            label_Filter_1.Text = "Validation method";
            FillListView4();
        }

        private void button_ScamLevels_Click(object sender, EventArgs e)
        {
            listView_Report.Items.Clear();
            curButton.Enabled = true;
            curButton = sender as Button;
            curButton.Enabled = false;
            label_Title_Report.Text = "Scam Level Report";
            curReport = 5;
            EnableFilters(true, false);
            label_Filter_1.Text = "Scam level";
            FillListView5();
        }

        private void button_TradeClientCount_Click(object sender, EventArgs e)
        {
            listView_Report.Items.Clear();
            curButton.Enabled = true;
            curButton = sender as Button;
            curButton.Enabled = false;
            label_Title_Report.Text = "Trade Client Count";
            curReport = 6;
            EnableFilters(true, false);
            label_Filter_1.Text = "Client name";
            FillListView6();
        }

        private void button_CoinQuoteReport_Click(object sender, EventArgs e)
        {
            listView_Report.Items.Clear();
            curButton.Enabled = true;
            curButton = sender as Button;
            curButton.Enabled = false;
            label_Title_Report.Text = "Coin Quote Report";
            curReport = 7;
            EnableFilters(true, false);
            label_Filter_1.Text = "Coin Name";
            FillListView7();
        }
        #region FillListView

        private void FillListView1(CoinArr coinArr = null)
        {

            listView_Report.Columns.Clear();
            listView_Report.Columns.Add("Name", listView_Report.Width / 4);
            listView_Report.Columns.Add("Validation method", listView_Report.Width / 4);

            listView_Report.Columns.Add("Scam level", listView_Report.Width / 4);
            listView_Report.Columns.Add("Supply", listView_Report.Width / 4);
            //Add date to listview
            //Create coin arr
            if (coinArr == null)
            {
                coinArr = new CoinArr();
                coinArr.Fill();
            }
            Coin c;
            ListViewItem listViewItem;

            //Go over all the items in the source and add them to listview

            for (int i = 0; i < coinArr.Count; i++)
            {
                c = coinArr[i] as Coin;

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { c.Name,

                    c.Valid.Name, c.Scam.Name, c.Supply.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Report.Items.Add(listViewItem);
            }
        }
        private void FillListView2()
        {
            listView_Report.Columns.Clear();
            listView_Report.Columns.Add("Client", listView_Report.Width / 4);
            listView_Report.Columns.Add("Top Coin", listView_Report.Width / 4);

            listView_Report.Columns.Add("Second Top Coin", listView_Report.Width / 4);
            listView_Report.Columns.Add("Third Top Coin", listView_Report.Width / 4);

            Client client;
            TradeCoinArr tCArr = new TradeCoinArr();
            tCArr.Fill();
            ListViewItem listViewItem;
            
            TradeCoinArr top3tCArr;
            //Go over all the items in the source and add them to listview
            int prevClientId = 0;
            for (int i = 0; i < tCArr.Count; i++)
            {

                client = (tCArr[i] as TradeCoin).Trade.Client;
                if (client.Id != prevClientId)
                {
                    prevClientId = client.Id;
                    top3tCArr = tCArr.FilterNoDuplicates().GetTop3TradeCoinForClient(client);
                    TradeCoin tC1; TradeCoin tC2; TradeCoin tC3;
                    try{tC1 = (top3tCArr[0] as TradeCoin);}
                    catch { tC1 = null; }

                    try {tC2 = (top3tCArr[1] as TradeCoin);}
                    catch { tC2 = null; }

                    try { tC3 = (top3tCArr[2] as TradeCoin); }
                    catch{ tC3 = null; }
                    string coinName1 = "", coinCount1 ="";
                    string coinName2 = "", coinCount2 = "";
                    string coinName3 = "", coinCount3 = "";
                    if (tC1 != null) { coinName1 = tC1.Coin.Name; coinCount1 = tC1.Count.ToString();}
                    if (tC2 != null) { coinName2 = tC2.Coin.Name; coinCount2 = tC2.Count.ToString(); }
                    if (tC3 != null) { coinName3 = tC3.Coin.Name; coinCount3 = tC3.Count.ToString(); }
                    listViewItem = new ListViewItem(new[] {
                        client.ToString(),
                        $"{coinName1} ({coinCount1})",
                        $"{coinName2} ({coinCount2})",
                        $"{coinName3} ({coinCount3})"});;
                    listView_Report.Items.Add(listViewItem);
                }
            }
        }
        private void FillListView3()
        {
            listView_Report.Columns.Clear();
            listView_Report.Columns.Add("Country name", listView_Report.Width / 2);
            listView_Report.Columns.Add("Client count", listView_Report.Width / 2);

            //Add date to listview
            //Create coin arr
            ClientArr clArr = new ClientArr();
            clArr.Fill();

            CountryArr countryArr = new CountryArr();
            countryArr.Fill();

            ListViewItem listViewItem;
            ClientArr newClArr;
            Country curCountry;
            //Go over all the items in the source and add them to listview

            for (int i = 0; i < countryArr.Count; i++)
            {
                curCountry = countryArr[i] as Country;
                newClArr = clArr.Filter(country: curCountry);

                if (newClArr.Count != 0)
                {
                    //יצירת פריט-תיבת-תצוגה
                    listViewItem = new ListViewItem(new[] { curCountry.Name,

                    newClArr.Count.ToString()});
                    //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                    listView_Report.Items.Add(listViewItem);
                }
            }

        }
        private void FillListView4()
        {
            listView_Report.Columns.Clear();
            listView_Report.Columns.Add("Valid method", listView_Report.Width / 2);
            listView_Report.Columns.Add("Count", listView_Report.Width / 2);

            //Add date to listview
            //Create coin arr
            ValidArr vArr = new ValidArr();
            vArr.Fill();

            CoinArr coinArr = new CoinArr();
            coinArr.Fill();

            ListViewItem listViewItem;
            Valid curValid;
            CoinArr newCoinArr;
            //Go over all the items in the source and add them to listview

            for (int i = 0; i < vArr.Count; i++)
            {
                curValid = vArr[i] as Valid;
                newCoinArr = coinArr.Filter(valid: curValid);

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { curValid.Name,

                    newCoinArr.Count.ToString()});
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Report.Items.Add(listViewItem);
            }
        }
        private void FillListView5()
        {
            listView_Report.Columns.Clear();
            listView_Report.Columns.Add("Scam level", listView_Report.Width / 2);
            listView_Report.Columns.Add("Count", listView_Report.Width / 2);

            //Add date to listview
            //Create coin arr
            ScamArr sArr = new ScamArr();
            sArr.Fill();

            CoinArr coinArr = new CoinArr();
            coinArr.Fill();

            ListViewItem listViewItem;
            Scam curScam;
            CoinArr newCoinArr;
            //Go over all the items in the source and add them to listview

            for (int i = 0; i < sArr.Count; i++)
            {
                curScam = sArr[i] as Scam;
                newCoinArr = coinArr.Filter(scam: curScam);

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { curScam.Name,

                    newCoinArr.Count.ToString()});
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Report.Items.Add(listViewItem);
            }
        }
        private void FillListView6()
        {
            listView_Report.Columns.Clear();
            listView_Report.Columns.Add("Client", listView_Report.Width / 2);
            listView_Report.Columns.Add("Trade Count", listView_Report.Width / 2);

            //Add date to listview
            //Create coin arr
            TradeArr tArr = new TradeArr();
            tArr.Fill();
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            ListViewItem listViewItem;
            Client curClient;
            TradeArr newTradeArr;
            //Go over all the items in the source and add them to listview

            for (int i = 0; i < clientArr.Count; i++)
            {
                curClient = clientArr[i] as Client;
                newTradeArr = tArr.Filter(client: curClient);

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { curClient.ToString(),

                    newTradeArr.Count.ToString()});
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Report.Items.Add(listViewItem);
            }
        }
        private void FillListView7()
        {
            listView_Report.Columns.Clear();
            listView_Report.Columns.Add("Coin", listView_Report.Width / 2);
            listView_Report.Columns.Add("Latest Quote", listView_Report.Width / 2);


            CoinArr cArr = new CoinArr();
            cArr.Fill();
            CoinQuoteArr cQArr = new CoinQuoteArr();
            cQArr.Fill();
            Quote curQuote;
            Coin curCoin;
            //Go over all the items in the source and add them to listview
            ListViewItem listViewItem;

            for (int i = 0; i < cArr.Count; i++)
            {

                curCoin = (cArr[i] as Coin);
                curQuote = cQArr.LatestQuote(curCoin);

                listViewItem = new ListViewItem(new[] {
                    curCoin.Name,

                curQuote.Price.ToString("0.00") + "$"});
                listView_Report.Items.Add(listViewItem);
            }
        }

        private void textBox_Filter_1_KeyUp(object sender, KeyEventArgs e)
        {
            string text = (sender as TextBox).Text;
            listView_Report.Items.Clear();

            switch (curReport)
            {
                case 1:
                    //Coin Report //Filter by coin only

                    FillListView1();
                    
                    foreach (ListViewItem l in listView_Report.Items)
                        if (!l.SubItems[0].Text.ToLower().Contains(text))
                            l.Remove();
                    break;
                case 2:
                    //Client coin report //Filter by coin here

                    FillListView2();

                    foreach (ListViewItem l in listView_Report.Items)
                        if (!l.SubItems[1].Text.ToLower().Contains(text))
                            l.Remove();
                    break;
                case 3:
                    //Client country report //Filter by country here

                    FillListView3();

                    foreach (ListViewItem l in listView_Report.Items)
                        if (!l.SubItems[0].Text.ToLower().Contains(text))
                            l.Remove();
                    break;
                case 4:
                    //Validation method report //Filter by valid only

                    FillListView4();

                    foreach (ListViewItem l in listView_Report.Items)
                        if (!l.SubItems[0].Text.ToLower().Contains(text))
                            l.Remove();
                    break;
                case 5:
                    //Scam level report //Filter by scam only

                    FillListView5();

                    foreach (ListViewItem l in listView_Report.Items)
                        if (!l.SubItems[0].Text.ToLower().Contains(text))
                            l.Remove();
                    break;
                case 6:
                    //TradeClient report //only filter by client

                    FillListView6();

                    foreach (ListViewItem l in listView_Report.Items)
                        if (!l.SubItems[0].Text.ToLower().Contains(text))
                            l.Remove();
                    break;
                case 7:
                    //Coin Quote report //only filter by coin
                    FillListView7();

                    foreach (ListViewItem l in listView_Report.Items)
                        if (!l.SubItems[0].Text.ToLower().Contains(text))
                            l.Remove();
                    
                    break;

            }
        }

        private void textBox_Filter_2_KeyUp(object sender, KeyEventArgs e)
        {
            string text = (sender as TextBox).Text;
            listView_Report.Items.Clear();

            switch (curReport)
            {
                case 2:
                    //Client coin report //Filter by Client here

                    FillListView2();

                    foreach (ListViewItem l in listView_Report.Items)
                        if (!l.SubItems[1].Text.ToLower().Contains(text))
                            l.Remove();
                    break;
            }
        }
    }
    #endregion
}
