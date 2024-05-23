using System.Collections.Generic;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность ветки
    /// </summary>
    public class Vetka
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Station> Stations { get; set; }
    }
}