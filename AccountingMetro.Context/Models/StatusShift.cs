﻿using System.Collections.Generic;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность состояние смены
    /// </summary>
    public class StatusShift
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Shift> Shifts { get; set; }
    }
}