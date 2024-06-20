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
        public StaffDepart StaffDepart { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this.StaffDepart = CurrentEmployee.StaffDepart;
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
            var staffdepartForm = new StaffDepartForm();
            this.Hide();
            staffdepartForm.ShowDialog();
            this.Show();
        }

        public void Initizalis()
        {
            btnStaffDepart.Visible = tsmiEditPassword.Visible = CurrentEmployee.StaffDepart.Id == 1;
            pnlStaff.Visible = CurrentEmployee.StaffDepart.Id != 1;
            if (CurrentEmployee.StaffDepart.Id == 1)
            {
                tsslFIO.Text = CurrentEmployee.StaffDepart.Employee.Person.LastName;
                return;
            }
            lblFio.Text = CurrentEmployee.StaffDepart.Employee.Person.LastName + " "
                + CurrentEmployee.StaffDepart.Employee.Person.FirstName + " "
                + CurrentEmployee.StaffDepart.Employee.Person.Patronymic;
            lblStation.Text = "Станция '" + CurrentEmployee.StaffDepart.Employee.Station.Title + "'";
            tsslFIO.Text = "Отдел кадров: " + CurrentEmployee.StaffDepart.Employee.Person.LastName + " "
                + CurrentEmployee.StaffDepart.Employee.Person.FirstName + " "
                + CurrentEmployee.StaffDepart.Employee.Person.Patronymic;
            pnlControl.Height = 211;
            if (CurrentEmployee.StaffDepart.Employee.Person.ImagePreview != null)
            {
                var image = Image.FromStream(new MemoryStream(CurrentEmployee.StaffDepart.Employee.Person.ImagePreview));
                picEmployee.Image = image;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Initizalis();
        }

        private void tsmiEditPassword_Click(object sender, EventArgs e)
        {
            var staffDepartView = new AddStaffDepartForm(StaffDepart);
            this.Hide();
            staffDepartView.StaffDepart = this.StaffDepart;
            staffDepartView.ShowDialog();
            this.Show();
        }
    }
}
