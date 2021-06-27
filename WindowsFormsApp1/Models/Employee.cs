using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace WindowsFormsApp1.Models
{
    public class Employee
    // Definition of employee model. 
    {
        public Employee()
        {
            Children = new List<Child>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public DateTime BirthTime { get; set; }
        public string Position { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DefaultValue(0)]
        public int ChildrenCount { get; set; }

        public virtual ICollection<Child> Children { get; set; }
        
    }
}
