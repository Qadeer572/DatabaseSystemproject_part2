namespace awein2
{
    partial class boothTrafficView
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.careerConnect_JobFairManagementDataSet18 = new awein2.CareerConnect_JobFairManagementDataSet18();
            this.careerConnectJobFairManagementDataSet18BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.careerConnectJobFairManagementDataSet18BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boothTrafficBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.careerConnect_JobFairManagementDataSet17 = new awein2.CareerConnect_JobFairManagementDataSet17();
            this.careerConnectJobFairManagementDataSet17BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnectJobFairManagementDataSet18BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnectJobFairManagementDataSet18BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boothTrafficBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnectJobFairManagementDataSet17BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "awein2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(77, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(617, 432);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // careerConnect_JobFairManagementDataSet18
            // 
            this.careerConnect_JobFairManagementDataSet18.DataSetName = "CareerConnect_JobFairManagementDataSet18";
            this.careerConnect_JobFairManagementDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // careerConnectJobFairManagementDataSet18BindingSource
            // 
            this.careerConnectJobFairManagementDataSet18BindingSource.DataSource = this.careerConnect_JobFairManagementDataSet18;
            this.careerConnectJobFairManagementDataSet18BindingSource.Position = 0;
            // 
            // careerConnectJobFairManagementDataSet18BindingSource1
            // 
            this.careerConnectJobFairManagementDataSet18BindingSource1.DataSource = this.careerConnect_JobFairManagementDataSet18;
            this.careerConnectJobFairManagementDataSet18BindingSource1.Position = 0;
            // 
            // boothTrafficBindingSource
            // 
            this.boothTrafficBindingSource.DataMember = "boothTraffic";
            this.boothTrafficBindingSource.DataSource = this.careerConnect_JobFairManagementDataSet18;
            // 
            // careerConnect_JobFairManagementDataSet17
            // 
            this.careerConnect_JobFairManagementDataSet17.DataSetName = "CareerConnect_JobFairManagementDataSet17";
            this.careerConnect_JobFairManagementDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // careerConnectJobFairManagementDataSet17BindingSource
            // 
            this.careerConnectJobFairManagementDataSet17BindingSource.DataSource = this.careerConnect_JobFairManagementDataSet17;
            this.careerConnectJobFairManagementDataSet17BindingSource.Position = 0;
            // 
            // boothTrafficView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.reportViewer1);
            this.Name = "boothTrafficView";
            this.Text = "boothTrafficView";
            this.Load += new System.EventHandler(this.boothTrafficView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnectJobFairManagementDataSet18BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnectJobFairManagementDataSet18BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boothTrafficBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnectJobFairManagementDataSet17BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource careerConnectJobFairManagementDataSet18BindingSource;
        private CareerConnect_JobFairManagementDataSet18 careerConnect_JobFairManagementDataSet18;
        private System.Windows.Forms.BindingSource careerConnectJobFairManagementDataSet18BindingSource1;
        private System.Windows.Forms.BindingSource boothTrafficBindingSource;
        private CareerConnect_JobFairManagementDataSet17 careerConnect_JobFairManagementDataSet17;
        private System.Windows.Forms.BindingSource careerConnectJobFairManagementDataSet17BindingSource;
    }
}