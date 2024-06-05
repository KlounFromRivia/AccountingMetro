using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность статуса станции
    /// </summary>
    public class StatusStation
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        public ICollection<Station> Stations { get; set; }
    }
}