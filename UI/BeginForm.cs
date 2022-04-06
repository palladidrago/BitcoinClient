﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.UI;

namespace ClientApp
{
    public partial class BeginForm : Form
    {
        public BeginForm()
        {
            InitializeComponent();
        }
        private void button_Client_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            this.Hide();
            clientForm.ShowDialog();
            this.Close();
        }

        private void button_City_Click(object sender, EventArgs e)
        {
            CityForm cityForm = new CityForm();
            this.Hide();
            cityForm.ShowDialog();
            this.Close();
        }

        private void button_Coin_Click(object sender, EventArgs e)
        {
            CoinForm coinForm = new CoinForm();
            this.Hide();
            coinForm.ShowDialog();
            this.Close();
        }

        private void button_Trade_Click(object sender, EventArgs e)
        {
            TradeForm tradeForm = new TradeForm();
            this.Hide();
            tradeForm.ShowDialog();
            this.Close();
        }
        private void button_Report_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            this.Hide();
            reportForm.ShowDialog();
            this.Close();
        }
    }
}
