using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность сотрудинка
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime ContractDay { get; set; }
        public DateTime EmploymentDay { get; set; }
        public string PhoneWork { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int StationId { get; set; }
        public Station Station { get; set; }
        public int? TrainId { get; set; }
        public Train Train { get; set; }
        public int NormShift { get; set; }
        public int Salary { get; set; }
        public int Allowance { get; set; }
        public int Vacation { get; set; }
    }
}
