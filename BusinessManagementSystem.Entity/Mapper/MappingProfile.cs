using AutoMapper;
using BusinessManagementSystem.Entity.Dto;
using BusinessManagementSystem.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DtoDepartment>().ReverseMap();
            CreateMap<Job, DtoJob>().ReverseMap();
            CreateMap<Message, DtoMessage>().ReverseMap();
            CreateMap<Priority, DtoPriority>().ReverseMap();
            CreateMap<Role, DtoRole>().ReverseMap();
            CreateMap<Staff, DtoStaff>().ReverseMap();
            CreateMap<DtoLogin, Staff>().ReverseMap();
            CreateMap<Staff, DtoLoginStaff>(); // Staff DtoLoginStaffa dönüşür ama DtoLoginStaff staffa dönüşmez.Reverse kaldırıldı
            CreateMap<DtoRegister, Staff>().ReverseMap();
            CreateMap<Subject, DtoSubject>().ReverseMap();
        }
    }
}
