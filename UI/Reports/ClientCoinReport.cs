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
    public partial class ClientCoinReport : Form
    {
        public ClientCoinReport()
        {
            InitializeComponent();
            FillListView();
        }
        private void FillListView(CoinArr coinArr = null)
        {
            Client client = new Client();
            TradeCoinArr tCArr = new TradeCoinArr();
            tCArr.Fill();
            ListViewItem listViewItem;
            CoinArr top3cArr;
            //Go over all the items in the source and add them to listview
            int prevClientId = 0;
            for (int i = 0; i < tCArr.Count; i++)
            {
                
                client = (tCArr[i] as TradeCoin).Trade.Client;
                if (client.Id != prevClientId)
                {
                    prevClientId = client.Id;
                    top3cArr = tCArr.GetTop3CoinsForClient(client);

                    listViewItem = new ListViewItem(new[] { client.ToString(),

                    top3cArr[0].ToString(), top3cArr[1].ToString(), top3cArr[2].ToString() });
                    listView_Coins.Items.Add(listViewItem);
                }
            }
        }
    }
}
