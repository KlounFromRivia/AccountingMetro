using System.Collections.Generic;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность станции
    /// </summary>
    public class Station
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int VetkaId { get; set; }
        public Vetka Vetka { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}