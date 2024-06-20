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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using AccountingMetro.UI.Validate;

namespace AccountingMetro.UI.Forms
{
    /// <summary>
    /// Форма работы со сотрудниками
    /// </summary>
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
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

                cmbPost.Items.Clear();
                cmbPost.Items.AddRange(db.Posts.ToArray());
                cmbPost.Items.Insert(0, new Post()
                {
                    Id = -1,
                    Title = "Все должности"
                });
                cmbPost.DisplayMember = nameof(Post.Title);

                cmbStatusEmployee.Items.Clear();
                cmbStatusEmployee.Items.AddRange(db.StatusEmployees.ToArray());
                cmbStatusEmployee.Items.Insert(0, new StatusEmployee()
                {
                    Id = -1,
                    Title = "Все сотрудники"
                });
                cmbStatusEmployee.DisplayMember = nameof(StatusEmployee.Title);
                

                cmbPost.SelectedIndex = 0;
                cmbVetka.SelectedIndex = 0;
                cmbStatusEmployee.SelectedIndex = 0;
            }
        }
        #region Фильтрация
        public void Filter()
        {
            var station = ((Station)cmbStation.SelectedItem);
            var vetka = ((Vetka)cmbVetka.SelectedItem);
            var post = ((Post)cmbPost.SelectedItem);
            var status = ((StatusEmployee)cmbStatusEmployee.SelectedItem);

            if (station == null || vetka == null || post == null || status == null)
            {
                return;
            }
            flpEmployees.Controls.Clear();
            using (var db = new AccountingMetroDBContext())
            {
                var employees = db.Employees
                    .Include(x => x.Person)
                    .Include(x => x.Station)
                    .Include(x => x.Train)
                    .Include(x => x.Post)
                    .Include(x => x.StatusEmployee)
                    .Where(x => (x.StationId == station.Id || station.Id == -1)
                    && (x.Station.VetkaId == vetka.Id || vetka.Id == -1)
                    && (x.PostId == post.Id || post.Id == -1)
                    && (x.StatusEmployeeId == status.Id || status.Id == -1)
                    && ((x.Person.LastName.ToLower().Contains(txtFam.Text.ToLower()) || txtFam.Text == "")
                    || (x.Person.FirstName.ToLower().Contains(txtFam.Text.ToLower()) || txtFam.Text == "")
                    || (x.Person.Patronymic.ToLower().Contains(txtFam.Text.ToLower()) || txtFam.Text == "")))
                    .ToList();
                foreach (var employee in employees)
                {
                    AddOrderView(employee);
                }
                tsslCountEmployee.Text = "Кол-во сотрудников: " + db.Employees.Where(x => x.Person.LastName != "Администратор").Count();
                tsslCountOnStation.Text = "Кол-во сотрудников на станции: " + db.Employees.Where(x => x.StationId == station.Id && x.Person.LastName != "Администратор").Count();
                tsslStatusEmployee.Text = "Кол-во работающих сотрудников: " + db.Employees.Where(x => x.StatusEmployeeId == 1 && x.Person.LastName != "Администратор").Count();
                if(employees.Count() <= 0)
                {
                    MessageBox.Show("Ничего не найдено", "Поиск!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        public void FillEmployeeView()
        {
            flpEmployees.Controls.Clear();
            using (var db = new AccountingMetroDBContext())
            {
                List<Employee> listEmployee;
                listEmployee = db.Employees
                    .Include(x => x.Person)
                    .Include(x => x.Station)
                    .Include(x => x.Train)
                    .Include(x => x.Post)
                    .ToList();
                foreach (var employee in listEmployee)
                {
                    AddOrderView(employee);
                }
            }
            Filter();
        }

        public void AddOrderView(Employee employee)
        {
            var employeeControl = new EmployeeView(employee);
            employeeControl.Parent = flpEmployees;
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

        private void cmbPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender.Equals(cmbVetka))
            {
                FillComboBoxStation();
            }

            if (sender.Equals(cmbStation))
            {
                tsslCountOnStation.Visible = ((Station)cmbStation.SelectedItem).Id != -1;
            }
            Filter();
        }

        private void tssmBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var ev = new EmployeeViewForm();
            this.Hide();
            ev.ShowDialog();
            FillEmployeeView();
            this.Show();
        }
    }
}
