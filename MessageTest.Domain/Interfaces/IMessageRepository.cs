using MessageTest.Domain.Entities;
using System.Collections.Generic;

namespace MessageTest.Domain.Interfaces
{
    public interface IMessageRepository : IRepositoryBase<Message>
    {
        IEnumerable<Message> FindByName(string name);
    }
}
