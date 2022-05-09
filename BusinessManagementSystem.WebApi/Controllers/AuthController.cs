using AutoMapper.Internal.Mappers;
using BusinessManagementSystem.Entity.Base;
using BusinessManagementSystem.Entity.Dto;
using BusinessManagementSystem.Entity.IBase;
using BusinessManagementSystem.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IStaffService staffService;
        public AuthController(IStaffService staffService) 
        {
            this.staffService = staffService;
        }

        [HttpPost("Login")]
        public IResponse<DtoStaffToken> Login(DtoLogin login)
        {
           
            try
            {
                return staffService.Login(login);
            }
            catch (Exception ex)
            {
                return new Response<DtoStaffToken>
                {
                    Message = "Error:" + ex.Message,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
            
        }

        [HttpPost("Register")]
        public IResponse<DtoRegister> Register(DtoRegister register)
        {
            try
            {
                return staffService.Register(register);
            }
            catch (Exception ex)
            {
                return new Response<DtoRegister>
                {
                    Message = "Error:" + ex.Message,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }
    }
}
