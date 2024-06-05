using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность человека
    /// </summary>
    public class Person
    {
        public long Id { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string Patronymic { get; set; } = string.Empty;
        [Required]
        public DateTime BirthDay { get; set; }
        public byte[] ImagePreview { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ResidentAddress { get; set; } = string.Empty;
        public long GenderId { get; set; }
        public Gender Gender { get; set; }
        public long StatusMariId { get; set; }
        public StatusMari StatusMari { get; set; }
        public long DocumentId { get; set; }
        public Document Document { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
