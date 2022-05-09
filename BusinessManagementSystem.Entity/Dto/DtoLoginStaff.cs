using BusinessManagementSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Entity.Dto
{
    public class DtoLoginStaff : DtoBase
    {
        //Token'a gömmeden ek bilgi olarak gönderiyoruz.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
  
    }
}
