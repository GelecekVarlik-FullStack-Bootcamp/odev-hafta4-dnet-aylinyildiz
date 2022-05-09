using BusinessManagementSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Entity.Dto
{
    public class DtoPriority : DtoBase
    {
        public DtoPriority()
        {
            
        }

        public int Id { get; set; }
        public string Title { get; set; }

    }
}
