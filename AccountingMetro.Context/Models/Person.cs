using System;
using System.Collections.Generic;
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
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public byte[] ImagePreview { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ResidentAddress { get; set; } = string.Empty;
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public int StatusMariId { get; set; }
        public StatusMari StatusMari { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
