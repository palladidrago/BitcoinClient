using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.UI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm(bool isAdmin)
        {
            InitializeComponent();
            if (isAdmin) { label_Title_Signup.Text += "(Admin)"; }
        }
    }
}
