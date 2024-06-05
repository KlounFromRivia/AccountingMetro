using AccountingMetro.Context;
using AccountingMetro.Context.Models;
using AccountingMetro.UI.Validate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
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
            var stationForm = new MetroForm();
            this.Hide();
            stationForm.ShowDialog();
            this.Show();
        }

        private void btnStaffDepart_Click(object sender, EventArgs e)
        {

        }

        public void Initizalis()
        {
            //tsslFIO.Text = CurrectEmployee.User.Employee.Person.LastName + " "
            //+ CurrectEmployee.User.Employee.Person.FirstName + " " +
            //CurrectEmployee.User.Employee.Person.Patronymic + " ";
            //if (CurrectEmployee.User.Employee.Person.ImagePreview != null)
            //{
            //    var image = Image.FromStream(new MemoryStream(CurrectEmployee.User.Employee.Person.ImagePreview));
            //    picEmployee.Image = image;
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Initizalis();
        }
    }
}
