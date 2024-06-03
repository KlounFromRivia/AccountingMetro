using AccountingMetro.Context;
using AccountingMetro.Context.Models;
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

namespace AccountingMetro.UI.Forms
{
    public partial class EmployeeViewForm : Form
    {
        public Employee Employee { get; set; }

        private string photoUrl = null;

        public EmployeeViewForm(Employee employee)
        {
            InitializeComponent();
            this.Employee = employee;
            Initialize(employee);
        }

        public void Initialize(Employee employee)
        {
            #region Инизиализация формы
            using (var db = new AccountingMetroDBContext())
            {
                txtStagJob.Text = "";
                cmbGender.DataSource = db.Genders.ToList();
                cmbGender.DisplayMember = nameof(Gender.Title);
                cmbGender.ValueMember = nameof(Gender.Id);
                cmbGender.SelectedItem = cmbGender.Items.Cast<Gender>().FirstOrDefault(x => x.Id == employee.Person.GenderId);

                cmbStatusMari.DataSource = db.StatusMaris.ToList();
                cmbStatusMari.DisplayMember = nameof(StatusMari.Title);
                cmbStatusMari.ValueMember = nameof(StatusMari.Id);
                cmbStatusMari.SelectedItem = cmbStatusMari.Items.Cast<StatusMari>().FirstOrDefault(x => x.Id == employee.Person.StatusMariId);

                cmbPost.DataSource = db.Posts.ToList();
                cmbPost.DisplayMember = nameof(Post.Title);
                cmbPost.ValueMember = nameof(Post.Id);
                cmbPost.SelectedItem = cmbPost.Items.Cast<Post>().FirstOrDefault(x => x.Id == employee.PostId);

                cmbVetka.DataSource = db.Vetkas.ToList();
                cmbVetka.DisplayMember = nameof(Vetka.Title);
                cmbVetka.ValueMember = nameof(Vetka.Id);
                cmbVetka.SelectedItem = cmbVetka.Items.Cast<Vetka>().FirstOrDefault(x => x.Id == employee.Station.VetkaId);

                txtNomeContract.Text = employee.Id.ToString();
                mtxtWorkPhone.Text = employee.PhoneWork;
                numNormShift.Value = employee.NormShift;
                numSalary.Value = employee.Salary;
                numAllowance.Value = employee.Allowance;
                numVacation.Value = employee.Vacation;
                dtpContract.Text = employee.ContractDay.ToString();
                dtpJob.Text = employee.EmploymentDay.ToString();


                txtFam.Text = employee.Person.LastName;
                txtIma.Text = employee.Person.FirstName;
                txtPatr.Text = employee.Person.Patronymic;
                txtEmail.Text = employee.Person.Email;
                txtAdresResid.Text = employee.Person.ResidentAddress;
                dtpBithDay.Text = employee.Person.BirthDay.ToString();
                mtxtMobilePhone.Text = employee.Person.Phone;

                var document = db.Documents.FirstOrDefault(x => x.Id == employee.Person.DocumentId);
                txtAdresReg.Text = document.RegistratAddress;
                txtAdresPassport.Text = document.Issued;
                txtSeriePassport.Text = document.PassportSeries;
                txtNomerPassport.Text = document.PassportNomer;
                txtINN.Text = document.INN;
                txtInsCertific.Text = document.InsCertific;
                dtpPassportDate.Text = document.DateIssued.ToString();

                if (employee.Person.ImagePreview != null)
                {
                    var image = Image.FromStream(new MemoryStream(employee.Person.ImagePreview));
                    picEmployee.Image = image;
                }
            }
            #endregion
        }

        public void FillNoneDB()
        {
            using (var db = new AccountingMetroDBContext())
            {
                txtAllSalary.Text = (numSalary.Value + numSalary.Value * (numAllowance.Value / 100)).ToString();

                txtAge.Text = (DateTime.Now.Year - dtpBithDay.Value.Year).ToString();

                TimeSpan difference = DateTime.Now.Subtract(dtpJob.Value);
                int years = difference.Days / 365;
                int months = (difference.Days % 365) / 30;
                int days = (difference.Days % 365) % 30;
                txtStagJob.Text = $"{years} г., {months} м., {days} д.";
            }
        }

        private void cmbTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            var train = (Train)cmbTrain.SelectedItem;
            if(train != null)
            {
                if (train.StatusTrainId != 1)
                {
                    MessageBox.Show("Поезд под номером " + train.Nomer + " на ремонте!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbTrain.SelectedItem = cmbTrain.Items.Cast<Train>().FirstOrDefault(x => x.Id == Employee.TrainId);
                }
            }
            ValidateInput();
        }

        private void numSalary_ValueChanged(object sender, EventArgs e)
        {
            FillNoneDB();
            ValidateInput();
        }

        private void FillComboBoxPost()
        {
            using (var db = new AccountingMetroDBContext())
            {
                var employee = db.Employees
                    .Include(x => x.Station)
                    .Include(x => x.Station.Vetka)
                    .FirstOrDefault(x => x.Id == Employee.Id);

                var post = (Post)cmbPost.SelectedItem;
                cmbStation.Items.Clear();
                cmbTrain.Items.Clear();
                cmbStation.DisplayMember = nameof(Station.Title);
                cmbTrain.DisplayMember = nameof(Train.Nomer);

                if (post.Id == 1)
                {
                    cmbTrain.Enabled = true;
                    cmbTrain.Visible = true;
                    cmbTrain.Items.AddRange(db.Trains.Where(x => x.VetkaId == employee.Station.VetkaId).ToArray());
                    cmbTrain.SelectedItem = cmbTrain.Items.Cast<Train>().FirstOrDefault(x => x.Id == employee.TrainId);

                    cmbStation.Items.Add(db.Stations.Where(x => x.VetkaId == employee.Station.VetkaId).FirstOrDefault());
                    cmbStation.Items.Add(db.Stations.Where(x => x.VetkaId == employee.Station.VetkaId).OrderByDescending(x => x.Id)
                        .FirstOrDefault());
                }
                else
                {
                    cmbTrain.Enabled = false;
                    cmbTrain.Visible = false;
                    cmbStation.Items.AddRange(db.Stations.Where(x => x.VetkaId == employee.Station.VetkaId).ToArray());
                    cmbStation.SelectedItem = cmbStation.Items.Cast<Station>().FirstOrDefault(x => x.Id == employee.StationId);
                }
            }
        }
        private void FillComboBoxVetka()
        {
            using (var db = new AccountingMetroDBContext())
            {
                var employee = db.Employees
                    .Include(x => x.Station)
                    .Include(x => x.Station.Vetka)
                    .FirstOrDefault(x => x.Id == Employee.Id);

                var post = (Post)cmbPost.SelectedItem;
                var vetka = (Vetka)cmbVetka.SelectedItem;
                cmbStation.Items.Clear();
                cmbTrain.Items.Clear();
                cmbStation.DisplayMember = nameof(Station.Title);
                cmbTrain.DisplayMember = nameof(Train.Nomer);

                if (post.Id == 1)
                {
                    cmbTrain.Enabled = true;
                    cmbTrain.Visible = true;
                    cmbTrain.Items.AddRange(db.Trains.Where(x => x.VetkaId == vetka.Id).ToArray());
                    cmbTrain.SelectedItem = cmbTrain.Items.Cast<Train>().FirstOrDefault(x => x.Id == employee.TrainId);

                    cmbStation.Items.Add(db.Stations.Where(x => x.VetkaId == vetka.Id).FirstOrDefault());
                    cmbStation.Items.Add(db.Stations.Where(x => x.VetkaId == vetka.Id).OrderByDescending(x => x.Id)
                        .FirstOrDefault());
                }
                else
                {
                    cmbTrain.Enabled = false;
                    cmbTrain.Visible = false;
                    cmbStation.Items.AddRange(db.Stations.Where(x => x.VetkaId == vetka.Id).ToArray());
                    cmbStation.SelectedItem = cmbStation.Items.Cast<Station>().FirstOrDefault(x => x.Id == employee.StationId);
                }
            }
        }

        private void cmbPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender.Equals(cmbPost))
            {
                FillComboBoxPost();
            }
            ValidateInput();
        }

        private void cmbVetka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender.Equals(cmbVetka))
            {
                FillComboBoxVetka();
            }
            ValidateInput();
        }

        public void ValidateInput()
        {
            #region Проверка данных
            TimeSpan job = dtpJob.Value.Subtract(dtpContract.Value);

            if (cmbTrain.Enabled == true && cmbTrain.Visible == true)
            {
                tsmiSave.Enabled = !string.IsNullOrEmpty(txtFam.Text) &&
                    !string.IsNullOrEmpty(txtIma.Text) &&
                    !string.IsNullOrEmpty(txtAdresPassport.Text) &&
                    !string.IsNullOrEmpty(txtAdresReg.Text) &&
                    !string.IsNullOrEmpty(mtxtWorkPhone.Text) &&
                    txtSeriePassport.Text.Length == 4 &&
                    txtNomerPassport.Text.Length == 6 &&
                    txtINN.Text.Length == 12 &&
                    txtInsCertific.Text.Length == 16 &&
                    DateTime.Now.Year - dtpBithDay.Value.Year >= 16 &&
                    job.Days >= 1 &&
                    cmbStation.SelectedIndex >= 0 && 
                    cmbTrain.SelectedIndex >= 0;
            }
            else
            {
                tsmiSave.Enabled = !string.IsNullOrEmpty(txtFam.Text) &&
                    !string.IsNullOrEmpty(txtIma.Text) &&
                    !string.IsNullOrEmpty(txtAdresPassport.Text) &&
                    !string.IsNullOrEmpty(txtAdresReg.Text) &&
                    !string.IsNullOrEmpty(mtxtWorkPhone.Text) &&
                    txtSeriePassport.Text.Length == 4 &&
                    txtNomerPassport.Text.Length == 6 &&
                    txtINN.Text.Length == 12 &&
                    txtInsCertific.Text.Length == 16 &&
                    DateTime.Now.Year - dtpBithDay.Value.Year >= 16 &&
                    job.Days >= 1 &&
                    cmbStation.SelectedIndex >= 0;
            }
            #endregion
        }

        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtFam_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtSeriePassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void picEmployee_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var image = File.ReadAllBytes(openFileDialog1.FileName);
                using (var db = new AccountingMetroDBContext())
                {
                    Employee.Person.ImagePreview = image;
                    db.Entry(Employee.Person).State = EntityState.Modified;
                    db.SaveChanges();
                }
                picEmployee.Image = Image.FromStream(new MemoryStream(Employee.Person.ImagePreview));
            }
        }

        private void tsmiBack_Click(object sender, EventArgs e)
        {
            Initialize(Employee);
            FillNoneDB();
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            using (var db = new AccountingMetroDBContext())
            {
                var employee = db.Employees.Include(x => x.Person.Document).FirstOrDefault(x => x.Id == Employee.Id);

                if (employee != null)
                {
                    employee.Person.Document.PassportSeries = txtSeriePassport.Text;
                    employee.Person.Document.PassportNomer = txtNomerPassport.Text;
                    employee.Person.Document.Issued = txtAdresPassport.Text;
                    employee.Person.Document.DateIssued = dtpPassportDate.Value;
                    employee.Person.Document.INN = txtINN.Text;
                    employee.Person.Document.InsCertific = txtInsCertific.Text;
                    employee.Person.Document.RegistratAddress = txtAdresReg.Text;

                    employee.Person.LastName = txtFam.Text;
                    employee.Person.FirstName = txtIma.Text;
                    employee.Person.Patronymic = txtPatr.Text;
                    employee.Person.Phone = mtxtMobilePhone.Text;
                    employee.Person.Email = txtEmail.Text;
                    employee.Person.ResidentAddress = txtAdresResid.Text;
                    employee.Person.BirthDay = dtpBithDay.Value;
                    employee.Person.GenderId = ((Gender)cmbGender.SelectedItem).Id;
                    employee.Person.StatusMariId = ((StatusMari)cmbStatusMari.SelectedItem).Id;

                    employee.ContractDay = dtpContract.Value;
                    employee.EmploymentDay = dtpJob.Value;
                    employee.PhoneWork = mtxtWorkPhone.Text;
                    employee.NormShift = (int)numNormShift.Value;
                    employee.Salary = (int)numSalary.Value;
                    employee.Allowance = (int)numAllowance.Value;
                    employee.Vacation = (int)numVacation.Value;
                    employee.PostId = ((Post)cmbPost.SelectedItem).Id;
                    employee.StationId = ((Station)cmbStation.SelectedItem).Id;
                    if(cmbTrain.Enabled == true)
                    {
                        employee.TrainId = ((Train)cmbTrain.SelectedItem).Id;
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Все данные сохранены", "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
