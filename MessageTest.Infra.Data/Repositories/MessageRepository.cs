using System.Collections.Generic;
using System.Linq;
using MessageTest.Domain.Entities;
using MessageTest.Domain.Interfaces;


namespace MessageTest.Infra.Data.Repositories
{
    public class MessageRepository : RepositoryBase<Message>, IMessageRepository
    {
        public IEnumerable<Message> FindByName(string name)
        {
            return Db.Messages.Where(x => x.Texto.Contains(name));
        }
    }
}
