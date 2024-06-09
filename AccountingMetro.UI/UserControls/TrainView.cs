using AccountingMetro.Context;
using AccountingMetro.Context.Models;
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
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;
using AccountingMetro.UI.Forms;

namespace AccountingMetro.UI.UserControls
{
    public partial class TrainView : UserControl
    {
        public Train Train { get; set; }
        string element = "";
        public TrainView(Train train)
        {
            InitializeComponent();
            this.Train = train;
            Initialize(train);
        }
        public void Initialize(Train train)
        {
            using (var db = new AccountingMetroDBContext())
            {
                cmbStatus.DataSource = db.StatusTrains.ToList();
                cmbStatus.DisplayMember = nameof(StatusTrain.Title);
                cmbStatus.ValueMember = nameof(StatusTrain.Id);
                cmbStatus.SelectedItem = cmbStatus.Items.Cast<StatusTrain>().FirstOrDefault(x => x.Id == train.StatusTrainId);

                cmbVetka.DataSource = db.Vetkas.ToList();
                cmbVetka.DisplayMember = nameof(Vetka.Title);
                cmbVetka.ValueMember = nameof(Vetka.Id);
                cmbVetka.SelectedItem = cmbVetka.Items.Cast<Vetka>().FirstOrDefault(x => x.Id == train.VetkaId);

                txtNomerTrain.Text = train.Nomer;
                element = train.Nomer;
            }
        }

        private void tsmiBack_Click(object sender, EventArgs e)
        {
            Initialize(Train);
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            using (var db = new AccountingMetroDBContext())
            {
                var train = db.Trains.FirstOrDefault(x => x.Id == Train.Id);

                if (train != null)
                {
                    train.Nomer = txtNomerTrain.Text;
                    train.VetkaId = ((Vetka)cmbVetka.SelectedItem).Id;
                    train.StatusTrainId = ((StatusTrain)cmbStatus.SelectedItem).Id;
                }
                db.SaveChanges();
                MessageBox.Show("Все данные сохранены", "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Train = train;
                ((MetroForm)ParentForm).FillTrainView();
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            using (var db = new AccountingMetroDBContext())
            {
                var employee = db.Employees
                .Include(x => x.Train).FirstOrDefault(x => x.TrainId == Train.Id);
                if (employee == null)
                {
                    if (MessageBox.Show($"Вы уверены, что хотите удалить поезд №{element}?",
                "Подтвердите действие",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        var train = db.Trains.FirstOrDefault(x => x.Id == Train.Id);
                        db.Trains.Remove(train);
                        db.SaveChanges();
                        MessageBox.Show("Все данные сохранены", "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Train = train;
                        ((MetroForm)ParentForm).FillTrainView();
                    }
                }
                else
                {
                    MessageBox.Show($"Нельзя удалить поезд №{element}, так как на ней работает машинист",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void txtNomerTrain_TextChanged(object sender, EventArgs e)
        {
            tsmiSave.Enabled = !string.IsNullOrEmpty(txtNomerTrain.Text);
        }
    }
}
