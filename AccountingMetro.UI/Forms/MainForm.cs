using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingMetro.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            var employeesForm = new EmployeesForm();
            this.Hide();
            employeesForm.ShowDialog();
            this.Show();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            var shiftForm = new ShiftForm();
            this.Hide();
            shiftForm.ShowDialog();
            this.Show();
        }

        private void btnBDOther_Click(object sender, EventArgs e)
        {
            var stationForm = new StationForm();
            this.Hide();
            stationForm.ShowDialog();
            this.Show();
        }

        private void btnStaffDepart_Click(object sender, EventArgs e)
        {

        }
    }
}
