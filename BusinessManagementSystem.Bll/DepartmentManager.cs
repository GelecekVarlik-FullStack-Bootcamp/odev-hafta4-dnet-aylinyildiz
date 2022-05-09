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
    public class DepartmentManager : GenericManager<Department, DtoDepartment>, IDepartmentService
    {
        public readonly IDepartmentRepository departmentRepository;

        public DepartmentManager(IServiceProvider service) : base(service)
        {
            
        }
    }
}
