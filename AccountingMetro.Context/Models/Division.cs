using System.Collections.Generic;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность подразделения
    /// </summary>
    public class Division
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}