using System.Collections.Generic;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность статуса станции
    /// </summary>
    public class StatusStation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Station> Stations { get; set; }
    }
}