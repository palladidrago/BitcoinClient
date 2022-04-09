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

namespace ClientApp.UI.Reports
{
    public partial class ReportForm : Form
    {
        public void ScamArrToForm()
        {
            //From Scam array to form 
            ScamArr scamArr = new ScamArr();
            Scam scamDefault = new Scam();
            scamDefault.Id = -1;
            scamDefault.Name = "Choose a scam level";


            scamArr.Add(scamDefault);
            scamArr.Fill();

            comboBox_Filter_Scam.DataSource = scamArr;
            comboBox_Filter_Scam.ValueMember = "Id";
            comboBox_Filter_Scam.DisplayMember = "";

        }
        public void ValidArrToForm()
        {
            //From Valid array to form 
            ValidArr validArr = new ValidArr();
            Valid validDefault = new Valid();
            validDefault.Id = -1;
            validDefault.Name = "Choose a validation method";


            validArr.Add(validDefault);
            validArr.Fill();

            comboBox_Filter_Valid.DataSource = validArr;
            comboBox_Filter_Valid.ValueMember = "Id";
            comboBox_Filter_Valid.DisplayMember = "";

        }
        Bitmap bmp;
        Color buttonColor;
        private int lastColumnSortBy = -1;
        private SortOrder lastSortOrder = SortOrder.Ascending;
        public ReportForm()
        {
            InitializeComponent();
            FillListView();
            ScamArrToForm();
            ValidArrToForm();
        }
        private void FillListView(CoinArr coinArr = null)
        {
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
                listView_Coins.Items.Add(listViewItem);
            }
        }
        private void textBox_Filter_Name_KeyUp(object sender, KeyEventArgs e)
        {
            //Create an array of Coins

            CoinArr coinArr = new CoinArr();
            coinArr.Fill();

            //Filter the coins according to name

            coinArr = coinArr.Filter((sender as TextBox).Text);

            //Fill listview with new info

            listView_Coins.Items.Clear();
            FillListView(coinArr);
        }

        private void comboBox_Filter_Valid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Create array
            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            //Filter by valid
            coinArr = coinArr.Filter(valid: (sender as ComboBox).SelectedItem as Valid);

            listView_Coins.Items.Clear();
            FillListView(coinArr);
        }

        private void comboBox_Filter_Scam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Create array
            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            //Filter by scam
            coinArr = coinArr.Filter(scam: (sender as ComboBox).SelectedItem as Scam);

            listView_Coins.Items.Clear();
            FillListView(coinArr);
        }

        private void numericUpDown_Supply_ValueChanged(object sender, EventArgs e)
        {
            //Create array
            CoinArr coinArr = new CoinArr();
            coinArr.Fill();
            //Filter by scam
            coinArr = coinArr.Filter(count: Convert.ToInt64((sender as NumericUpDown).Value) );

            listView_Coins.Items.Clear();
            FillListView(coinArr);
        }



        
        private void CaptureScreen()
        {
            ListView c = listView_Coins as ListView;
            bmp = new Bitmap(listView_Coins.Width, listView_Coins.Height);
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
            e.Graphics.DrawImage(bmp,Point.Empty);
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
        private void listView_Products_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_Coins.ListViewItemSorter = sorter;
            sorter = listView_Coins.ListViewItemSorter as ListViewSorter;
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
            listView_Coins.Sort();

            // ??
            lastColumnSortBy = e.Column;

            //Save the last sort
            lastSortOrder = sorter.SortOrder;
        }

        private void button_CoinReport_Click(object sender, EventArgs e)
        {

        }

        private void button_ClientCoinReport_Click(object sender, EventArgs e)
        {
            ClientCoinReport ccr = new ClientCoinReport();
            ccr.ShowDialog();
            this.Close();
        }
    }
}
