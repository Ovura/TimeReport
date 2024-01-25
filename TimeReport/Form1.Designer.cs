namespace TimeReport
{
    partial class TimeReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeReportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKTimeReportEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKTimeReportEmployeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKTimeReportEmployeesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeReportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTimeReportEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTimeReportEmployeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTimeReportEmployeesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Worked Hours for current Selection";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "Employee_ID", true));
            this.comboBox1.DataSource = this.employeesBindingSource1;
            this.comboBox1.DisplayMember = "FirstName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Employee_ID";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.timeReportDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 202);
            this.dataGridView1.TabIndex = 3;
            // 
            // time_ReportDataSet
            // 
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            // 
            // employeesTableAdapter
            // 
            // 
            // fKTimeReportEmployeesBindingSource
            // 
            this.fKTimeReportEmployeesBindingSource.DataMember = "FK_TimeReport_Employees";
            this.fKTimeReportEmployeesBindingSource.DataSource = this.employeesBindingSource1;
            // 
            // 
            // fKTimeReportEmployeesBindingSource1
            // 
            this.fKTimeReportEmployeesBindingSource1.DataMember = "FK_TimeReport_Employees";
            this.fKTimeReportEmployeesBindingSource1.DataSource = this.employeesBindingSource1;
            // 
            // fKTimeReportEmployeesBindingSource2
            // 
            this.fKTimeReportEmployeesBindingSource2.DataMember = "FK_TimeReport_Employees";
            this.fKTimeReportEmployeesBindingSource2.DataSource = this.employeesBindingSource1;
            // 
            // TimeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TimeReport";
            this.Text = "TimeReporter";
            this.Load += new System.EventHandler(this.TimeReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource timeReportDataSetBindingSource;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private System.Windows.Forms.BindingSource fKTimeReportEmployeesBindingSource;
        private System.Windows.Forms.BindingSource fKTimeReportEmployeesBindingSource1;
        private System.Windows.Forms.BindingSource fKTimeReportEmployeesBindingSource2;
    }
}

