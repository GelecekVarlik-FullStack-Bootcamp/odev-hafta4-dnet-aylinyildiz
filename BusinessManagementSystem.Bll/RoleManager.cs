using BusinessManagementSystem.Dal.Abstract;
using BusinessManagementSystem.Entity.Dto;
using BusinessManagementSystem.Entity.Models;
using BusinessManagementSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Bll
{
    public class RoleManager : GenericManager<Role, DtoRole>, IRoleService
    {
        public readonly IRoleRepository roleRepository;

        public RoleManager(IServiceProvider service) : base(service)
        {

        }
    }
}
