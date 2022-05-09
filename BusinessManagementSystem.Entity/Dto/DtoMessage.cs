using BusinessManagementSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Entity.Dto
{
    public class DtoMessage : DtoBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int JobCreatorId { get; set; }
        public int JobTakerId { get; set; }
        public int JobId { get; set; }

    }
}
