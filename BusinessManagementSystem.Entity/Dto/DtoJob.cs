using BusinessManagementSystem.Entity.Base;
using BusinessManagementSystem.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Entity.Dto
{
    public class DtoJob : DtoBase
    {
        public DtoJob()
        {
           
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Status { get; set; }
        public int DepartmentId { get; set; }
        public int JobCreatorId { get; set; }
        public int? JobTakerId { get; set; }
        public int PrioritiesId { get; set; }

    }
}
