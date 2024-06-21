using AccountingMetro.Context;
using AccountingMetro.Context.Models;
using AccountingMetro.UI.Forms;
using AccountingMetro.UI.General;
using AccountingMetro.UI.Validate;
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

namespace AccountingMetro.UI
{
    /// <summary>
    /// Форма авторизации
    /// </summary>
    public partial class AuthForm : Form
    {
        private bool isAuthForm = true;
        public AuthForm()
        {
            InitializeComponent();
        }
        public AuthForm(bool isAuthForm)
        {
            InitializeComponent();
            this.isAuthForm = isAuthForm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            using (var db = new AccountingMetroDBContext())
            {
                var staffDepart = db.StaffDeparts
                    .Include(x => x.Employee.Person)
                    .Include(x => x.Employee.Station)
                    .Include(x => x.Employee.StatusEmployee)
                    .FirstOrDefault(x => x.Login == txtLogin.Text);

                if (staffDepart == null)
                {
                    MessageBox.Show("Введите логин и пароль!", "Введите данные!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLogin.Text = txtPassword.Text = "";
                    return;
                }

                var hashPassword = new Authorizator()
                    .GenerateSHA256Hash(txtPassword.Text, staffDepart.Salt);

                if (hashPassword != staffDepart.Password)
                {
                    MessageBox.Show("Введенные данные неверны!", "Пользователь не существует!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Text = txtPassword.Text = "";
                    return;
                }

                CurrentEmployee.StaffDepart = staffDepart;

                if (CurrentEmployee.StaffDepart.Employee.StatusEmployeeId == 2)
                {
                    MessageBox.Show("Данный сотрудник уволен!", "Доступ запрещен!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Text = txtPassword.Text = "";
                    return;
                }

                var username = CurrentEmployee.StaffDepart.Id != 1
                    ? "Добро пожаловать, " + CurrentEmployee.StaffDepart.Employee.Person.LastName + " " +
                        CurrentEmployee.StaffDepart.Employee.Person.FirstName + " " +
                        CurrentEmployee.StaffDepart.Employee.Person.Patronymic + "!"
                    : "Добро пожаловать, " + CurrentEmployee.StaffDepart.Employee.Person.LastName + "!";

                MessageBox.Show(username, "Авторизация успешна!", 
                    MessageBoxButtons.OK,MessageBoxIcon.Information);

                var mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                CurrentEmployee.StaffDepart = null;
                txtLogin.Clear();
                txtPassword.Clear();
                this.Show();
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            btnEnter.Enabled = !string.IsNullOrEmpty(txtLogin.Text)
                && !string.IsNullOrEmpty(txtPassword.Text);
        }
    }
}
