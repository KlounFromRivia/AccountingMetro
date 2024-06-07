using AccountingMetro.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMetro.UI.Validate
{
    /// <summary>
    /// Авторизованный сотрудник
    /// </summary>
    public static class CurrentEmployee
    {
        public static StaffDepart StaffDepart { get; set; }
    }
}
