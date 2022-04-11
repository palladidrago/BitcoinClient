using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ClientApp.UI
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            label_Title.Text += " " + Globals.client.FirstName;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.Azure,
                                                                       this.BackColor,
                                                                       180F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void UserForm_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void button_Trade_Click(object sender, EventArgs e)
        {
            UserTradeForm userTradeForm = new UserTradeForm();
            this.Hide();
            userTradeForm.ShowDialog();
            this.Show();
        }

        private void button_Coin_Click(object sender, EventArgs e)
        {
            UserCoinForm userCoinForm = new UserCoinForm();
            this.Hide();
            userCoinForm.ShowDialog();
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
    }
}
