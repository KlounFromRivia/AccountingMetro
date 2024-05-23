using System.Collections;
using System.Collections.Generic;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность семейное положение
    /// </summary>
    public class StatusMari
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Person> Persons { get; set; }
    }
}