using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность отдела кадров
    /// </summary>
    public class StaffDepart
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Required]
        [MaxLength(255)]
        [Index(IsUnique = true)]
        public string Login { get; set; }
        [Required]
        [MaxLength(255)]
        public string Password { get; set; }
        [Required]
        [MaxLength(255)]
        public string Salt { get; set; }
    }
}
