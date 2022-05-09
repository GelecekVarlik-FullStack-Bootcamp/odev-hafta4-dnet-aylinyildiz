using BusinessManagementSystem.Entity.Dto;
using BusinessManagementSystem.Entity.IBase;
using BusinessManagementSystem.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Interface
{
    public interface IStaffService : IGenericService<Staff, DtoStaff>
    {
        IResponse<DtoStaffToken> Login(DtoLogin login);
        IResponse<DtoRegister> Register(DtoRegister register);
        DtoStaff GetById(int id);
    }
}
