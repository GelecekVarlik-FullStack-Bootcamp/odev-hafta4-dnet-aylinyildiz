using BusinessManagementSystem.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessManagementSystem.Entity.Models
{
    public partial class Department : EntityBase
    {
        public Department()
        {
            Jobs = new HashSet<Job>();
            Subjects = new HashSet<Subject>();
            staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Staff> staff { get; set; }
    }
}
