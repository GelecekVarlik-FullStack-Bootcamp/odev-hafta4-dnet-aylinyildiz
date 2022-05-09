using BusinessManagementSystem.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessManagementSystem.Entity.Models
{
    public partial class Subject : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
