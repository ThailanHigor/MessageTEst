using MessageTest.Domain.Entities;
using System.Collections.Generic;

namespace MessageTest.Application.Interfaces
{
    public interface IMessageAppService : IAppServiceBase<Message>
    {
        IEnumerable<Message> FindTextByWord(string name);

        Message FindTodayMessage();
    }
}
