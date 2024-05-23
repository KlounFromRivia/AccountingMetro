using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность документов
    /// </summary>
    public class Document
    {
        public int Id { get; set; }
        public string PassportSeries { get; set; }
        [Required]
        public string PassportNomer { get; set; }
        public string Issued { get; set; }
        public DateTime DateIssued { get; set; }
        [Required]
        public string INN { get; set; }
        [Required]
        public string InsCertific { get; set; }
        public string RegistratAddress { get; set; }
    }
}
