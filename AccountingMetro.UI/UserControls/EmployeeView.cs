using AccountingMetro.Context;
using AccountingMetro.Context.Models;
using AccountingMetro.UI.Forms;
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
using static System.Collections.Specialized.BitVector32;

namespace AccountingMetro.UI.UserControls
{
    public partial class EmployeeView : UserControl
    {
        public event Action StatusCount;
        public Employee Employee { get; set; }
        public Document Document { get; set; }
        public Person Person { get; set; }
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
                lblFIO.Text = employee.Person.LastName +" "+ employee.Person.FirstName +" " + employee.Person.Patronymic;
                lblPost.Text = employee.Post.Title;
                lblStation.Text = employee.Station.Title;

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
        }
    }
}
