using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class beginForm : Form
    {
        public beginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            this.Hide();
            adminPanel.ShowDialog();
            this.Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            this.Hide();
            createForm.ShowDialog();
            this.Close();
        }
    }
}
