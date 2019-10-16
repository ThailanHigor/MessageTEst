using MessageTest.Domain.Entities;
using System.Collections.Generic;

namespace MessageTest.Domain.Interfaces.Repositories
{
    public interface IMessageRepository : IRepositoryBase<Message>
    {
        IEnumerable<Message> FindByName(string name);

        Message FindTodayMessage();
    }
}
