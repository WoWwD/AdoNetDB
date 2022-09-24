namespace lab3
{
    partial class DiagramForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.countOfShareholdersBrokerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.брокерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lab3DataSet = new lab3.lab3DataSet();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.акцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.брокерTableAdapter = new lab3.lab3DataSetTableAdapters.БрокерTableAdapter();
            this.акцииTableAdapter = new lab3.lab3DataSetTableAdapters.АкцииTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.countOfShareholdersBrokerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.брокерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // countOfShareholdersBrokerChart
            // 
            chartArea1.Name = "ChartArea1";
            this.countOfShareholdersBrokerChart.ChartAreas.Add(chartArea1);
            this.countOfShareholdersBrokerChart.DataSource = this.брокерBindingSource;
            this.countOfShareholdersBrokerChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countOfShareholdersBrokerChart.Location = new System.Drawing.Point(0, 0);
            this.countOfShareholdersBrokerChart.Name = "countOfShareholdersBrokerChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series1.Label = "#VAL{N0}";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "Количество акционеров фирм у брокера";
            series1.XValueMember = "Фирма";
            series1.YValueMembers = "Количество_акционеров";
            this.countOfShareholdersBrokerChart.Series.Add(series1);
            this.countOfShareholdersBrokerChart.Size = new System.Drawing.Size(1165, 629);
            this.countOfShareholdersBrokerChart.TabIndex = 0;
            this.countOfShareholdersBrokerChart.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "Количество акционеров фирм у брокера";
            this.countOfShareholdersBrokerChart.Titles.Add(title1);
            this.countOfShareholdersBrokerChart.Visible = false;
            // 
            // брокерBindingSource
            // 
            this.брокерBindingSource.DataMember = "Брокер";
            this.брокерBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.lab3DataSet;
            this.bindingSource1.Position = 0;
            // 
            // lab3DataSet
            // 
            this.lab3DataSet.DataSetName = "lab3DataSet";
            this.lab3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainChart
            // 
            this.mainChart.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea2);
            this.mainChart.DataSource = this.акцииBindingSource;
            this.mainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainChart.Location = new System.Drawing.Point(0, 0);
            this.mainChart.Name = "mainChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series2.Label = "#VALX: #PERCENT{P}";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.YValuesPerPoint = 2;
            this.mainChart.Series.Add(series2);
            this.mainChart.Size = new System.Drawing.Size(1165, 629);
            this.mainChart.TabIndex = 1;
            this.mainChart.Text = "part";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title2.Name = "Title1";
            title2.Text = "Доля акций всех фирм";
            this.mainChart.Titles.Add(title2);
            this.mainChart.Visible = false;
            // 
            // акцииBindingSource
            // 
            this.акцииBindingSource.DataMember = "Акции";
            this.акцииBindingSource.DataSource = this.bindingSource1;
            // 
            // брокерTableAdapter
            // 
            this.брокерTableAdapter.ClearBeforeFill = true;
            // 
            // акцииTableAdapter
            // 
            this.акцииTableAdapter.ClearBeforeFill = true;
            // 
            // DiagramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 629);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.countOfShareholdersBrokerChart);
            this.Name = "DiagramForm";
            this.Text = "Диаграмма";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countOfShareholdersBrokerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.брокерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцииBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart countOfShareholdersBrokerChart;
        private System.Windows.Forms.BindingSource bindingSource1;
        private lab3DataSet lab3DataSet;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.BindingSource брокерBindingSource;
        private System.Windows.Forms.BindingSource акцииBindingSource;
        private lab3DataSetTableAdapters.БрокерTableAdapter брокерTableAdapter;
        private lab3DataSetTableAdapters.АкцииTableAdapter акцииTableAdapter;
    }
}