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

namespace AccountingMetro.UI.Forms
{
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
                FillStationView();


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

                cmbPost.SelectedIndex = 0;
                cmbVetka.SelectedIndex = 0;
            }
        }

        public void FillStationView()
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
        }

        public void AddOrderView(Employee employee)
        {
            var stationControl = new EmployeeView(employee);
            stationControl.Parent = flpEmployees;
            //stationControl.StatusCount += StationControl_StatusCount;
            //CountComplete();
        }
        private void Filter()
        {
            var station = ((Station)cmbStation.SelectedItem);
            var vetka = ((Vetka)cmbVetka.SelectedItem);
            var post = ((Post)cmbPost.SelectedItem);

            //List<Station> listStation;
            //using (var db = new AccountingMetroDBContext())
            //{
            //    listStation = db.Stations
            //                .Include(x => x.Vetka)
            //                .Include(x => x.StatusStation)
            //                .ToList();
            //    foreach (var stationlst in listStation)
            //    {
            //        if (stationlst.VetkaId == vetka.Id)
            //        {
            //            cmbStation.DataSource = db.Stations.Where(x => x.VetkaId == 1).ToList();
            //            cmbStation.DisplayMember = nameof(Station.Title);
            //            cmbStation.ValueMember = nameof(Station.Id);
            //        }
            //    }
            //}

            if (station == null || vetka == null || post == null)
            {
                return;
            }
            foreach (var control in flpEmployees.Controls)
            {
                if (control is EmployeeView employeeView)
                {
                    var visible = true;

                    if (station.Id != -1 && employeeView.Employee.StationId != station.Id)
                    {
                        visible = false;
                    }

                    if (vetka.Id != -1 && employeeView.Employee.Station.VetkaId != vetka.Id)
                    {
                        visible = false;
                    }
                    if (post.Id != -1 && employeeView.Employee.PostId != post.Id)
                    {
                        visible = false;
                    }

                    if (!string.IsNullOrWhiteSpace(txtSearchFIO.Text) && !employeeView.Employee.Person.LastName.ToLower().Contains(txtSearchFIO.Text.ToLower()))
                    {
                        visible = false;
                    }

                    employeeView.Visible = visible;
                }
            }
        }

        private void StationControl_StatusCount()
        {
            CountComplete();
        }
        public void CountComplete()
        {
            int CountComplete = 0;

            foreach (var status in flpEmployees.Controls)
            {
                if (status is StationView controlStation)
                {
                    if (controlStation.Station.StatusStationId == 1)
                    {
                        CountComplete++;
                    }
                }
            }
            //tsslStatusStaion.Text = "Окрытых станций: " + CountComplete.ToString();
        }

        private void FillComboBoxStation()
        {
            using (var db = new AccountingMetroDBContext())
            {
                var vetka = (Vetka)cmbVetka.SelectedItem;
                cmbStation.Items.Clear();
                if(vetka.Id == -1)
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
            if(sender.Equals(cmbVetka))
            {
                //lblStation.Visible = cmbStation.Visible = ((Vetka)cmbVetka.SelectedItem).Id != -1;
                FillComboBoxStation();
            }
            Filter();
        }
    }
}
