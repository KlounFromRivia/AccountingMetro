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
        public long Id { get; set; }
        public long PersonId { get; set; }
        public Person Person { get; set; }
        [Required]
        public DateTime ContractDay { get; set; }
        [Required]
        public DateTime EmploymentDay { get; set; }
        [Required]
        public string PhoneWork { get; set; }
        public long PostId { get; set; }
        public Post Post { get; set; }
        public long StatusEmployeeId { get; set; } = 1;
        public StatusEmployee StatusEmployee { get; set; }
        public long StationId { get; set; }
        public Station Station { get; set; }
        public long? TrainId { get; set; }
        public Train Train { get; set; }
        [Required]
        public int NormShift { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public int Allowance { get; set; }
        [Required]
        public int Vacation { get; set; }
    }
}
