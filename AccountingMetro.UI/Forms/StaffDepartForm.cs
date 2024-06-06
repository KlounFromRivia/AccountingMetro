using AccountingMetro.Context.Models;
using AccountingMetro.Context;
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
using AccountingMetro.UI.UserControls;
using static System.Collections.Specialized.BitVector32;

namespace AccountingMetro.UI.Forms
{
    public partial class StaffDepartForm : Form
    {
        public StaffDepartForm()
        {
            InitializeComponent();
            InitControls();
        }
        public void InitControls()
        {
            using (var db = new AccountingMetroDBContext())
            {
                FillEmployeeView();

                cmbVetka.Items.Clear();
                cmbVetka.Items.AddRange(db.Vetkas.ToArray());
                cmbVetka.Items.Insert(0, new Vetka()
                {
                    Id = -1,
                    Title = "Все ветки"
                });
                cmbVetka.DisplayMember = nameof(Vetka.Title);

                cmbStatusEmployee.Items.Clear();
                cmbStatusEmployee.Items.AddRange(db.StatusEmployees.ToArray());
                cmbStatusEmployee.Items.Insert(0, new StatusEmployee()
                {
                    Id = -1,
                    Title = "Все сотрудники"
                });
                cmbStatusEmployee.DisplayMember = nameof(StatusEmployee.Title);

                cmbVetka.SelectedIndex = 0;
                cmbStatusEmployee.SelectedIndex = 0;
            }
        }
        public void FillEmployeeView()
        {
            flpStaffDeparts.Controls.Clear();
            using (var db = new AccountingMetroDBContext())
            {
                List<StaffDepart> listStaffDepart;
                listStaffDepart = db.StaffDeparts
                    .Include(x => x.Employee)
                    .Include(x => x.Employee.Person)
                    .Include(x => x.Employee.Station)
                    .Include(x => x.Employee.Post)
                    .ToList();
                foreach (var staffDepart in listStaffDepart)
                {
                    AddOrderView(staffDepart);
                }
            }
        }

        public void AddOrderView(StaffDepart staffDepart)
        {
            var employeeControl = new StaffDepartView(staffDepart);
            employeeControl.Parent = flpStaffDeparts;
        }

        #region Фильтрация
        private void Filter()
        {
            var station = ((Station)cmbStation.SelectedItem);
            var vetka = ((Vetka)cmbVetka.SelectedItem);
            var status = ((StatusEmployee)cmbStatusEmployee.SelectedItem);

            if (station == null || vetka == null || status == null)
            {
                return;
            }
            flpStaffDeparts.Controls.Clear();
            using (var db = new AccountingMetroDBContext())
            {
                var staffdeparts = db.StaffDeparts
                    .Include(x => x.Employee)
                    .Include(x => x.Employee.Person)
                    .Include(x => x.Employee.Station)
                    .Include(x => x.Employee.Post)
                    .Where(x => (x.Employee.StationId == station.Id || station.Id == -1)
                    && (x.Employee.Station.VetkaId == vetka.Id || vetka.Id == -1)
                    && (x.Employee.PostId == 9)
                    && (x.Employee.StatusEmployeeId == status.Id || status.Id == -1)
                    && ((x.Employee.Person.LastName.ToLower().Contains(txtFam.Text.ToLower()) || txtFam.Text == "")
                    || (x.Employee.Person.FirstName.ToLower().Contains(txtFam.Text.ToLower()) || txtFam.Text == "")
                    || (x.Employee.Person.Patronymic.ToLower().Contains(txtFam.Text.ToLower()) || txtFam.Text == "")))
                    .ToList();
                foreach (var staffdepart in staffdeparts)
                {
                    AddOrderView(staffdepart);
                }
            }
        }
        private void FillComboBoxStation()
        {
            using (var db = new AccountingMetroDBContext())
            {
                var vetka = (Vetka)cmbVetka.SelectedItem;
                cmbStation.Items.Clear();
                if (vetka.Id == -1)
                {
                    cmbStation.Items.AddRange(db.Stations.ToArray());
                }
                else
                {
                    cmbStation.Items.AddRange(db.Stations.Where(x => x.VetkaId == vetka.Id).ToArray());
                }
                cmbStation.Items.Insert(0, new Station()
                {
                    Id = -1,
                    Title = "Все станции"
                });

                cmbStation.DisplayMember = nameof(Station.Title);
                cmbStation.SelectedIndex = 0;
            }
        }
        #endregion

        private void cmbVetka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender.Equals(cmbVetka))
            {
                FillComboBoxStation();
            }
            Filter();
        }

        private void tssmBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            using (var db = new AccountingMetroDBContext())
            {
                var employeeExist = db.Employees.Include(x => x.Person).Where(x => x.PostId == 9
                                                                && !db.StaffDeparts.Select(y => y.EmployeeId)
                                                                                   .ToList()
                                                                                   .Contains(x.Id)).Any();
                if (employeeExist)
                {
                    var ev = new AddStaffDepartForm();
                    this.Hide();
                    ev.ShowDialog();
                    FillEmployeeView();
                    this.Show();
                    return;
                }
                MessageBox.Show("Все дежурным выдан доступ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
