﻿using System.Collections.Generic;

namespace AccountingMetro.Context.Models
{
    /// <summary>
    /// Сущность должности
    /// </summary>
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DivisionId { get; set; }
        public Division Division { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}