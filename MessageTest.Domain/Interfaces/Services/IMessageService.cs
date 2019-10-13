using MessageTest.Domain.Entities;
using System.Collections.Generic;

namespace MessageTest.Domain.Interfaces.Services
{
    public interface IMessageService : IServiceBase<Message>
    {
        IEnumerable<Message> FindTextByWord(string name);
    }
}
