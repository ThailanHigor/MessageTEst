using System.Collections.Generic;
using MessageTest.Domain.Entities;
using MessageTest.Domain.Interfaces.Repositories;
using MessageTest.Domain.Interfaces.Services;

namespace MessageTest.Domain.Services
{
   public class MessageService : ServiceBase<Message>, IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
            :base(messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public IEnumerable<Message> FindTextByWord(string name)
        {
            return _messageRepository.FindByName(name);
        }
    }
}
