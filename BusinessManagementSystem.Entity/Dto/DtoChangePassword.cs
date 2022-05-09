using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Entity.Dto
{
    public class DtoChangePassword
    {
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string PasswordConfirm { get; set; }
    }
}
