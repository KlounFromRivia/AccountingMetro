﻿using AccountingMetro.Context;
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
    /// <summary>
    /// Форма работы с метрополитеном
    /// </summary>
    public partial class MetroForm : Form
    {
        public MetroForm()
        {
            InitializeComponent();
            lstVetka.MultiSelect = false;
            ToolTip tl = new ToolTip();
            tl.SetToolTip(btnAddStation, "Нажмите, чтобы добавить новую станцию");
            tl.SetToolTip(btnAddTrain, "Нажмите, чтобы добавить новый поезд");
            tl.SetToolTip(btnAddVetka, "Нажмите, чтобы добавить новую ветку");
            InitControls();
            InitList();
        }

        public void InitControls()
        {
            using (var db = new AccountingMetroDBContext())
            {
                FillStationView();
                FillTrainView();

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

                cmbStatusTrain.Items.Clear();
                cmbStatusTrain.Items.AddRange(db.StatusTrains.ToArray());
                cmbStatusTrain.Items.Insert(0, new StatusTrain()
                {
                    Id = -1,
                    Title = "Все поезда"
                });
                cmbStatusTrain.DisplayMember = nameof(StatusTrain.Title);

                cmbVetkaTrain.Items.Clear();
                cmbVetkaTrain.Items.AddRange(db.Vetkas.ToArray());
                cmbVetkaTrain.Items.Insert(0, new Vetka()
                {
                    Id = -1,
                    Title = "Все ветки"
                });
                cmbVetkaTrain.DisplayMember = nameof(Vetka.Title);

                cmbStatStation.SelectedIndex = 0;
                cmbStatusTrain.SelectedIndex = 0;
                cmbVetka.SelectedIndex = 0;
                cmbVetkaTrain.SelectedIndex = 0;
            }
        }
        #region Станции
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
                    AddStationView(station);
                }
            }
        }
        public void InitList()
        {
            lstVetka.Items.Clear();
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
            lstVetka.SelectedItems.Clear();
        }

        private void FilterStation()
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

        private void cmbStatStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterStation();
        }

        private void txtNameVetka_TextChanged(object sender, EventArgs e)
        {
            btnAddVetka.Enabled = !string.IsNullOrEmpty(txtNameVetka.Text);
        }
        public void AddStationView(Station station)
        {
            var stationControl = new StationView(station);
            stationControl.Parent = flpStation;
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

        private void btnAddVetka_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы хотите добавить новую ветку?", "Подтвердите действие",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var vetka = new Vetka()
                {
                    Title = txtNameVetka.Text,
                };
                using (var db = new AccountingMetroDBContext())
                {
                    db.Vetkas.Add(vetka);
                    db.SaveChanges();
                }
                FillStationView();
                InitList();
                MessageBox.Show("Новая ветка добавлена", "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtNameVetka.Text = "";
        }

        private void lstVetka_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteVETKA.Enabled = lstVetka.SelectedItems.Count > 0;
        }

        private void btnDeleteVETKA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите удалить выбранную ветку?",
                "Подтвердите действие",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                using (var db = new AccountingMetroDBContext())
                {
                    string strVetka = lstVetka.SelectedItems[0].Text;
                    var vetka = db.Vetkas.FirstOrDefault(x => x.Title == strVetka);
                    db.Vetkas.Remove(vetka);
                    db.SaveChanges();
                    MessageBox.Show("Удалена ветка", "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FillStationView();
                InitList();
            }
        }
        #endregion

        #region Поезда
        public void FillTrainView()
        {
            flpTrain.Controls.Clear();
            using (var db = new AccountingMetroDBContext())
            {
                List<Train> listTrain;
                listTrain = db.Trains
                    .Include(x => x.StatusTrain)
                    .Include(x => x.Vetka)
                    .ToList();
                foreach (var train in listTrain)
                {
                    AddTrainView(train);
                }
            }
        }

        public void AddTrainView(Train train)
        {
            var stationControl = new TrainView(train);
            stationControl.Parent = flpTrain;
            stationControl.StatusCountTrain += TrainControl_StatusCount;
            CountTrain();
        }
        private void TrainControl_StatusCount()
        {
            CountTrain();
        }

        public void CountTrain()
        {
            int CountTrain = 0;

            foreach (var train in flpTrain.Controls)
            {
                if (train is TrainView controlTrain)
                {
                    if (controlTrain.Train.StatusTrainId == 1)
                    {
                        CountTrain++;
                    }
                }
            }
            tsslCountTrain.Text = "Работающих поездов: " + CountTrain.ToString();
        }
        private void FilterTrain()
        {
            var status = ((StatusTrain)cmbStatusTrain.SelectedItem);
            var vetka = ((Vetka)cmbVetkaTrain.SelectedItem);
            if (status == null || vetka == null)
            {
                return;
            }
            foreach (var control in flpTrain.Controls)
            {
                if (control is TrainView trainView)
                {
                    var visible = true;

                    if (status.Id != -1 && trainView.Train.StatusTrainId != status.Id)
                    {
                        visible = false;
                    }

                    if (vetka.Id != -1 && trainView.Train.VetkaId != vetka.Id)
                    {
                        visible = false;
                    }

                    if (!string.IsNullOrWhiteSpace(txtSearchTrain.Text) && !trainView.Train.Nomer.ToLower().Contains(txtSearchTrain.Text.ToLower()))
                    {
                        visible = false;
                    }

                    trainView.Visible = visible;
                }
            }
        }

        private void cmbStatusTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTrain();
        }

        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы хотите добавить новый поезд?", "Подтвердите действие",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var acf = new AddTrainForm();
                if (acf.ShowDialog() == DialogResult.OK)
                {
                    var train = new Train()
                    {
                        Nomer = acf.TitleTrain,
                        StatusTrainId = ((StatusTrain)acf.cmbStatus.SelectedItem).Id,
                        VetkaId = ((Vetka)acf.cmbVetka.SelectedItem).Id,
                    };
                    using (var db = new AccountingMetroDBContext())
                    {
                        db.Trains.Add(train);
                        db.SaveChanges();
                    }
                    FillTrainView();
                }
            }
        }
        #endregion

        private void tsmiBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FillStationCount()
        {
            using (var db = new AccountingMetroDBContext())
            {
                var stationCount = db.Stations.Where(x => x.StatusStationId == 1).Count();
                tsslStatusStation.Text = "Открытых станций: " + stationCount;
            }
        }

        private void flpStation_ControlRemoved(object sender, ControlEventArgs e)
        {
            FillStationCount();
        }
    }
}
