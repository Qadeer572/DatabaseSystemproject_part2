namespace awein2
{
    partial class trafficMonitoring
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.careerConnect_JobFairManagementDataSet13 = new awein2.CareerConnect_JobFairManagementDataSet13();
            this.boothCheckInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boothCheckInTableAdapter = new awein2.CareerConnect_JobFairManagementDataSet13TableAdapters.BoothCheckInTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.boothIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boothCheckInBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boothIDDataGridViewTextBoxColumn,
            this.eventIDDataGridViewTextBoxColumn,
            this.CheckInCount});
            this.dataGridView1.DataSource = this.boothCheckInBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(653, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // careerConnect_JobFairManagementDataSet13
            // 
            this.careerConnect_JobFairManagementDataSet13.DataSetName = "CareerConnect_JobFairManagementDataSet13";
            this.careerConnect_JobFairManagementDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boothCheckInBindingSource
            // 
            this.boothCheckInBindingSource.DataMember = "BoothCheckIn";
            this.boothCheckInBindingSource.DataSource = this.careerConnect_JobFairManagementDataSet13;
            // 
            // boothCheckInTableAdapter
            // 
            this.boothCheckInTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(30, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 528);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(298, 655);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boothIDDataGridViewTextBoxColumn
            // 
            this.boothIDDataGridViewTextBoxColumn.DataPropertyName = "BoothID";
            this.boothIDDataGridViewTextBoxColumn.HeaderText = "BoothID";
            this.boothIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.boothIDDataGridViewTextBoxColumn.Name = "boothIDDataGridViewTextBoxColumn";
            this.boothIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            this.eventIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // CheckInCount
            // 
            this.CheckInCount.DataPropertyName = "CheckInCount";
            this.CheckInCount.HeaderText = "CheckInCount";
            this.CheckInCount.MinimumWidth = 8;
            this.CheckInCount.Name = "CheckInCount";
            this.CheckInCount.ReadOnly = true;
            this.CheckInCount.Width = 150;
            // 
            // trafficMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(837, 805);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "trafficMonitoring";
            this.Text = "trafficMonitoring";
            this.Load += new System.EventHandler(this.trafficMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boothCheckInBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CareerConnect_JobFairManagementDataSet13 careerConnect_JobFairManagementDataSet13;
        private System.Windows.Forms.BindingSource boothCheckInBindingSource;
        private CareerConnect_JobFairManagementDataSet13TableAdapters.BoothCheckInTableAdapter boothCheckInTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn boothIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInCount;
    }
}