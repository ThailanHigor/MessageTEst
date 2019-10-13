using System;

namespace MessageTest.Domain.Entities
{
    public class Message
    {
        public int MessageId { get; set; }

        public string Texto { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public bool Lido { get; set; }
    }

}
