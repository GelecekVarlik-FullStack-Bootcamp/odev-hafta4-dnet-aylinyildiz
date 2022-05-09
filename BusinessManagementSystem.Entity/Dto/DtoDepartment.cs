using BusinessManagementSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Entity.Dto
{
    public class DtoDepartment : DtoBase
    {
        public DtoDepartment()
        {
           
        }
        public int Id { get; set; }
        public string Name { get; set; }

      
    }
}
