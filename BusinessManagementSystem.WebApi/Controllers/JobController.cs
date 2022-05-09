using BusinessManagementSystem.Entity.Base;
using BusinessManagementSystem.Entity.Dto;
using BusinessManagementSystem.Entity.IBase;
using BusinessManagementSystem.Entity.Models;
using BusinessManagementSystem.Interface;
using BusinessManagementSystem.WebApi.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BusinessManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ApiBaseController<IJobService, Job, DtoJob>
    {
        private readonly IJobService jobService;

        public JobController(IJobService jobService) : base(jobService)
        {
            this.jobService = jobService;
        }

        [HttpPost("AddJob")]
        public IResponse<DtoJob> AddJob(DtoJob job)
        {
            try
            {
                //İşi ekleyen kişinin id sini aldık.
                var userId = User.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti).Value;
                job.JobCreatorId =Convert.ToInt32( userId);
                return jobService.Add(job, true);
            }
            catch (Exception ex)
            {
                return new Response<DtoJob>
                {
                    Message = "Error:" + ex.Message,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }


        [HttpGet("ListJobs")]
        public IResponse<List<DtoJob>> ListJob(int departmentId)
        {
            //aylin kullanıcısı olarak girdim burada user.identity üzerinden deapartmanıd me erişeceğim o id yide
            try
            {
                var list =  jobService.GetAll(x=>x.DepartmentId == departmentId);
                return list;
            }
            catch (Exception ex)
            {
                return new Response<List<DtoJob>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        [HttpGet("JobDetail")]
        public IResponse<DtoJob> DetailJob(int jobId)
        {
            try
            {
                return jobService.Find(jobId);
                
            }
            catch (Exception ex)
            {
                return new Response<DtoJob>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

    }
}
