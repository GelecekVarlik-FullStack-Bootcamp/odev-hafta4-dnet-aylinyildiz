using BusinessManagementSystem.Dal.Abstract;
using BusinessManagementSystem.Entity.Base;
using BusinessManagementSystem.Entity.Dto;
using BusinessManagementSystem.Entity.IBase;
using BusinessManagementSystem.Entity.Models;
using BusinessManagementSystem.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Mail;
using System.Net;

namespace BusinessManagementSystem.Bll
{
    public class StaffManager : GenericManager<Staff, DtoStaff>, IStaffService
    {
        public readonly IStaffRepository staffRepository;
        private IConfiguration configuration;

        public StaffManager(IServiceProvider service, IConfiguration configuration) : base(service)
        {
            staffRepository = service.GetService<IStaffRepository>();
            this.configuration = configuration;

        }

       
        public DtoStaff GetById(int id)
        {
            var staff= staffRepository.GetById(id);
            return ObjectMapper.mapper.Map<DtoStaff>(staff);
        }

        public IResponse<DtoStaffToken> Login(DtoLogin login)
        {
            var staff = staffRepository.Login(ObjectMapper.mapper.Map<Staff>(login));

            
            if(staff != null)
            {
                var dtoStaff = ObjectMapper.mapper.Map<DtoLoginStaff>(staff);
                var token = new TokenManager(configuration).CreateAccessToken(dtoStaff);

                var userToken = new DtoStaffToken()
                {
                    DtoLoginStaff = dtoStaff,
                    AccessToken = token
                };

                return new Response<DtoStaffToken>
                {
                    Message = "Token üretildi",
                    StatusCode = StatusCodes.Status200OK,
                    Data = userToken
                };
            }
            else
            {
                return new Response<DtoStaffToken>
                {
                    Message = "Email veya parolanız yanlış!",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
        }

        public IResponse<DtoRegister> Register(DtoRegister register)
        {

            Random rndpassword = new Random();
            register.password = Convert.ToString(rndpassword.Next(100000, 1000000)); //6haneli random parola üretildi.
            var registerStaff = staffRepository.Register(ObjectMapper.mapper.Map<Staff>(register));

            if(registerStaff != null)
            {
                return new Response<DtoRegister>
                {
                    Message = "Personel eklendi",
                    StatusCode = StatusCodes.Status200OK,
                    Data = register
                };
            }
            else
            {
                return new Response<DtoRegister>
                {
                    Message = "Eklenmedi",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
        }


        //Butona tıklandığı anda Mail aksiyonuna gelecek.
        //public IResponse Mail(DtoStaff model)
        //{
        //    string mailadress = model.Email;
        //    string name = model.Name;
        //    string surname = model.Surname;
        //    string content = model.Password;
        //    string topic = "Şifreniz aşağıdaki gibidir";
        //    try
        //    {
               
        //        MailMessage mail = new MailMessage();
              
        //        mail.IsBodyHtml = true;
        //        //Bu kısım mail'in kime gideceğidir.Kendi adresimi yazdım.
        //        mail.To.Add("ay@icloud.com");
        //        //Burası ise kimin göndereceğidir.Kim gönderecek?
        //        mail.From = new MailAddress("ay@gmail.com");
        //        //Gelen mailin konusu
        //        mail.Subject = topic;
        //        //Gelen mailin içeriği
        //        mail.Body = "<b>" + name.ToUpper() + " " + surname.ToUpper() + "</b>" + " kişisi tarafından;</br>" + "E-mail adresi:" + "<b>" + mailadress + "</b>" + " olan " + "<b>" + topic.ToUpper() + "</b>" + " konusu hakkında mail attı.Mail içeriği;</br>" + "<b>" + content + "</b>";
        //        mail.IsBodyHtml = true;
        //        //Bu kısımda smtp classında instance oluşturuyoruz.
        //        SmtpClient smtp = new SmtpClient();
        //        //Burada maili gönderen kişinin mail adresi ve şifresi alınıyor.
        //        smtp.Credentials = new NetworkCredential("ay@gmail.com", "abcx");
        //        //Hangi portu kullanacağımızı yazıyoruz.
        //        smtp.Port = 18595;
        //        //Hangi mail adresini kullanacağızı seçiyoruz.
        //        smtp.Host = "smtp.gmail.com";
        //        //Ssl güvenlik protokolünü aktifleştiriyoruz.
        //        smtp.EnableSsl = true;
        //        //Maili gönderiyoruz.
        //        smtp.Send(mail);
        //        return Json(true, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
