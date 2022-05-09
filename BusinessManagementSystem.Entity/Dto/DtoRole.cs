using BusinessManagementSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Entity.Dto
{
    public class DtoRole : DtoBase
    {
        public DtoRole()
        {
           
        }

        public int Id { get; set; }
        public string Name { get; set; }

    
    }
}
