using System.Collections.Generic;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность электропоезда
    /// </summary>
    public class Train
    {
        public int Id { get; set; }
        public string Nomer { get; set; }
        public int VetkaId { get; set; }
        public Vetka Vetka { get; set; }
        public int StatusTrainId { get; set; }
        public StatusTrain StatusTrain { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}