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
            AdminForm adminPanel = new AdminForm();
            this.Hide();
            adminPanel.ShowDialog();
            this.Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            ClientForm createForm = new ClientForm();
            this.Hide();
            createForm.ShowDialog();
            this.Close();
        }
    }
}
