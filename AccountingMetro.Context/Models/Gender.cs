using System.Collections.Generic;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность пола
    /// </summary>
    public class Gender
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Person> Persons { get; set; }
    }
}