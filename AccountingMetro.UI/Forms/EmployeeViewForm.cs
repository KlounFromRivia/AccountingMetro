using AccountingMetro.Context;
using AccountingMetro.Context.Models;
using AccountingMetro.UI.General;
using AccountingMetro.UI.Validate;
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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace AccountingMetro.UI.Forms
{
    /// <summary>
    /// Форма добавление/редактирования сотрудника
    /// </summary>
    public partial class EmployeeViewForm : Form
    {
        public Employee Employee { get; set; }

        private byte[] image = null;
        private long status = 1;
        public EmployeeViewForm()
        {
            InitializeComponent();
        }

        public EmployeeViewForm(Employee employee)
        {
            InitializeComponent();
            this.Employee = employee;
        }

        #region Инизиализация формы
        public void Initialize(Employee employee)
        {
            using (var db = new AccountingMetroDBContext())
            {
                txtStagJob.Text = "";
                cmbGender.SelectedItem = cmbGender.Items.Cast<Gender>().FirstOrDefault(x => x.Id == employee.Person.GenderId);
                cmbStatusMari.SelectedItem = cmbStatusMari.Items.Cast<StatusMari>().FirstOrDefault(x => x.Id == employee.Person.StatusMariId);
                cmbVetka.SelectedItem = cmbVetka.Items.Cast<Vetka>().FirstOrDefault(x => x.Id == employee.Station.VetkaId);
                cmbPost.SelectedItem = cmbPost.Items.Cast<Post>().FirstOrDefault(x => x.Id == employee.PostId);

                txtNomeContract.Text = employee.Id.ToString();
                mtxtWorkPhone.Text = employee.PhoneWork;
                numNormShift.Value = employee.NormShift;
                numSalary.Value = employee.Salary;
                numAllowance.Value = employee.Allowance;
                numVacation.Value = employee.Vacation;
                dtpContract.Text = employee.ContractDay.ToString();
                dtpJob.Text = employee.EmploymentDay.ToString();

                status = employee.StatusEmployeeId;

                txtFam.Text = employee.Person.LastName;
                txtIma.Text = employee.Person.FirstName;
                txtPatr.Text = employee.Person.Patronymic;
                txtEmail.Text = employee.Person.Email;
                txtAdresResid.Text = employee.Person.ResidentAddress;
                dtpBithDay.Text = employee.Person.BirthDay.ToString();
                mtxtMobilePhone.Text = employee.Person.Phone;

                var ecrt = new Encryption();
                var document = db.Documents.FirstOrDefault(x => x.Id == employee.Person.DocumentId);
                txtAdresReg.Text = ecrt.DecryptCipherTextToPlainText(document.RegistratAddress);
                txtAdresPassport.Text = ecrt.DecryptCipherTextToPlainText(document.Issued);
                txtSeriePassport.Text = ecrt.DecryptCipherTextToPlainText(document.PassportSeries);
                txtNomerPassport.Text = ecrt.DecryptCipherTextToPlainText(document.PassportNomer);
                txtINN.Text = ecrt.DecryptCipherTextToPlainText(document.INN);
                txtInsCertific.Text = ecrt.DecryptCipherTextToPlainText(document.InsCertific);
                dtpPassportDate.Text = document.DateIssued.ToString();

                if (employee.Person.ImagePreview != null)
                {
                    var image = new MemoryStream(employee.Person.ImagePreview);
                    picEmployee.Image = Image.FromStream(image);
                }
            }
        }
        #endregion

        private void EmployeeViewForm_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
            if (Employee != null)
            {
                Initialize(Employee);
                ChangeStatusEmployee();
                return;
            }
            Employee = new Employee()
            {
                Id = -1,
            };
            cmbGender.SelectedIndex = 0;
            cmbStatusMari.SelectedIndex = 0;
            cmbVetka.SelectedIndex = 0;
            cmbPost.SelectedIndex = 0;
            tsmiBack.Visible = false;
            tsmiStatus.Visible = false;
            tsmiSave.Text = "Добавить сотрудника";
            ChangeStatusEmployee();
        }

        public void FillComboBoxes()
        {
            using (var db = new AccountingMetroDBContext())
            {
                cmbGender.Items.Clear();
                cmbGender.Items.AddRange(db.Genders.ToArray());
                cmbGender.DisplayMember = nameof(Gender.Title);

                cmbStatusMari.Items.Clear();
                cmbStatusMari.Items.AddRange(db.StatusMaris.ToArray());
                cmbStatusMari.DisplayMember = nameof(StatusMari.Title);

                cmbVetka.Items.Clear();
                cmbVetka.Items.AddRange(db.Vetkas.ToArray());
                cmbVetka.DisplayMember = nameof(Vetka.Title);

                cmbPost.Items.Clear();
                cmbPost.Items.AddRange(db.Posts.ToArray());
                cmbPost.DisplayMember = nameof(Post.Title);

                cmbStation.DisplayMember = nameof(Station.Title);
                cmbTrain.DisplayMember = nameof(Train.Nomer);
            }
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
            if (train != null)
            {
                if (train.StatusTrainId != 1)
                {
                    MessageBox.Show("Поезд под номером " + train.Nomer + " на ремонте!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbTrain.SelectedItem = cmbTrain.Items.Cast<Train>().FirstOrDefault(x => x.Id == Employee.TrainId);

                    if(cmbTrain.SelectedItem == null)
                    {
                        cmbTrain.SelectedItem = cmbTrain.Items.Cast<Train>().FirstOrDefault(x => x.StatusTrainId == 1);
                    }
                }
            }
            ValidateInput();
        }

        private void numSalary_ValueChanged(object sender, EventArgs e)
        {
            FillNoneDB();
            ValidateInput();
        }

        private void FillComboBoxStation()
        {
            using (var db = new AccountingMetroDBContext())
            {
                cmbStation.Items.Clear();
                var post = (Post)cmbPost.SelectedItem;
                var vetka = (Vetka)cmbVetka.SelectedItem;
                if (post != null && post.Id == 1)
                {
                    cmbStation.Items.Add(db.Stations.Where(x => x.VetkaId == vetka.Id).FirstOrDefault());
                    cmbStation.Items.Add(db.Stations.Where(x => x.VetkaId == vetka.Id).OrderByDescending(x => x.Id)
                        .FirstOrDefault());
                }
                else
                {
                    cmbStation.Items.AddRange(db.Stations.Where(x => x.VetkaId == vetka.Id).ToArray());
                }
                cmbStation.SelectedItem = cmbStation.Items.Cast<Station>().FirstOrDefault(x => x.Id == Employee.StationId);
                if(cmbStation.SelectedItem == null)
                {
                    cmbStation.SelectedIndex = 0;
                }
            }
        }
        private void FillComboBoxTrain()
        {
            using (var db = new AccountingMetroDBContext())
            {
                cmbTrain.Items.Clear();
                var post = (Post)cmbPost.SelectedItem;
                var vetka = (Vetka)cmbVetka.SelectedItem;
                if (post != null && post.Id == 1)
                {
                    cmbTrain.Items.AddRange(db.Trains.Where(x => x.VetkaId == vetka.Id).ToArray());
                }
                cmbTrain.SelectedItem = cmbTrain.Items.Cast<Train>().FirstOrDefault(x => x.Id == Employee.TrainId);
                if (cmbTrain.SelectedItem == null 
                    && cmbTrain.Items.Count > 0)
                {
                    cmbTrain.SelectedIndex = 0;
                }
            }
        }

        private void cmbPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboBoxStation();
            FillComboBoxTrain();
            cmbTrain.Visible = lblTrain.Visible = cmbPost.SelectedItem != null && ((Post)cmbPost.SelectedItem).Id == 1;
            ValidateInput();
        }

        private void cmbVetka_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboBoxStation();
            FillComboBoxTrain();
            ValidateInput();
        }

        #region Проверка данных
        public void ValidateInput()
        {
            if (DateTime.Now.Year - dtpBithDay.Value.Year < 16)
            {
                var tooltip = new ToolTip();

                tooltip.SetToolTip(dtpBithDay, "");
                tooltip.Show("Возраст должен быть больше 16!", dtpBithDay, 2000);
            }

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
        }
        #endregion

        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var station = (Station)cmbStation.SelectedItem;
            if (station != null)
            {
                if (station.StatusStationId != 1)
                {
                    MessageBox.Show("Станция " + station.Title + " на реконструкции!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbStation.SelectedItem = cmbStation.Items.Cast<Station>().FirstOrDefault(x => x.Id == Employee.StationId);

                    if (cmbStation.SelectedItem == null)
                    {
                        cmbStation.SelectedItem = cmbStation.Items.Cast<Station>().FirstOrDefault(x => x.StatusStationId == 1);
                    }
                }
            }
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
                image = File.ReadAllBytes(openFileDialog1.FileName);
                picEmployee.Image = Image.FromStream(new MemoryStream(image));
            }
        }

        private void tsmiBack_Click(object sender, EventArgs e)
        {
            Initialize(Employee);
            FillNoneDB();
        }

        #region Сохранение данных
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы хотите сохранить данные сотрудника?", "Подтвердите действие",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var ecrt = new Encryption();
                using (var db = new AccountingMetroDBContext())
                {
                    var employee = Employee.Id == -1
                        ? Employee
                        : db.Employees.Include(x => x.Person.Document).FirstOrDefault(x => x.Id == Employee.Id);

                    if (employee.Id == -1)
                    {
                        var document = new Document()
                        {
                            Id = db.Documents.Count(),
                            PassportSeries = ecrt.EncryptPlainTextToCipherText(txtSeriePassport.Text),
                            PassportNomer = ecrt.EncryptPlainTextToCipherText(txtNomerPassport.Text),
                            Issued = ecrt.EncryptPlainTextToCipherText(txtAdresPassport.Text),
                            DateIssued = dtpPassportDate.Value,
                            INN = ecrt.EncryptPlainTextToCipherText(txtINN.Text),
                            InsCertific = ecrt.EncryptPlainTextToCipherText(txtInsCertific.Text),
                            RegistratAddress = ecrt.EncryptPlainTextToCipherText(txtAdresReg.Text),
                        };
                        db.Documents.Add(document);
                        db.SaveChanges();

                        var person = new Person()
                        {
                            Id = db.Persons.Count(),
                            LastName = txtFam.Text,
                            FirstName = txtIma.Text,
                            Patronymic = txtPatr.Text,
                            Phone = mtxtMobilePhone.Text,
                            Email = txtEmail.Text,
                            ResidentAddress = txtAdresResid.Text,
                            BirthDay = dtpBithDay.Value,
                            GenderId = ((Gender)cmbGender.SelectedItem).Id,
                            StatusMariId = ((StatusMari)cmbStatusMari.SelectedItem).Id,
                            DocumentId = db.Documents.FirstOrDefault(x => x.Id == document.Id).Id,
                        };
                        if (picEmployee.Image != Properties.Resources.employee)
                        {
                            person.ImagePreview = image;
                        }
                        db.Persons.Add(person);
                        db.SaveChanges();

                        employee = new Employee()
                        {
                            Id = db.Employees.Count(),
                            PersonId = db.Persons.FirstOrDefault(x => x.Id == person.Id).Id,
                            ContractDay = dtpContract.Value,
                            EmploymentDay = dtpJob.Value,
                            PhoneWork = mtxtWorkPhone.Text,
                            NormShift = (int)numNormShift.Value,
                            Salary = (int)numSalary.Value,
                            Allowance = (int)numAllowance.Value,
                            Vacation = (int)numVacation.Value,
                            PostId = ((Post)cmbPost.SelectedItem).Id,
                            StationId = ((Station)cmbStation.SelectedItem).Id,
                            StatusEmployeeId = status,
                        };
                        if (cmbTrain.Visible == true)
                        {
                            employee.TrainId = ((Train)cmbTrain.SelectedItem).Id;
                        }
                        db.Employees.Add(employee);
                        db.SaveChanges();
                        MessageBox.Show("Все данные сохранены", "Добавление сотрудника", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }

                    employee.Person.Document.PassportSeries = ecrt.EncryptPlainTextToCipherText(txtSeriePassport.Text);
                    employee.Person.Document.PassportNomer = ecrt.EncryptPlainTextToCipherText(txtNomerPassport.Text);
                    employee.Person.Document.Issued = ecrt.EncryptPlainTextToCipherText(txtAdresPassport.Text);
                    employee.Person.Document.DateIssued = dtpPassportDate.Value;
                    employee.Person.Document.INN = ecrt.EncryptPlainTextToCipherText(txtINN.Text);
                    employee.Person.Document.InsCertific = ecrt.EncryptPlainTextToCipherText(txtInsCertific.Text);
                    employee.Person.Document.RegistratAddress = ecrt.EncryptPlainTextToCipherText(txtAdresReg.Text);

                    employee.Person.LastName = txtFam.Text;
                    employee.Person.FirstName = txtIma.Text;
                    employee.Person.Patronymic = txtPatr.Text;
                    employee.Person.Phone = mtxtMobilePhone.Text;
                    employee.Person.Email = txtEmail.Text;
                    employee.Person.ResidentAddress = txtAdresResid.Text; 
                    if (image != null)
                    {
                        employee.Person.ImagePreview = image;
                    }
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
                    employee.StatusEmployeeId = status;
                    if (cmbTrain.Visible == true)
                    {
                        employee.TrainId = ((Train)cmbTrain.SelectedItem).Id;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Все данные сохранены", "Сохранение изменений", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        #endregion

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeStatusEmployee()
        {
            if(CurrentEmployee.StaffDepart.Id != 1 && Employee.PostId == 9)
            {
                tsmiStatus.Enabled = cmbPost.Enabled = false;
            }
            tsmiWork.Enabled = status != 1
                ? true
                : false;

            tsmiToFire.Enabled =
                grpContactInfo.Enabled =
                    grpDocument.Enabled =
                    grpPerson.Enabled =
                    grpJob.Enabled = status != 2
                ? true
                : false;

            if (status == 1)
            {
                tsmiWork.Text = "Работает";
                tsmiToFire.Text = "Уволить";
                return;
            }
            tsmiWork.Text = "Восстановить";
            tsmiToFire.Text = "Уволен";
        }

        private void tsmiWork_Click(object sender, EventArgs e)
        {
            status = 1;
            ChangeStatusEmployee();
        }

        private void tsmiToFire_Click(object sender, EventArgs e)
        {
            status = 2;
            ChangeStatusEmployee();
        }
    }
}
