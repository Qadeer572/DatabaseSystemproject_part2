namespace awein2
{
    partial class addingBooths
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.jobFairEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.careerConnect_JobFairManagementDataSet1 = new awein2.CareerConnect_JobFairManagementDataSet1();
            this.jobFairEventsTableAdapter = new awein2.CareerConnect_JobFairManagementDataSet1TableAdapters.JobFairEventsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.careerConnect_JobFairManagementDataSet11 = new awein2.CareerConnect_JobFairManagementDataSet11();
            this.jobFairEventsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jobFairEventsTableAdapter1 = new awein2.CareerConnect_JobFairManagementDataSet11TableAdapters.JobFairEventsTableAdapter();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairEventsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.jobFairEventsBindingSource;
            this.comboBox1.DisplayMember = "EventID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 312);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "eventDate";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // jobFairEventsBindingSource
            // 
            this.jobFairEventsBindingSource.DataMember = "JobFairEvents";
            this.jobFairEventsBindingSource.DataSource = this.careerConnect_JobFairManagementDataSet1;
            // 
            // careerConnect_JobFairManagementDataSet1
            // 
            this.careerConnect_JobFairManagementDataSet1.DataSetName = "CareerConnect_JobFairManagementDataSet1";
            this.careerConnect_JobFairManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobFairEventsTableAdapter
            // 
            this.jobFairEventsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(64, 259);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Please Select the Event";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 364);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 30);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Please Select the number of Booths";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(64, 413);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(350, 30);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(78, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(76)))));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox3.Location = new System.Drawing.Point(66, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(479, 44);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "            Booth Assinging";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(66, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 567);
            this.panel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIDDataGridViewTextBoxColumn,
            this.venueDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.noOfStaffDataGridViewTextBoxColumn,
            this.totalCapacityDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jobFairEventsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(41, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(403, 184);
            this.dataGridView1.TabIndex = 7;
            // 
            // careerConnect_JobFairManagementDataSet11
            // 
            this.careerConnect_JobFairManagementDataSet11.DataSetName = "CareerConnect_JobFairManagementDataSet11";
            this.careerConnect_JobFairManagementDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobFairEventsBindingSource1
            // 
            this.jobFairEventsBindingSource1.DataMember = "JobFairEvents";
            this.jobFairEventsBindingSource1.DataSource = this.careerConnect_JobFairManagementDataSet11;
            // 
            // jobFairEventsTableAdapter1
            // 
            this.jobFairEventsTableAdapter1.ClearBeforeFill = true;
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            this.eventIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // venueDataGridViewTextBoxColumn
            // 
            this.venueDataGridViewTextBoxColumn.DataPropertyName = "Venue";
            this.venueDataGridViewTextBoxColumn.HeaderText = "Venue";
            this.venueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.venueDataGridViewTextBoxColumn.Name = "venueDataGridViewTextBoxColumn";
            this.venueDataGridViewTextBoxColumn.Width = 150;
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "eventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "eventDate";
            this.eventDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            this.eventDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // noOfStaffDataGridViewTextBoxColumn
            // 
            this.noOfStaffDataGridViewTextBoxColumn.DataPropertyName = "NoOfStaff";
            this.noOfStaffDataGridViewTextBoxColumn.HeaderText = "NoOfStaff";
            this.noOfStaffDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noOfStaffDataGridViewTextBoxColumn.Name = "noOfStaffDataGridViewTextBoxColumn";
            this.noOfStaffDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalCapacityDataGridViewTextBoxColumn
            // 
            this.totalCapacityDataGridViewTextBoxColumn.DataPropertyName = "TotalCapacity";
            this.totalCapacityDataGridViewTextBoxColumn.HeaderText = "TotalCapacity";
            this.totalCapacityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalCapacityDataGridViewTextBoxColumn.Name = "totalCapacityDataGridViewTextBoxColumn";
            this.totalCapacityDataGridViewTextBoxColumn.Width = 150;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // addingBooths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(639, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addingBooths";
            this.Text = "addingBooths";
            this.Load += new System.EventHandler(this.addingBooths_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobFairEventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerConnect_JobFairManagementDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairEventsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private CareerConnect_JobFairManagementDataSet1 careerConnect_JobFairManagementDataSet1;
        private System.Windows.Forms.BindingSource jobFairEventsBindingSource;
        private CareerConnect_JobFairManagementDataSet1TableAdapters.JobFairEventsTableAdapter jobFairEventsTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CareerConnect_JobFairManagementDataSet11 careerConnect_JobFairManagementDataSet11;
        private System.Windows.Forms.BindingSource jobFairEventsBindingSource1;
        private CareerConnect_JobFairManagementDataSet11TableAdapters.JobFairEventsTableAdapter jobFairEventsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfStaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    }
}