using BusinessManagementSystem.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessManagementSystem.Entity.Models
{
    public partial class Message : EntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int JobCreatorId { get; set; }
        public int JobTakerId { get; set; }
        public int JobId { get; set; }

        public virtual Job Job { get; set; }
        public virtual Staff JobCreator { get; set; }
        public virtual Staff JobTaker { get; set; }
    }
}
