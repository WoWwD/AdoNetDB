namespace lab3.src
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.АкцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab3DataSet = new lab3.lab3DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.акцииBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.акцииTableAdapter = new lab3.lab3DataSetTableAdapters.АкцииTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.АкцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцииBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // АкцииBindingSource
            // 
            this.АкцииBindingSource.DataMember = "Акции";
            this.АкцииBindingSource.DataSource = this.lab3DataSet;
            // 
            // lab3DataSet
            // 
            this.lab3DataSet.DataSetName = "lab3DataSet";
            this.lab3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.АкцииBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lab3.AvgCourseOfBuyAndCourseOfSell.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(975, 548);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // акцииBindingSource1
            // 
            this.акцииBindingSource1.DataMember = "Акции";
            this.акцииBindingSource1.DataSource = this.bindingSource3;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataSource = this.lab3DataSet;
            this.bindingSource3.Position = 0;
            // 
            // акцииTableAdapter
            // 
            this.акцииTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 548);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "Отчёт";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.АкцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцииBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bindingSource3;
        private lab3DataSet lab3DataSet;
        private System.Windows.Forms.BindingSource акцииBindingSource1;
        private lab3DataSetTableAdapters.АкцииTableAdapter акцииTableAdapter;
        private System.Windows.Forms.BindingSource АкцииBindingSource;
    }
}