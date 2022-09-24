using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static lab3.src.CustomChart;

namespace lab3
{
    public partial class DiagramForm : Form
    {
        public DiagramForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (chartEnums == ChartEnums.CountOfShareholdersBroker)
            {
                loadCountOfShareholdersBrokerChart();
            }
            if (chartEnums == ChartEnums.PartOfStocksAllFirms)
            {
                loadPartOfStocksAllFirmsChart();
            }
        }

        private void loadCountOfShareholdersBrokerChart()
        {
            брокерTableAdapter.Fill(this.lab3DataSet.Брокер);
            countOfShareholdersBrokerChart.Visible = true;
            countOfShareholdersBrokerChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            LabelStyle style = new LabelStyle();
            style.Angle = -90;
            countOfShareholdersBrokerChart.ChartAreas[0].AxisX.Interval = 1;
            countOfShareholdersBrokerChart.ChartAreas[0].AxisX.LabelStyle = style;
            countOfShareholdersBrokerChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
        }

        private void loadPartOfStocksAllFirmsChart()
        {
            акцииTableAdapter.Fill(this.lab3DataSet.Акции);
            mainChart.Visible = true;
            LabelStyle style = new LabelStyle();
            style.Angle = -90;
            mainChart.ChartAreas[0].AxisX.Interval = 1;
            countOfShareholdersBrokerChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            mainChart.ChartAreas[0].AxisX.LabelStyle = style;
            mainChart.Series[0].MarkerStyle = MarkerStyle.Circle;
            mainChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            mainChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            mainChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            mainChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
            mainChart.Series[0].XValueMember = "Фирма";
            mainChart.Series[0].YValueMembers = "Количество, 1";
        }
    }
}