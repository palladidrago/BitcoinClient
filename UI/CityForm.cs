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

namespace ClientApp.UI
{
    public partial class CityForm : Form
    {
        public CityForm()
        {
            InitializeComponent();
        }
        private void CityToForm()
        {

        }
        private City FormToCity()
        {
            City c = null;
            return c;
        }
        private void CityArrToForm(CityArr cityArr)
        {
            listBox_City.DataSource = cityArr;
        }
        
    }
}
