using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.UI;
using System.Net;
using BL;
using ClientApp.UI.Reports; 

namespace ClientApp.UI
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void button_Client_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            this.Hide();
            clientForm.ShowDialog();
            this.Show();
        }

        private void button_City_Click(object sender, EventArgs e)
        {
            CityForm cityForm = new CityForm();
            this.Hide();
            cityForm.ShowDialog();
            this.Show();
        }

        private void button_Coin_Click(object sender, EventArgs e)
        {
            CoinForm coinForm = new CoinForm();
            this.Hide();
            coinForm.ShowDialog();
            this.Show();
        }

        private void button_Trade_Click(object sender, EventArgs e)
        {
            TradeForm tradeForm = new TradeForm();
            this.Hide();
            tradeForm.ShowDialog();
            this.Show();
        }
        private void button_Report_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            this.Hide();
            reportForm.ShowDialog();
            this.Show();
        }

        private void button_Chart_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm();
            this.Hide();
            chartForm.ShowDialog();
            this.Show();
        }

        private void pictureBox_PowerOff_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox_PowerOff_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Azure;

        }

        private void pictureBox_PowerOff_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Transparent;
        }
    }
}
