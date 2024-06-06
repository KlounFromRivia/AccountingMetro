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
                    .FirstOrDefault(x => x.Login == txtLogin.Text);

                if (staffDepart == null)
                {
                    MessageBox.Show("Введенные данные неверны!",
                        "Пользователь не существует!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var hashPassword = new Authorizator()
                    .GenerateSHA256Hash(txtPassword.Text, staffDepart.Salt); 

                if (hashPassword != staffDepart.Password)
                {
                    MessageBox.Show("Введенные данные неверны!",
                    "Пользователь не существует!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                    return;
                }

                CurrentEmployee.StaffDepart = staffDepart;

                    MessageBox.Show("Добро пожаловать, "+CurrentEmployee.StaffDepart.Employee.Person.LastName+"!",
                        "Авторизация успешна!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    var mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
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
