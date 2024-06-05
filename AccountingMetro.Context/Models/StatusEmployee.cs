using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность статуса сотрудника
    /// </summary>
    public class StatusEmployee
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
