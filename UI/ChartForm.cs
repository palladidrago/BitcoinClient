using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BL;

namespace ClientApp.UI
{
    public partial class ChartForm : Form
    {
        Bitmap bmp;
        public ChartForm()
        {
            InitializeComponent();
            curLabel = roundLabel_ClientCountry;
            curLabel.Enabled = false;
            label_Title.Text = "Country Client";
            DataToChart1();
        }
        Color oldColor;
        RoundLabel curLabel;
        public void DataToChart1()
        {
            chart_Report.Palette = ChartColorPalette.SeaGreen;
            chart_Report.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart_Report.Titles.Clear();
            chart_Report.Titles.Add("Distribution of customers by locality");
            ClientArr curClientArr = new ClientArr();
            curClientArr.Fill();
            SortedDictionary<string, int> dictionary = curClientArr.GetSortedDictionary();


            Series series = new Series("Distribution");


            series.ChartType = SeriesChartType.Column;

            series.Label = "#VALX [#VAL = #PERCENT{P0}]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);
            //מחיקת סדרות קיימות - אם יש ולא בכוונה

            chart_Report.Series.Clear();

            //הוספת הסדרה לפקד הגרף

            chart_Report.Series.Add(series);
        }
        public void DataToChart2() {

            //Top coins per client
            chart_Report.Palette = ChartColorPalette.Chocolate;
            chart_Report.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart_Report.Titles.Clear();
            chart_Report.Titles.Add("Coins per client");

            Series series = new Series("Coins");
            series.ChartType = SeriesChartType.Bar;


            Client client = new Client();
            TradeCoinArr tCArr = new TradeCoinArr();
            tCArr.Fill();
            //Go over all the items in the source and add them to chart
            int prevClientId = 0;
            List<string> x = new List<string>();

            List<long> y = new List<long>();
            long coinCount;
            for (int i = 0; i < tCArr.Count; i++)
            {

                client = (tCArr[i] as TradeCoin).Trade.Client;
                if (client.Id != prevClientId)
                {
                    prevClientId = client.Id;
                    coinCount = tCArr.CoinAmountPerClient(client);

                    x.Add(client.FirstName);
                    y.Add(coinCount);

                }
            }

            series.Label = "#VALX [#VAL = #PERCENT{P0}]";
            series.Points.DataBindXY(x,y);
            //מחיקת סדרות קיימות - אם יש ולא בכוונה

            chart_Report.Series.Clear();

            //הוספת הסדרה לפקד הגרף

            chart_Report.Series.Add(series);
        }

        public void DataToChart3()
        {
            // Amount of coins per validation method
            chart_Report.Palette = ChartColorPalette.Fire;
            chart_Report.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart_Report.Titles.Clear();
            chart_Report.Titles.Add("Amount of coins per validation methods ");

            Series series = new Series("Coin amount");
            series.ChartType = SeriesChartType.Bar;


            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            ValidArr validArr = new ValidArr();
            validArr.Fill();
            Valid curValid;
            //Go over all the items in the source and add them to chart
            List<string> x = new List<string>();
            List<int> y = new List<int>();
            int coinCount;
            for (int i = 0; i < validArr.Count; i++)
            {
                curValid = (validArr[i] as Valid);
                coinCount = coinArr.Filter(valid: curValid ).Count;

                x.Add(curValid.Name);
                y.Add(coinCount);
            }

            series.Label = "#VALX [#PERCENT{P0}]";
            series.Points.DataBindXY(x, y);
            //מחיקת סדרות קיימות - אם יש ולא בכוונה

            chart_Report.Series.Clear();

            //הוספת הסדרה לפקד הגרף

            chart_Report.Series.Add(series);
        }

        public void DataToChart4()
        {
            // Amount of coins per validation method
            chart_Report.Palette = ChartColorPalette.Pastel;
            chart_Report.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart_Report.Titles.Clear();
            chart_Report.Titles.Add("Amount of coins per scam levels");

            Series series = new Series("Coin amount");
            series.ChartType = SeriesChartType.Pie;


            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            ScamArr scamArr = new ScamArr();
            scamArr.Fill();
            Scam curScam;
            //Go over all the items in the source and add them to chart
            List<string> x = new List<string>();
            List<int> y = new List<int>();
            int coinCount;
            for (int i = 0; i < scamArr.Count; i++)
            {
                curScam = (scamArr[i] as Scam);
                coinCount = coinArr.Filter(scam: curScam).Count;

                x.Add(curScam.Name);
                y.Add(coinCount);
            }

            series.Label = "#VALX [#PERCENT{P0}]";
            series.Points.DataBindXY(x, y);
            //מחיקת סדרות קיימות - אם יש ולא בכוונה

            chart_Report.Series.Clear();

            //הוספת הסדרה לפקד הגרף

            chart_Report.Series.Add(series);
        }
        public void DataToChart5()
        {
            //How many trades per client
            chart_Report.Palette = ChartColorPalette.Berry;
            chart_Report.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart_Report.Titles.Clear();
            chart_Report.Titles.Add("Trades per client");
            Series series = new Series("Trades");
            series.ChartType = SeriesChartType.Bar;
            //Create coin arr
            TradeArr tArr = new TradeArr();
            tArr.Fill();
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            Client curClient;
            TradeArr newTradeArr;
            //Go over all the items in the source and add them to chart
            List<string> x = new List<string>();
            List<int> y = new List<int>();
            for (int i = 0; i < clientArr.Count; i++)
            {
                curClient = clientArr[i] as Client;
                newTradeArr = tArr.Filter(client: curClient);

                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                x.Add(curClient.FirstName);
                y.Add(newTradeArr.Count);
            }
            series.Label = "#VALX [#PERCENT{P0}]";
            series.Points.DataBindXY(x, y);
            //מחיקת סדרות קיימות - אם יש ולא בכוונה

            chart_Report.Series.Clear();

            //הוספת הסדרה לפקד הגרף

            chart_Report.Series.Add(series);
        }
        public void DataToChart6() {
            chart_Report.Palette = ChartColorPalette.Berry;
            chart_Report.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart_Report.Titles.Clear();
            Series series = new Series("Price");
            chart_Report.Titles.Add("Latest coin prices");

            series.ChartType = SeriesChartType.Bar;

            CoinArr cArr = new CoinArr();
            cArr.Fill();
            CoinQuoteArr cQArr = new CoinQuoteArr();
            cQArr.Fill();
            Quote curQuote;
            Coin curCoin;
            //Go over all the items in the source and add them to chart
            List<string> x = new List<string>();
            List<int> y = new List<int>();
            for (int i = 0; i < cArr.Count; i++)
            {

                curCoin = (cArr[i] as Coin);
                curQuote = cQArr.LatestQuote(curCoin);

                x.Add(curCoin.Name);
                y.Add((int)curQuote.Price);
            }

            chart_Report.Series.Clear();
            series.Label = "#VAL $";
            series.Points.DataBindXY(x, y);

            chart_Report.Series.Add(series);

        }

        private void pictureBox_Print_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb  = sender as PictureBox;
            
            oldColor = pb.BackColor;
            pb.BackColor = Color.Azure;
        }

        private void pictureBox_Print_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = oldColor;
        }

        private void roundLabel_MouseEnter(object sender, EventArgs e)
        {
            (sender as RoundLabel).BorderStyle = BorderStyle.FixedSingle;
        }

        private void roundLabel_MouseLeave(object sender, EventArgs e)
        {
            (sender as RoundLabel).BorderStyle = BorderStyle.None;
        }


        private void roundLabel_ClientCoin_Click(object sender, EventArgs e)
        {
            foreach (var series in chart_Report.Series)
            {
                series.Points.Clear();
            }
            curLabel.Enabled = true;
            curLabel = sender as RoundLabel;
            curLabel.Enabled = false;
            label_Title.Text = "Coin Chart";
            DataToChart2();
        }

        private void roundLabel_ClientCountry_Click(object sender, EventArgs e)
        {
            foreach (var series in chart_Report.Series)
            {
                series.Points.Clear();
            }
            curLabel.Enabled = true;
            curLabel = sender as RoundLabel;
            curLabel.Enabled = false;
            label_Title.Text = "Country Chart";
            DataToChart1();
        }

        private void CaptureScreen()
        {
            Form c = this as Form;
            bmp = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));

        }
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }
        private void pictureBox_Print_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Width = 800; printPreviewDialog.Height = 800;
            printPreviewDialog.ShowDialog();
        }

        private void roundLabel_Valid_Click(object sender, EventArgs e)
        {
            foreach (var series in chart_Report.Series)
            {
                series.Points.Clear();
            }
            curLabel.Enabled = true;
            curLabel = sender as RoundLabel;
            curLabel.Enabled = false;
            label_Title.Text = "Valid Chart";
            DataToChart3();
        }

        private void roundLabel_Scam_Click(object sender, EventArgs e)
        {
            foreach (var series in chart_Report.Series)
            {
                series.Points.Clear();
            }
            curLabel.Enabled = true;
            curLabel = sender as RoundLabel;
            curLabel.Enabled = false;
            label_Title.Text = "Scam Chart";
            DataToChart4();
        }

        private void roundLabel_TradeClient_Click(object sender, EventArgs e)
        {
            foreach (var series in chart_Report.Series)
            {
                series.Points.Clear();
            }
            curLabel.Enabled = true;
            curLabel = sender as RoundLabel;
            curLabel.Enabled = false;
            label_Title.Text = "Trade Chart";
            DataToChart5();
        }

        private void roundLabel_CoinQuote_Click(object sender, EventArgs e)
        {
            foreach (var series in chart_Report.Series)
            {
                series.Points.Clear();
            }
            curLabel.Enabled = true;
            curLabel = sender as RoundLabel;
            curLabel.Enabled = false;
            label_Title.Text = "Price Chart";
            DataToChart6();
        }
    }
}
