using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeReport
{
    public partial class TimeReport : Form
    {
        private readonly Time_ReportEntities1 time_ReportEntities1;
        

        public TimeReport()
        {
            InitializeComponent();

            time_ReportEntities1 = new Time_ReportEntities1();
        }

        private void TimeReport_Load(object sender, EventArgs e)
        {
            var employees = time_ReportEntities1.Employees.ToList();
            comboBox1.DisplayMember = "FirstName";
            comboBox1.ValueMember = "Employee_ID";
            comboBox1.DataSource = employees;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
