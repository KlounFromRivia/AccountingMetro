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
                var user = db.StaffDeparts.Include(x => x.Employee.Person).FirstOrDefault(x => x.Login == txtLogin.Text
                && x.Password == txtPassword.Text);

                if (user == null)
                {
                    MessageBox.Show("Введенные данные неверны!",
                        "Пользователь не существует!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Добро пожаловать, "+user.Employee.Person.LastName+ " "
                        + user.Employee.Person.FirstName + " "
                        + user.Employee.Person.Patronymic + "!",
                        "Авторизация успешна!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    CurrectEmployee.User = user;
                    var mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                    txtLogin.Clear();
                    txtPassword.Clear();
                    this.Show();
                }

                //var hashPassword = new Authorization()
                //    .GenerateSHA256Hash(txtPassword.Text, user.Salt);

                //if (hashPassword != user.Password)
                //{
                //    MessageBox.Show("Введенные данные неверны!",
                //    "Пользователь не существует!",
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Error);
                //    return;
                //}
                //db.SaveChanges();
            }
            //if (isAuthForm)
            //{

            //    return;
            //}
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            btnEnter.Enabled = !string.IsNullOrEmpty(txtLogin.Text)
                && !string.IsNullOrEmpty(txtPassword.Text);
        }
    }
}
