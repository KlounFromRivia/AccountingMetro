using AccountingMetro.Context;
using AccountingMetro.Context.Models;
using AccountingMetro.UI.Forms;
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
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AccountingMetro.UI.UserControls
{
    public partial class StationView : UserControl
    {
        public Station Station { get; set; }
        string element = "";
        public StationView(Station station)
        {
            InitializeComponent();
            this.Station = station;
            Initialize(station);
        }
        public void Initialize(Station station)
        {
            using (var db = new AccountingMetroDBContext())
            {
                cmbStatus.DataSource = db.StatusStations.ToList();
                cmbStatus.DisplayMember = nameof(StatusStation.Title);
                cmbStatus.ValueMember = nameof(StatusStation.Id);
                cmbStatus.SelectedItem = cmbStatus.Items.Cast<StatusStation>().FirstOrDefault(x => x.Id == station.StatusStationId);

                cmbVetka.DataSource = db.Vetkas.ToList();
                cmbVetka.DisplayMember = nameof(Vetka.Title);
                cmbVetka.ValueMember = nameof(Vetka.Id);
                cmbVetka.SelectedItem = cmbVetka.Items.Cast<Vetka>().FirstOrDefault(x => x.Id == station.VetkaId);

                txtNameStation.Text = station.Title;
                element = station.Title;
            }
        }

        private void txtNameStation_TextChanged(object sender, EventArgs e)
        {
            tsmiSave.Enabled = !string.IsNullOrEmpty(txtNameStation.Text);
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            using (var db = new AccountingMetroDBContext())
            {
                var station = db.Stations.FirstOrDefault(x => x.Id == Station.Id);

                if (station != null)
                {
                    station.Title = txtNameStation.Text;
                    station.VetkaId = ((Vetka)cmbVetka.SelectedItem).Id;
                    station.StatusStationId = ((StatusStation)cmbStatus.SelectedItem).Id;
                }
                db.SaveChanges();
                MessageBox.Show("Все данные сохранены", "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Station = station;
                ((MetroForm)ParentForm).FillStationCount();
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            using (var db = new AccountingMetroDBContext())
            {
                var employee = db.Employees
                .Include(x => x.Station).FirstOrDefault(x => x.StationId == Station.Id);
                if (employee == null)
                {
                    if (MessageBox.Show($"Вы уверены, что хотите удалить станцию '{element}'?",
                        "Подтвердите действие",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        var station = db.Stations.FirstOrDefault(x => x.Id == Station.Id);
                        db.Stations.Remove(station);
                        db.SaveChanges();
                        MessageBox.Show("Станция удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Station = station;
                        this.Parent.Controls.Remove(this);
                    }
                }
                else
                {
                    MessageBox.Show($"Нельзя удалить станцию '{element}', так как на ней работают люди",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }

        }

        private void tsmiBack_Click(object sender, EventArgs e)
        {
            Initialize(Station);
        }
    }
}
