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
        public long Id { get; set; }
        [Required]
        public string PassportSeries { get; set; }
        [Required]
        public string PassportNomer { get; set; }
        [Required]
        public string Issued { get; set; }
        [Required]
        public DateTime DateIssued { get; set; }
        [Required]
        public string INN { get; set; }
        [Required]
        public string InsCertific { get; set; }
        [Required]
        public string RegistratAddress { get; set; }
    }
}
