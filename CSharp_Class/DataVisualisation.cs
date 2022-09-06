using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Class
{
    public partial class DataVisualisation : Form
    {
        public DataVisualisation()
        {
            InitializeComponent();
        }

        private void dgvSavings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPlotGraph_Click(object sender, EventArgs e)
        {
            chartSavings.Show();
            chartSavings.Titles.Clear();
            chartSavings.ChartAreas.Clear();
            chartSavings.Legends.Clear();
            chartSavings.Series.Clear();

            chartSavings.ChartAreas.Add("chart1");
            chartSavings.Series.Add("sr1");
            chartSavings.Series["sr1"].ChartArea = "chart1";
            chartSavings.Series["sr1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
           
            for (int i = 0; i < dgvSavings.Rows.Count-1; i++)
            {
                chartSavings.Series["sr1"].Points.AddXY(dgvSavings.Rows[i].Cells[1].Value, Convert.ToDouble(dgvSavings.Rows[i].Cells[0].Value));


            }

            chartSavings.Titles.Add("Amount Against Month Curve");

            chartSavings.ChartAreas["chart1"].AxisY.Title = "Amount";
            chartSavings.ChartAreas["chart1"].AxisX.Title = "Month";

            chartSavings.ChartAreas["chart1"].AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartSavings.ChartAreas["chart1"].AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;

        }

        private void DataVisualisation_Load(object sender, EventArgs e)
        {
            chartSavings.Hide();
        }
    }
}
