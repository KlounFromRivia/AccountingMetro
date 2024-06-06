using AccountingMetro.Context;
using AccountingMetro.Context.Models;
using AccountingMetro.UI.Forms;
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
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace AccountingMetro.UI.UserControls
{
    public partial class EmployeeView : UserControl
    {
        public Employee Employee { get; set; }
        string element = "";
        public EmployeeView(Employee employee)
        {
            InitializeComponent();
            this.Employee = employee;
            Initialize(employee);
        }
        private void Initialize(Employee employee)
        {
            using (var db = new AccountingMetroDBContext())
            {
                if (employee.Person.LastName == "Администратор" || employee.Person.FirstName == "Администратор" || employee.Person.Patronymic == "Администратор")
                {
                    this.Visible = false;
                    return;
                }
                if (CurrentEmployee.StaffDepart.Id != 1)
                {
                    this.Enabled = false;
                }
                lblFIO.Text = element = employee.Person.LastName +" "+ employee.Person.FirstName +" " + employee.Person.Patronymic;
                lblPost.Text = employee.Post.Title;
                lblStation.Text = employee.Station.Title;

                tsmiDelete.Enabled = employee.StatusEmployeeId == 2
                    ? true
                    : false;

                if(employee.StatusEmployeeId == 2)
                {
                    this.BackColor = Color.LightCoral;
                    lblStatus.Visible = true;
                }

                if (employee.TrainId != null)
                {
                    lblTrain.Text = employee.Train.Nomer;
                }
                else
                {
                    lblTrains.Visible = false;
                    lblTrain.Visible = false;
                }
            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            var employeeView = new EmployeeViewForm(Employee);
            this.ParentForm.Hide();
            employeeView.Employee = this.Employee;
            employeeView.ShowDialog();
            this.ParentForm.Show();
            ((EmployeesForm)ParentForm).Filter();
        }

        private void tsmiViewShift_Click(object sender, EventArgs e)
        {
            var shiftForm = new ShiftForm(Employee);
            this.ParentForm.Hide();
            shiftForm.Employee = this.Employee;
            shiftForm.ShowDialog();
            this.ParentForm.Show();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы действительно уверены, что хотите удалить '{element}'?\n" +
                $"Если вы удалите сотрудника, то все его данные и смены будут удалены!!!",
                "ВНИМАНИЕ",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (var db = new AccountingMetroDBContext())
                {
                    var document = db.Documents.FirstOrDefault(x => x.Id == Employee.Person.DocumentId);
                    db.Documents.Remove(document);
                    db.SaveChanges();
                    MessageBox.Show("Сотрудник удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
