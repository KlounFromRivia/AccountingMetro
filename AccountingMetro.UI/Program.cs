using AccountingMetro.Context;
using AccountingMetro.Context.Models;
using AccountingMetro.UI.Forms;
using AccountingMetro.UI.General;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingMetro.UI
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (var db = new AccountingMetroDBContext())
            //{
            //    var encryption = new Encryption();

            //    var documents = db.Documents.ToList();
            //    foreach (var document in documents)
            //    {
            //        var shSeries = encryption.EncryptPlainTextToCipherText(document.PassportSeries);
            //        var shNomer = encryption.EncryptPlainTextToCipherText(document.PassportNomer);
            //        var shInn = encryption.EncryptPlainTextToCipherText(document.INN);
            //        var shInsCertific = encryption.EncryptPlainTextToCipherText(document.InsCertific);
            //        var shAdres = encryption.EncryptPlainTextToCipherText(document.RegistratAddress);
            //        var shIssued = encryption.EncryptPlainTextToCipherText(document.Issued);

            //        document.PassportSeries = shSeries;
            //        document.PassportNomer = shNomer;
            //        document.INN = shInn;
            //        document.InsCertific = shInsCertific;
            //        document.RegistratAddress = shAdres;
            //        document.Issued = shIssued;
            //    }
            //    db.SaveChanges();
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }
    }
}
