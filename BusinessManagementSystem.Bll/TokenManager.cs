using BusinessManagementSystem.Entity.Dto;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Bll
{
    public class TokenManager
    {
        IConfiguration configuration;

        public TokenManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string CreateAccessToken(DtoLoginStaff staff) 
        {
            //claim
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, staff.Email),
                new Claim(JwtRegisteredClaimNames.Jti, staff.Id.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Token");

            //claim rol
            var claimsRoleList = new List<Claim>
            {
                new Claim("role", "Admin"),
                new Claim("role2", "Yönetici"),
                new Claim("role3", "Personel")
            };

            //security key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Tokens:Key"]));

            //şifrelenmiş kimlik oluşturmak
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //token ayarları 
            var token = new JwtSecurityToken
            (
                issuer: configuration["Tokens:Issuer"], //token dağıtıcı url
                audience: configuration["Tokens:Issuer"], //erişilebilecek apiler // audiencede bir şey olmadığı için issuer yazdım
                expires : DateTime.Now.AddDays(1), // token süresini 1 saate ayarlar
                notBefore : DateTime.Now, //Token üretildikten ne kadar zaman sonra devreye girer
                signingCredentials : cred, // kimlik vermek 
                claims : claimsIdentity.Claims //claims'ler verildi.
            );

            //token oluşturma sınıfı ile örnek alıp üretmek
            var tokenHandler = new { token = new JwtSecurityTokenHandler().WriteToken(token) };
            return tokenHandler.token;

        }
    }
}
