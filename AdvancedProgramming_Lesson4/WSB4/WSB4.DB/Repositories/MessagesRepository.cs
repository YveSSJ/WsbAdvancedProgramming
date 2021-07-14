using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WSB4.Domain;

namespace WSB4.DB
{
    public class MessagesRepository : IMessagesRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private DbSet<MessageEntity> Messages { get; set; }

        public MessagesRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Messages = dbContext.Messages;
        }

        public IEnumerable<MessageEntity> GetAll()
        {
            return Messages;
        }
        public bool Add(MessageEntity message)
        {
            Messages.Add(message);
            return _dbContext.SaveChanges() > 0;
        }
        public bool Delete(MessageEntity message)
        {
            Messages.Remove(message);
            return _dbContext.SaveChanges() > 0;

        }
    }
}
