using BusinessManagementSystem.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessManagementSystem.Entity.Models
{
    public partial class Staff : EntityBase
    {
        public Staff()
        {
            JobJobCreators = new HashSet<Job>();
            JobJobTakers = new HashSet<Job>();
            MessageJobCreators = new HashSet<Message>();
            MessageJobTakers = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int RoleId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Job> JobJobCreators { get; set; }
        public virtual ICollection<Job> JobJobTakers { get; set; }
        public virtual ICollection<Message> MessageJobCreators { get; set; }
        public virtual ICollection<Message> MessageJobTakers { get; set; }
    }
}
