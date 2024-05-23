using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMetro.Context.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTimeOffset ShiftOpened { get; set; }
        public DateTimeOffset? ShiftClosed { get; set; }
        public int StatusChangeId { get; set; }
        public StatusShift StatusChange { get; set; }
    }
}
