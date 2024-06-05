using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность пола
    /// </summary>
    public class Gender
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        public ICollection<Person> Persons { get; set; }
    }
}