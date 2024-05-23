using AccountingMetro.Context.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMetro.Context
{
    public class AccountingMetroDBContext:DbContext
    {

        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<StatusMari> StatusMaris { get; set; }
        public DbSet<StatusShift> StatusShifts { get; set; }
        public DbSet<StatusTrain> StatusTrains { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Station> Station { get; set; }
        public DbSet<Vetka> Vetkas { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<StaffDepart> StaffDeparts { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public AccountingMetroDBContext() : base("AccountingMetroDBConnectionString")
        {

        }
    }
}
