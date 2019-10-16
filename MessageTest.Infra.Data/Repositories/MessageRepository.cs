using System;
using System.Collections.Generic;
using System.Linq;
using MessageTest.Domain.Entities;

using MessageTest.Domain.Interfaces.Repositories;

namespace MessageTest.Infra.Data.Repositories
{
    public class MessageRepository : RepositoryBase<Message>, IMessageRepository
    {
        public IEnumerable<Message> FindByName(string name)
        {
            return Db.Messages.Where(x => x.Texto.Contains(name));
        }

        public Message FindTodayMessage()
        {
            var msgDay = Db.Messages.Where(x => x.DataExibicao.Day == DateTime.Now.Day
                                           && x.DataExibicao.Month == DateTime.Now.Month
                                           && x.DataExibicao.Year == DateTime.Now.Year
                                           && x.Ativo).FirstOrDefault();
            return msgDay;
        }

    }
}
