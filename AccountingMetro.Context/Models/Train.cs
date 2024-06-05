using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность электропоезда
    /// </summary>
    public class Train
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Nomer { get; set; }
        public long VetkaId { get; set; }
        public Vetka Vetka { get; set; }
        public long StatusTrainId { get; set; }
        public StatusTrain StatusTrain { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}