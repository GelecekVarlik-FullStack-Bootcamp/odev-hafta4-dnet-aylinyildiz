using BusinessManagementSystem.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Dal.Abstract
{
    public interface IStaffRepository
    {
        Staff Login(Staff login);
        Staff Register(Staff register);
        Staff GetById(int id);
    }
}
