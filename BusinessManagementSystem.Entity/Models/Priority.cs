using BusinessManagementSystem.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessManagementSystem.Entity.Models
{
    public partial class Priority : EntityBase
    {
        public Priority()
        {
            Jobs = new HashSet<Job>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
