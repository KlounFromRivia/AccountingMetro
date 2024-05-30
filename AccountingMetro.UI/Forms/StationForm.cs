using AccountingMetro.Context;
using AccountingMetro.Context.Models;
using AccountingMetro.UI.UserControls;
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

namespace AccountingMetro.UI.Forms
{
    public partial class StationForm : Form
    {
        public StationForm()
        {
            InitializeComponent();
            ToolTip tl = new ToolTip();
            tl.SetToolTip(btnAddStation, "Нажмите, чтобы добавить новую станцию");
            InitControls();
            InitList();
        }

        public void InitControls()
        {
            using (var db = new AccountingMetroDBContext())
            {
                FillStationView();
                cmbStatStation.Items.Clear();
                cmbStatStation.Items.AddRange(db.StatusStations.ToArray());
                cmbStatStation.Items.Insert(0, new StatusStation()
                {
                    Id = -1,
                    Title = "Все станции"
                });
                cmbStatStation.DisplayMember = nameof(StatusStation.Title);

                cmbVetka.Items.Clear();
                cmbVetka.Items.AddRange(db.Vetkas.ToArray());
                cmbVetka.Items.Insert(0, new Vetka()
                {
                    Id = -1,
                    Title = "Все ветки"
                });
                cmbVetka.DisplayMember = nameof(Vetka.Title);

                cmbStatStation.SelectedIndex = 0;
                cmbVetka.SelectedIndex = 0;
            }
        }

        public void FillStationView()
        {
            flpStation.Controls.Clear();
            using (var db = new AccountingMetroDBContext())
            {
                List<Station> listStation;
                listStation = db.Stations
                    .Include(x => x.StatusStation)
                    .Include(x => x.Vetka)
                    .ToList();
                foreach (var station in listStation)
                {
                    AddOrderView(station);
                }
            }
        }
        public void InitList()
        {
            using (var db = new AccountingMetroDBContext())
            {
                List<Vetka> listVetka;
                listVetka = db.Vetkas
                    .OrderBy(x => x.Title)
                    .ToList();
                foreach (var vetka in listVetka)
                {
                    lstVetka.Items.Add(vetka.Title);
                }
            }
        }

        private void Filter()
        {
            var status = ((StatusStation)cmbStatStation.SelectedItem);
            var vetka = ((Vetka)cmbVetka.SelectedItem);
            if (status == null || vetka == null)
            {
                return;
            }
            foreach (var control in flpStation.Controls)
            {
                if (control is StationView stationView)
                {
                    var visible = true;

                    if (status.Id != -1 && stationView.Station.StatusStationId != status.Id)
                    {
                        visible = false;
                    }

                    if (vetka.Id != -1 && stationView.Station.VetkaId != vetka.Id)
                    {
                        visible = false;
                    }

                    if (!string.IsNullOrWhiteSpace(txtSearchStation.Text) && !stationView.Station.Title.ToLower().Contains(txtSearchStation.Text.ToLower()))
                    {
                        visible = false;
                    }

                    stationView.Visible = visible;
                }
            }
        }

        private void txtNameVetka_TextChanged(object sender, EventArgs e)
        {
            btnAddVetka.Enabled = !string.IsNullOrEmpty(txtNameVetka.Text);
        }
        public void AddOrderView(Station station)
        {
            var stationControl = new StationView(station);
            stationControl.Parent = flpStation;
            stationControl.StatusCount += StationControl_StatusCount;
            CountComplete();
        }

        public void CountComplete()
        {
            int CountComplete = 0;

            foreach (var status in flpStation.Controls)
            {
                if (status is StationView controlStation)
                {
                    if (controlStation.Station.StatusStationId == 1)
                    {
                        CountComplete++;
                    }
                }
            }
            tsslStatusStaion.Text = "Окрытых станций: " + CountComplete.ToString();
        }

        private void StationControl_StatusCount()
        {
            CountComplete();
        }

        private void cmbStatStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void tsmiBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы хотите добавить новую станцию?", "Подтвердите действие",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var acf = new AddStationForm();
                if (acf.ShowDialog() == DialogResult.OK)
                {
                    var station = new Station()
                    {
                        Title = acf.TitleStation,
                        StatusStationId = ((StatusStation)acf.cmbStatus.SelectedItem).Id,
                        VetkaId = ((Vetka)acf.cmbVetka.SelectedItem).Id,
                    };
                    using (var db = new AccountingMetroDBContext())
                    {
                        db.Stations.Add(station);
                        db.SaveChanges();
                    }
                    FillStationView();
                }
            }
        }
    }
}
