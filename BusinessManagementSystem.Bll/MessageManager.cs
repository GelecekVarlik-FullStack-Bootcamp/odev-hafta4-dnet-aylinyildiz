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
    public class MessageManager : GenericManager<Message, DtoMessage>, IMessageService
    {
        public readonly IMessageRepository messageRepository;

        public MessageManager(IServiceProvider service) : base(service)
        {
           
        }
    }
}
