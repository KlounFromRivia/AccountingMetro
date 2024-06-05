using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность статус поезда
    /// </summary>
    public class StatusTrain
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        public ICollection<Train> Trains { get; set; }
    }
}