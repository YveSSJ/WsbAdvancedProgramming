using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSB4.Domain
{
    public interface IMessagesRepository
    {
        List<MessageEntity> GetAll();
        bool Add(MessageEntity message);
        bool Delete(MessageEntity message);
    }
}
