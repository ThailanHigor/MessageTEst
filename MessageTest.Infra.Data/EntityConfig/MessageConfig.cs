using MessageTest.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MessageTest.Infra.Data.EntityConfig
{
    public class MessageConfig : EntityTypeConfiguration<Message>
    {
        public MessageConfig()
        {
            HasKey(m => m.MessageId);

            Property(m => m.Texto)
               .IsRequired()
               .HasMaxLength(200);

        }
    }
}
