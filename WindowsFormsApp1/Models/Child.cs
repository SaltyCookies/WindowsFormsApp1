using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Models
{
    public class Child
    // Definition of child model. 
    {
        public Child()
        {
            Employees = new List<Employee>();
        }
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public DateTime BirthTime { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
