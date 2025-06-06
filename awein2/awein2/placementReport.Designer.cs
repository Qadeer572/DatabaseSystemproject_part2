namespace awein2
{
    partial class placementReport
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
            this.careerConnect_JobFairManagementDataSet17 = new awein2.CareerConnect_JobFairManagementDataSet17();
            this.careerConnectJobFairManagementDataSet17BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.careerConnect_JobFairManagementDataSet18 = new awein2.CareerConnect_JobFairManagementDataSet18();
            this.careerConnectJobFairManagementDataSet18BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnectJobFairManagementDataSet17BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnectJobFairManagementDataSet18BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "awein2.placement.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(109, 67);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(610, 447);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
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
            // placementReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.reportViewer1);
            this.Name = "placementReport";
            this.Text = "placementReport";
            this.Load += new System.EventHandler(this.placementReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnectJobFairManagementDataSet17BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnectJobFairManagementDataSet18BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource careerConnectJobFairManagementDataSet17BindingSource;
        private CareerConnect_JobFairManagementDataSet17 careerConnect_JobFairManagementDataSet17;
        private System.Windows.Forms.BindingSource careerConnectJobFairManagementDataSet18BindingSource;
        private CareerConnect_JobFairManagementDataSet18 careerConnect_JobFairManagementDataSet18;
    }
}