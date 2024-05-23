using System.Collections.Generic;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность статус поезда
    /// </summary>
    public class StatusTrain
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Train> Trains { get; set; }
    }
}