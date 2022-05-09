using BusinessManagementSystem.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessManagementSystem.Entity.Models
{
    public partial class Job : EntityBase
    {
        public Job()
        {
            Messages = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Status { get; set; }
        public int DepartmentId { get; set; }
        public int JobCreatorId { get; set; }
        public int JobTakerId { get; set; }
        public int PrioritiesId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Staff JobCreator { get; set; }
        public virtual Staff JobTaker { get; set; }
        public virtual Priority Priorities { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
