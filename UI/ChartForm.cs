using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BL;

namespace ClientApp.UI
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
            DataToChart();
        }
        public void DataToChart()
        {
            chart.Palette = ChartColorPalette.SeaGreen;
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart.Titles.Clear();
            chart.Titles.Add("Distribution of customers by locality");
            ClientArr curClientArr = new ClientArr();
            curClientArr.Fill();
            SortedDictionary<string, int> dictionary = curClientArr.GetSortedDictionary();


            Series series = new Series("Distribution");


            series.ChartType = SeriesChartType.Column;

            series.Label = "#VALX [#VAL = #PERCENT{P0}]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);
                    //מחיקת סדרות קיימות - אם יש ולא בכוונה

                    chart.Series.Clear();

                    //הוספת הסדרה לפקד הגרף

                    chart.Series.Add(series);
                }
            }
}
