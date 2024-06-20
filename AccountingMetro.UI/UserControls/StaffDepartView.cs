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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AccountingMetro.UI.UserControls
{
    /// <summary>
    /// Отображение сотрудника отдела кадра в списке
    /// </summary>
    public partial class StaffDepartView : UserControl
    {
        public StaffDepart StaffDepart { get; set; }
        string element = "";
        public StaffDepartView(StaffDepart staffdepart)
        {
            InitializeComponent();
            this.StaffDepart = staffdepart;
            Initialize(staffdepart);
        }
        private void Initialize(StaffDepart staffdepart)
        {
            using (var db = new AccountingMetroDBContext())
            {
                if (staffdepart.Id == 1)
                {
                    this.Visible = false;
                    return;
                }
                var employee = db.StaffDeparts
                    .Include(x => x.Employee.Person)
                    .Include(x => x.Employee.Station)
                    .Include(x => x.Employee.StatusEmployee)
                    .FirstOrDefault(x => x.EmployeeId == staffdepart.EmployeeId);
                lblFIO.Text = element = employee.Employee.Person.LastName + " " +
                    employee.Employee.Person.FirstName + " " + employee.Employee.Person.Patronymic;
                lblStation.Text = employee.Employee.Station.Title;

                tsmiDeleteStaff.Enabled = employee.Employee.StatusEmployeeId == 2
                    ? true
                    : false;

                if (employee.Employee.StatusEmployeeId == 2)
                {
                    this.BackColor = Color.LightCoral;
                    lblStatus.Visible = true;
                }
            }
        }

        private void tsmiDeleteStaff_Click(object sender, EventArgs e)
        {
            using (var db = new AccountingMetroDBContext())
            {
                if (StaffDepart.Login != "admin")
                {
                    if (MessageBox.Show($"Вы действительно уверены, что хотите удалить '{element}'?\n" +
                    $"Если вы удалите сотрудника отдела кадров, то все его данные и смены будут удалены!!!",
                    "ВНИМАНИЕ",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        var document = db.Documents.FirstOrDefault(x => x.Id == StaffDepart.Employee.Person.DocumentId);
                        db.Documents.Remove(document);
                        db.SaveChanges();
                        MessageBox.Show("Сотрудник удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Parent.Controls.Remove(this);
                    }
                }
                else
                {
                    MessageBox.Show("Вы не можете удалить администратора",
                    "ВНИМАНИЕ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiViewData_Click(object sender, EventArgs e)
        {
            var employeeView = new EmployeeViewForm(StaffDepart.Employee);
            this.ParentForm.Hide();
            employeeView.Employee = this.StaffDepart.Employee;
            employeeView.ShowDialog();
            this.ParentForm.Show();
            ((StaffDepartForm)ParentForm).FillEmployeeView();
        }

        private void tsmiEditStaff_Click(object sender, EventArgs e)
        {
            var staffDepartView = new AddStaffDepartForm(StaffDepart);
            this.ParentForm.Hide();
            staffDepartView.StaffDepart = this.StaffDepart;
            staffDepartView.ShowDialog();
            this.ParentForm.Show();
            ((StaffDepartForm)ParentForm).FillEmployeeView();
        }
    }
}
