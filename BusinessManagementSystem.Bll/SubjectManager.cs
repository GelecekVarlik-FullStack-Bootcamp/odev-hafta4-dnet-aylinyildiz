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
    public class SubjectManager : GenericManager<Subject, DtoSubject>, ISubjectService
    {
        public readonly ISubjectService subjectService;

        public SubjectManager(IServiceProvider service) : base(service)
        {

        }
    }
}
