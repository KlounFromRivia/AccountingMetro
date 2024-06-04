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

namespace AccountingMetro.UI.Forms
{
    public partial class ShiftForm : Form
    {
        public bool selectedForm = true;
        public Employee Employee { get; set; }
        public ShiftForm()
        {
            InitializeComponent();
            InitControls();
            ShiftHandler();
        }
        public ShiftForm(Employee employee)
        {
            InitializeComponent();
            this.Employee = employee;
            selectedForm = false;
            InitControls();
            ShiftEmployeeHandler(employee);
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

                cmbStatusShift.SelectedIndex = 0;
                cmbStation.SelectedIndex = 0;
                cmbPost.SelectedIndex = 0;
            }
        }
        public void ShiftHandler()
        {
            cmbStatusShift.SelectedIndex = 0;
            cmbStation.SelectedIndex = 0;
            cmbPost.SelectedIndex = 0;
            mntShift.SelectionStart = mntShift.MinDate;
            mntShift.SelectionEnd = DateTime.Now;
            txtSearchFIO.Text = "";
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
                        EmployeeFIO = x.Employee.Person.LastName + " " +
                        x.Employee.Person.FirstName + " " + 
                        x.Employee.Person.Patronymic,

                        Post = x.Employee.Post.Title,
                        PlaceJob = x.Employee.Station.Title,
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
        public void ShiftEmployeeHandler(Employee employee)
        {
            using (var db = new AccountingMetroDBContext())
            {
                panel1.Dock = DockStyle.Left;
                panel1.Width = 184;
                label1.Location = new Point(6, 180);
                cmbStatusShift.Location = new Point(9, 199);
                dgvShift.DataSource = db.Shifts
                    .Include(x => x.Employee.Person)
                    .Include(x => x.Employee.Station)
                    .Include(x => x.Employee.Post)
                    .Include(x => x.Employee)
                    .Include(x => x.StatusChange)
                    .Where(x => x.EmployeeId == employee.Id)
                    .Select(x => new
                    {
                        EmployeeFIO = x.Employee.Person.LastName + " " +
                        x.Employee.Person.FirstName + " " +
                        x.Employee.Person.Patronymic,

                        Post = x.Employee.Post.Title,
                        PlaceJob = x.Employee.Station.Title,
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

        #region Фильтрация
        private void Filter()
        {
            var station = ((Station)cmbStation.SelectedItem);
            var status = ((StatusShift)cmbStatusShift.SelectedItem);
            var post = ((Post)cmbPost.SelectedItem);

            if (station == null || status == null || post == null)
            {
                return;
            }
            using (var db = new AccountingMetroDBContext())
            {
                if(selectedForm != true)
                {
                    dgvShift.DataSource = db.Shifts
                        .Include(x => x.Employee.Person)
                        .Include(x => x.Employee.Station)
                        .Include(x => x.Employee.Post)
                        .Include(x => x.Employee)
                        .Include(x => x.StatusChange)
                        .Where(x => x.EmployeeId == Employee.Id
                        && (x.StatusChangeId == status.Id || status.Id == -1)
                        && (x.ShiftOpened >= mntShift.SelectionStart
                        && x.ShiftClosed <= mntShift.SelectionEnd))
                        .Select(x => new
                        {
                            EmployeeFIO = x.Employee.Person.LastName + " " +
                            x.Employee.Person.FirstName + " " +
                            x.Employee.Person.Patronymic,
                        
                            Post = x.Employee.Post.Title,
                            PlaceJob = x.Employee.Station.Title,
                            WorkPhone = x.Employee.PhoneWork,
                            NormaShift = x.Employee.NormShift,
                            ShiftOpen = x.ShiftOpened,
                            ShiftClose = x.ShiftClosed,
                            StatusShift = x.StatusChange.Title
                        })
                        .ToList();
                    tsslCountSuccessShift.Text = "Кол-во выполненных смен: " + db.Shifts.Where(x => x.EmployeeId == Employee.Id && x.StatusChangeId == 1).Count();
                }
                else
                {
                    dgvShift.DataSource = db.Shifts
                        .Include(x => x.Employee.Person)
                        .Include(x => x.Employee.Station)
                        .Include(x => x.Employee.Post)
                        .Include(x => x.Employee)
                        .Include(x => x.StatusChange)
                        .Where(x => (x.Employee.StationId == station.Id || station.Id == -1)
                        && (x.StatusChangeId == status.Id || status.Id == -1)
                        && (x.Employee.PostId == post.Id || post.Id == -1)
                        && (x.ShiftOpened >= mntShift.SelectionStart
                        && x.ShiftClosed <= mntShift.SelectionEnd)
                        && (x.Employee.Person.LastName.Contains(txtSearchFIO.Text) || x.Employee.Person.FirstName.Contains(txtSearchFIO.Text)
                        || x.Employee.Person.Patronymic.Contains(txtSearchFIO.Text)))
                        .Select(x => new
                        {
                            EmployeeFIO = x.Employee.Person.LastName + " " +
                            x.Employee.Person.FirstName + " " +
                            x.Employee.Person.Patronymic,

                            Post = x.Employee.Post.Title,
                            PlaceJob = x.Employee.Station.Title,
                            WorkPhone = x.Employee.PhoneWork,
                            NormaShift = x.Employee.NormShift,
                            ShiftOpen = x.ShiftOpened,
                            ShiftClose = x.ShiftClosed,
                            StatusShift = x.StatusChange.Title
                        })
                        .ToList();
                    tsslCountSuccessShift.Text = "Кол-во выполненных смен: " + db.Shifts.Where(x => x.StatusChangeId == 1).Count();
                }
            }
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
            xlSheet.Name = "Смена";

            xlSheet.Cells[1, 1] = "Сотрудник";
            xlSheet.Cells[1, 2] = "Должность";
            xlSheet.Cells[1, 3] = "Место работы";
            xlSheet.Cells[1, 4] = "Рабочий телефон";
            xlSheet.Cells[1, 5] = "Норма смены";
            xlSheet.Cells[1, 6] = "Начало смены";
            xlSheet.Cells[1, 7] = "Конец смены";
            xlSheet.Cells[1, 8] = "Статус смены";

            for (int i = 0; i < dgvShift.Rows.Count; i++)
            {
                for (int j = 0; j < dgvShift.Columns.Count; j++)
                {
                    xlApp.Cells[i + 2, j + 1] = dgvShift.Rows[i].Cells[j].Value.ToString();
                }
            }
            xlApp.Columns.AutoFit();
            xlApp.Visible = true;
        }

        private void mntShift_DateChanged(object sender, DateRangeEventArgs e)
        {
            Filter();
        }
    }
}
