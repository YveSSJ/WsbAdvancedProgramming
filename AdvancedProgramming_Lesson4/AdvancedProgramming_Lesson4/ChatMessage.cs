using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson4
{
    public class ChatMessage
    {
        public long id { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
        public ChatMessage(string User, string Message)
        {
            this.User = User;
            this.Message = Message;
        }
        public ChatMessage()
        {

        }
    }
}
