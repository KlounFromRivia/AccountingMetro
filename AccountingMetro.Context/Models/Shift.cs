using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность смены
    /// </summary>
    public class Shift
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Required]
        public DateTime ShiftOpened { get; set; } = DateTime.Now;
        public DateTime? ShiftClosed { get; set; }
        public long StatusChangeId { get; set; }
        public StatusShift StatusChange { get; set; }
        [Required]
        public string PlaceWork { get; set; }
    }
}
