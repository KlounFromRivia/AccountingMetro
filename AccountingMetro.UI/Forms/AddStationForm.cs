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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AccountingMetro.UI.Forms
{
    /// <summary>
    /// Форма добавления новой станции
    /// </summary>
    public partial class AddStationForm : Form
    {
        public string TitleStation { get; set; }
        public AddStationForm()
        {
            InitializeComponent();
            Initializity();

        }
        public void Initializity()
        {
            using (var db = new AccountingMetroDBContext())
            {
                cmbStatus.DataSource = db.StatusStations.ToList();
                cmbStatus.DisplayMember = nameof(StatusStation.Title);
                cmbStatus.ValueMember = nameof(StatusStation.Id);

                cmbVetka.DataSource = db.Vetkas.ToList();
                cmbVetka.DisplayMember = nameof(Vetka.Title);
                cmbVetka.ValueMember = nameof(Vetka.Id);
            }
        }

        private void txtNameStation_TextChanged(object sender, EventArgs e)
        {
            TitleStation = txtNameStation.Text;
            btnSave.Enabled = !string.IsNullOrEmpty(txtNameStation.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Новая станция добавлена!", "Сохранение данных",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
