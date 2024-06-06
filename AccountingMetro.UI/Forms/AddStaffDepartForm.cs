using AccountingMetro.Context;
using AccountingMetro.Context.Models;
using AccountingMetro.UI.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace AccountingMetro.UI.Forms
{
    public partial class AddStaffDepartForm : Form
    {
        private bool isStaffDepartForm = true;
        public StaffDepart StaffDepart { get; set; }
        public AddStaffDepartForm()
        {
            InitializeComponent();
        }
        public AddStaffDepartForm(StaffDepart staffDepart)
        {
            InitializeComponent();
            this.StaffDepart = staffDepart;
        }

        #region Инизиализация формы
        public void Initialize(StaffDepart staffDepart)
        {
            using (var db = new AccountingMetroDBContext())
            {
                lblLogin.Text = "Новый пароль";
                txtLogin.PasswordChar = '*';
                lblPassword.Text = "Повторите пароль";
                cmbStaff.Visible = false;
                lblStaff.Height = 28;
                lblStaff.Text = staffDepart.Employee.Person.LastName + " " 
                    + staffDepart.Employee.Person.FirstName + " "
                    + staffDepart.Employee.Person.Patronymic;
                this.Height -= 40;
            }
        }
        #endregion
        public void FillComboBoxes()
        {
            using (var db = new AccountingMetroDBContext())
            {
                cmbStaff.ValueMember = "Id";
                cmbStaff.DisplayMember = "FullName";
                cmbStaff.DataSource = (db.Employees.Include(x => x.Person).Where(x => x.PostId == 9
                                                                && !db.StaffDeparts.Select(y => y.EmployeeId)
                                                                                   .ToList()
                                                                                   .Contains(x.Id))
                                                    .Select(x => new
                                                    {
                                                        Id = x.Id,
                                                        FullName = x.Person.LastName + " " + x.Person.FirstName + " " + x.Person.Patronymic,
                                                    })
                                                    .ToArray());
            }
        }

        private void AddStaffDepartForm_Load(object sender, EventArgs e)
        {
            if (StaffDepart != null)
            {
                Initialize(StaffDepart);
                return;
            }
            StaffDepart = new StaffDepart()
            {
                Id = -1,
            };
            isStaffDepartForm = false;
            FillComboBoxes();
            cmbStaff.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isStaffDepartForm)
            {
                if (txtLogin.Text != txtPassword.Text)
                {
                    var tooltip = new ToolTip();

                    tooltip.SetToolTip(txtPassword, "");
                    tooltip.Show("Пароли должны совпадать!", txtPassword, 2000);

                    return;
                }

                var regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$");

                if (!regex.IsMatch(txtLogin.Text))
                {
                    var tooltip = new ToolTip();

                    tooltip.SetToolTip(txtLogin, "");
                    tooltip.ToolTipTitle = "Пароль должен содержать:";
                    tooltip.Show("- строчные и прописные латинские буквы\n" +
                                 "- не менее одной цифры\n" +
                                 "- не менее одного специального символа\n" +
                                 "- от 8 до 15 символов"
                                 , txtLogin, 2000);

                    return;
                }

                using (var db = new AccountingMetroDBContext())
                {
                    var user = db.StaffDeparts.FirstOrDefault(x => x.Id == StaffDepart.Id);

                    var authorizator = new Authorizator();
                    var salt = authorizator.CreateSalt(16);
                    var hashPassword = authorizator.GenerateSHA256Hash(txtPassword.Text, salt);

                    user.Password = hashPassword;
                    user.Salt = salt;

                    db.SaveChanges();
                }
                this.Close();
                return;
            }
            

            using (var db = new AccountingMetroDBContext())
            {
                int.TryParse(cmbStaff.SelectedValue.ToString(), out var id);
                var employee = db.Employees.FirstOrDefault(x => x.Id == id);
                var staffDepart = new StaffDepart()
                {
                    Login = txtLogin.Text,
                    EmployeeId = employee.Id,
                };

                var authorizator = new Authorizator();
                var salt = authorizator.CreateSalt(16);
                var hashPassword = authorizator.GenerateSHA256Hash(txtPassword.Text, salt);

                staffDepart.Password = hashPassword;
                staffDepart.Salt = salt;
                db.StaffDeparts.Add(staffDepart);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
