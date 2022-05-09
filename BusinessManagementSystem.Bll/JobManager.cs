using BusinessManagementSystem.Dal.Abstract;
using BusinessManagementSystem.Entity.Dto;
using BusinessManagementSystem.Entity.IBase;
using BusinessManagementSystem.Entity.Models;
using BusinessManagementSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Bll
{
    public class JobManager : GenericManager<Job, DtoJob>, IJobService
    {
        public JobManager(IServiceProvider service, IJobRepository jobRepository) : base(service)
        {
        
        }

     
    }
}
