using BusinessManagementSystem.Entity.Base;
using BusinessManagementSystem.Entity.Dto;
using BusinessManagementSystem.Entity.IBase;
using BusinessManagementSystem.Entity.Models;
using BusinessManagementSystem.Interface;
using BusinessManagementSystem.WebApi.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class StaffController : ApiBaseController<IStaffService, Staff, DtoStaff>
    {
        private readonly IStaffService staffService;
        public StaffController(IStaffService staffService) : base(staffService)
        {
            this.staffService = staffService;
        }

        [HttpPost("ChangePassword")]
        public IResponse<DtoChangePassword> ChangePassword(DtoChangePassword password)
        {
            try
            {
                var userId = User.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti).Value;
                var user = staffService.GetById(Convert.ToInt32(userId));
                if (password.Password==user.Password)
                {
                    if (String.Compare(password.NewPassword,password.PasswordConfirm)==0)
                    {
                        user.Password = password.NewPassword;
                        staffService.UpdateAsync(user);
                        return (IResponse<DtoChangePassword>)user;
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

     

    }
}
