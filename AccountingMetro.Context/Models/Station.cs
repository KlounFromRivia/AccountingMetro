using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность станции
    /// </summary>
    public class Station
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        public long VetkaId { get; set; }
        public Vetka Vetka { get; set; }
        public long StatusStationId { get; set; }
        public StatusStation StatusStation { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}