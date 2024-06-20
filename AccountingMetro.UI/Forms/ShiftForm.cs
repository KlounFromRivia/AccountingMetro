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
using Excel = Microsoft.Office.Interop.Excel;
using AccountingMetro.UI.General;
using System.Xml.Linq;
using AccountingMetro.UI.Validate;

namespace AccountingMetro.UI.Forms
{
    /// <summary>
    /// Форма рабочих смен сотрудников
    /// </summary>
    public partial class ShiftForm : Form
    {
        public bool selectedForm = true;
        public Employee Employee { get; set; }
        public ShiftForm()
        {
            InitializeComponent();
        }
        public ShiftForm(Employee employee)
        {
            InitializeComponent();
            this.Employee = employee;
        }
        public void InitControls()
        {
            using (var db = new AccountingMetroDBContext())
            {
                cmbStatusShift.Items.Clear();
                cmbStatusShift.Items.AddRange(db.StatusShifts.ToArray());
                cmbStatusShift.Items.Insert(0, new StatusShift()
                {
                    Id = -1,
                    Title = "Все смены"
                });
                cmbStatusShift.DisplayMember = nameof(StatusShift.Title);

                cmbStation.Items.Clear();
                cmbStation.Items.AddRange(db.Stations.ToArray());
                cmbStation.Items.Insert(0, new Station()
                {
                    Id = -1,
                    Title = "Все станции"
                });
                cmbStation.DisplayMember = nameof(Station.Title);

                cmbPost.Items.Clear();
                cmbPost.Items.AddRange(db.Posts.ToArray());
                cmbPost.Items.Insert(0, new Post()
                {
                    Id = -1,
                    Title = "Все должности"
                });
                cmbPost.DisplayMember = nameof(Post.Title);
            }
        }

        private void ShiftForm_Load(object sender, EventArgs e)
        {
            InitControls();
            if (Employee != null)
            {
                ShiftEmployeeHandler(Employee);
                btnStartShift.Visible = true;
                FilterNone();
                return;
            }
            ShiftHandler();
            selectedForm = false;
            FilterNone();
        }

        private void FilterNone()
        {
            dgvShift.ClearSelection();
            cmbStatusShift.SelectedIndex = 0;
            cmbStation.SelectedIndex = 0;
            cmbPost.SelectedIndex = 0;
            txtSearchFIO.Text = "";
        }

        #region Смены всех сотрудников
        public void ShiftHandler()
        {
            using (var db = new AccountingMetroDBContext())
            {
                dgvShift.DataSource = db.Shifts
                    .Include(x => x.Employee.Person)
                    .Include(x => x.Employee.Station)
                    .Include(x => x.Employee.Post)
                    .Include(x => x.Employee)
                    .Include(x => x.StatusChange)
                    .Select(x => new
                    {
                        Id = x.Id,
                        EmployeeId = x.Employee.Id,
                        EmployeeFIO = x.Employee.Person.LastName + " " +
                        x.Employee.Person.FirstName + " " +
                        x.Employee.Person.Patronymic,

                        Post = x.Employee.Post.Title,
                        PlaceJob = x.PlaceWork,
                        WorkPhone = x.Employee.PhoneWork,
                        NormaShift = x.Employee.NormShift,
                        ShiftOpen = x.ShiftOpened,
                        ShiftClose = x.ShiftClosed,
                        StatusShift = x.StatusChange.Title
                    })
                    .ToList();
            }
            dgvShift.ClearSelection();
        }
        #endregion

        #region Смены сотрудника
        public void ShiftEmployeeHandler(Employee employee)
        {
            using (var db = new AccountingMetroDBContext())
            {
                grpPoisk.Width = 320;
                lblFio.Visible = txtSearchFIO.Visible =
                        lblPost.Visible = cmbPost.Visible =
                        lblStation.Visible = cmbStation.Visible = false;
                dgvShift.DataSource = db.Shifts
                    .Include(x => x.Employee.Person)
                    .Include(x => x.Employee.Station)
                    .Include(x => x.Employee.Post)
                    .Include(x => x.Employee)
                    .Include(x => x.StatusChange)
                    .Where(x => x.EmployeeId == employee.Id)
                    .Select(x => new
                    {
                        Id = x.Id,
                        EmployeeId = x.Employee.Id,
                        EmployeeFIO = x.Employee.Person.LastName + " " +
                        x.Employee.Person.FirstName + " " +
                        x.Employee.Person.Patronymic,

                        Post = x.Employee.Post.Title,
                        PlaceJob = x.PlaceWork,
                        WorkPhone = x.Employee.PhoneWork,
                        NormaShift = x.Employee.NormShift,
                        ShiftOpen = x.ShiftOpened,
                        ShiftClose = x.ShiftClosed,
                        StatusShift = x.StatusChange.Title
                    })
                    .ToList();
                tsslCountSuccessShift.Text = "Кол-во выполненных смен: " + db.Shifts.Where(x => x.EmployeeId == employee.Id && x.StatusChangeId == 1).Count();
            }
            dgvShift.ClearSelection();
        }
        #endregion

        #region Фильтрация
        private void Filter()
        {
            var status = ((StatusShift)cmbStatusShift.SelectedItem);
            var station = ((Station)cmbStation.SelectedItem);
            var post = ((Post)cmbPost.SelectedItem);

            if (station == null || status == null || post == null)
            {
                return;
            }
            using (var db = new AccountingMetroDBContext())
            {
                if (selectedForm == true)
                {
                    #region Фильтрация одного сотрудника
                    dgvShift.DataSource = db.Shifts
                        .Include(x => x.Employee.Person)
                        .Include(x => x.Employee.Station)
                        .Include(x => x.Employee.Post)
                        .Include(x => x.Employee)
                        .Include(x => x.StatusChange)
                        .Where(x => x.EmployeeId == Employee.Id
                        && (x.StatusChangeId == status.Id || status.Id == -1)
                        && (x.ShiftOpened >= dtpStartShift.Value)
                        && (x.ShiftOpened <= dtpEndShift.Value))
                        .Select(x => new
                        {
                            Id = x.Id,
                            EmployeeId = x.Employee.Id,
                            EmployeeFIO = x.Employee.Person.LastName + " " +
                            x.Employee.Person.FirstName + " " +
                            x.Employee.Person.Patronymic,

                            Post = x.Employee.Post.Title,
                            PlaceJob = x.PlaceWork,
                            WorkPhone = x.Employee.PhoneWork,
                            NormaShift = x.Employee.NormShift,
                            ShiftOpen = x.ShiftOpened,
                            ShiftClose = x.ShiftClosed,
                            StatusShift = x.StatusChange.Title
                        })
                        .ToList();
                    tsslCountSuccessShift.Text = "Кол-во выполненных смен: " + db.Shifts.Where(x => x.EmployeeId == Employee.Id && x.StatusChangeId == 1).Count();
                    #endregion
                }
                else
                {
                    #region Фильтрация по всем сотрудникам
                    dgvShift.DataSource = db.Shifts
                        .Include(x => x.Employee.Person)
                        .Include(x => x.Employee.Station)
                        .Include(x => x.Employee.Post)
                        .Include(x => x.Employee)
                        .Include(x => x.StatusChange)
                        .Where(x => (x.Employee.StationId == station.Id || station.Id == -1)
                        && (x.StatusChangeId == status.Id || status.Id == -1)
                        && (x.Employee.PostId == post.Id || post.Id == -1)
                        && (x.ShiftOpened >= dtpStartShift.Value)
                        && (x.ShiftOpened <= dtpEndShift.Value)
                        && (x.Employee.Person.LastName.Contains(txtSearchFIO.Text) || x.Employee.Person.FirstName.Contains(txtSearchFIO.Text)
                        || x.Employee.Person.Patronymic.Contains(txtSearchFIO.Text)))
                        .Select(x => new
                        {
                            Id = x.Id,
                            EmployeeId = x.Employee.Id,
                            EmployeeFIO = x.Employee.Person.LastName + " " +
                            x.Employee.Person.FirstName + " " +
                            x.Employee.Person.Patronymic,

                            Post = x.Employee.Post.Title,
                            PlaceJob = x.PlaceWork,
                            WorkPhone = x.Employee.PhoneWork,
                            NormaShift = x.Employee.NormShift,
                            ShiftOpen = x.ShiftOpened,
                            ShiftClose = x.ShiftClosed,
                            StatusShift = x.StatusChange.Title
                        })
                        .ToList();
                    tsslCountSuccessShift.Text = "Кол-во выполненных смен: " + db.Shifts.Where(x => x.StatusChangeId == 1).Count();
                    #endregion
                }
                if (dgvShift.Rows.Count <= 0)
                {
                    MessageBox.Show("Ничего не найдено", "Поиск!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            btnDelete.Enabled = dgvShift.SelectedRows.Count > 0;
        }
        #endregion

        private void cmbPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void tsmiExport_Click(object sender, EventArgs e)
        {
            var xlApp = new Excel.Application();
            xlApp.Visible = true;

            Excel.Workbook wBook;
            Excel.Worksheet xlSheet;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 30;


            xlSheet = (Excel.Worksheet)wBook.Sheets[1];

            xlSheet.SaveAs($"Отчёт c {dtpStartShift.Value.ToShortDateString()} " +
                $"по {dtpEndShift.Value.ToShortDateString()}.xlsx");

            xlSheet.Name = selectedForm == true
                ? "Смены"
                : "Смены сотрудников";

            xlSheet.Rows[2].Font.Bold = true;
            xlSheet.Cells[2, 1] = "Сотрудник";
            xlSheet.Cells[2, 2] = "Должность";
            xlSheet.Cells[2, 3] = "Место работы";
            xlSheet.Cells[2, 4] = "Рабочий телефон";
            xlSheet.Cells[2, 5] = "Норма смены";
            xlSheet.Cells[2, 6] = "Начало смены";
            xlSheet.Cells[2, 7] = "Конец смены";
            xlSheet.Cells[2, 8] = "Статус смены";

            for (int i = 0; i < dgvShift.Rows.Count; i++)
            {
                for (int j = 0; j < dgvShift.Columns.Count - 2; j++)
                {
                    xlApp.Cells[i + 3, j + 1] = dgvShift.Rows[i].Cells[j+2].Value.ToString();
                }
            }
            xlApp.Columns.AutoFit();
            xlApp.Visible = true;
        }

        private void btnStartShift_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы хотите добавить смену для этого сотрудника?",
            "Добавление смены",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = new AccountingMetroDBContext())
                {
                    var shift = new Shift()
                    {
                        ShiftOpened = DateTime.Now,
                        EmployeeId = Employee.Id,
                    };

                    shift.PlaceWork = Employee.Station.Title;
                    if (Employee.PostId == 1)
                    {
                        shift.PlaceWork = Employee.Station.Title + " - Поезд№" + Employee.Train.Nomer;
                    }

                    shift.StatusChangeId = 2;
                    shift.ShiftClosed = shift.ShiftOpened.AddHours(Employee.NormShift - 2);

                    if (MessageBox.Show($"Сотрудник выполнил смену?",
                    "Статус смены",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        shift.StatusChangeId = 1;
                        shift.ShiftClosed = shift.ShiftOpened.AddHours(Employee.NormShift);
                    }

                    db.Shifts.Add(shift);
                    db.SaveChanges();
                    ShiftEmployeeHandler(Employee);
                }
            }
        }

        private void dtpShift_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvShift.SelectedRows;
            var rowIndex = selectedRows[0].Index - 1;
            var element = selectedRows[0].Cells["ColumnOpenShift"].Value.ToString();


            if (MessageBox.Show($"Вы уверены, что хотите удалить смену за {element}?",
                "Подтвердите действие",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                using (var db = new AccountingMetroDBContext())
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        int.TryParse(row.Cells["ColumnEmployeeId"].Value.ToString(), out var employeeid);
                        if (employeeid == CurrentEmployee.StaffDepart.EmployeeId)
                        {
                            MessageBox.Show($"Нельзя удалить свою смену!",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }

                        int.TryParse(row.Cells["ColumnId"].Value.ToString(), out var id);

                        var shift = db.Shifts.FirstOrDefault(x => x.Id == id);

                        db.Shifts.Remove(shift);
                    }
                    db.SaveChanges();
                }

                if (selectedForm == true)
                {
                    ShiftEmployeeHandler(Employee);
                    if (rowIndex >= 0)
                    {
                        dgvShift.FirstDisplayedScrollingRowIndex = rowIndex;
                    }
                    return;
                }
                ShiftHandler();
                if (rowIndex >= 0)
                {
                    dgvShift.FirstDisplayedScrollingRowIndex = rowIndex;
                }

            }
        }

        private void dgvShift_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = dgvShift.SelectedRows.Count > 0;
        }

        private void tsmiBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiReset_Click(object sender, EventArgs e)
        {
            if (selectedForm == true)
            {
                ShiftEmployeeHandler(Employee);
                FilterNone();
                return;
            }
            ShiftHandler();
            FilterNone();
        }
    }
}
