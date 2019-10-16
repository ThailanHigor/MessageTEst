using MessageTest.Application.Interfaces;
using MessageTest.Domain.Entities;
using MessageTest.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageTest.Application
{
    public class MessageAppService : AppServiceBase<Message>, IMessageAppService
    {
        private readonly IMessageService _messageService;

        public MessageAppService(IMessageService messageService)
            : base(messageService)
        {
            _messageService = messageService;
        }

        public IEnumerable<Message> FindTextByWord(string name)
        {
            return _messageService.FindTextByWord(name);
        }

        public Message FindTodayMessage()
        {
            return _messageService.FindTodayMessage();
        }
    }
}
