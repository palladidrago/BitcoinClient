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
        private void button_UpdateInfo_Click(object sender, EventArgs e)
        {
            ClientCreateForm ccForm = new ClientCreateForm(login: Globals.client.Login,clientToUpdate: Globals.client);
            this.Hide();
            ccForm.ShowDialog();
            this.Show();
        }

        private void pictureBox_PowerOff_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox_PowerOff_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.White;
        }

        private void pictureBox_PowerOff_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor= Color.Transparent;
        }

        private void button_Portfolio_Click(object sender, EventArgs e)
        {
            PortfolioForm portfolioForm = new PortfolioForm();
            this.Hide();
            portfolioForm.ShowDialog();
            this.Show();
        }
    }
}
