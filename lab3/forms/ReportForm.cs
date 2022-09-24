using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using static lab3.src.Report;

namespace lab3.src
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            акцииTableAdapter.Fill(this.lab3DataSet.Акции);
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();

            var binding = new BindingSource();
            binding.DataSource = lab3DataSet.Акции;

            ReportDataSource rds = new ReportDataSource("DataSet1", binding);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = $"{getReport()}";
            reportViewer1.RefreshReport();
        }

        private string getReport()
        {
            if (Report.reportEnums == ReportEnums.SumCountStockOfFirms)
            {
                return "SumCountStockOfFirmsReport.rdlc";
            }
            if (Report.reportEnums == ReportEnums.AvgCourseOfBuyAndCourseOfSell)
            {
                return "AvgCourseOfBuyAndCourseOfSellReport.rdlc";
            }
            return "";
        }
    }
}