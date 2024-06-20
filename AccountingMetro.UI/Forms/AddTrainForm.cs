using AccountingMetro.Context.Models;
using AccountingMetro.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingMetro.UI.Forms
{
    /// <summary>
    /// Форма добавления нового электропоезда
    /// </summary>
    public partial class AddTrainForm : Form
    {
        public string TitleTrain { get; set; }
        public AddTrainForm()
        {
            InitializeComponent();
            Initializity();
        }
        public void Initializity()
        {
            using (var db = new AccountingMetroDBContext())
            {
                cmbStatus.DataSource = db.StatusTrains.ToList();
                cmbStatus.DisplayMember = nameof(StatusTrain.Title);
                cmbStatus.ValueMember = nameof(StatusTrain.Id);

                cmbVetka.DataSource = db.Vetkas.ToList();
                cmbVetka.DisplayMember = nameof(Vetka.Title);
                cmbVetka.ValueMember = nameof(Vetka.Id);
            }
        }

        private void txtNomerTrain_TextChanged(object sender, EventArgs e)
        {
            TitleTrain = txtNomerTrain.Text;
            btnSave.Enabled = !string.IsNullOrEmpty(txtNomerTrain.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Новый поезд добавлен!", "Сохранение данных",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
