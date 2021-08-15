using System.Threading.Tasks;
using AdvancedProgramming_Lesson4.Data;
using Microsoft.AspNetCore.SignalR;

namespace AdvancedProgramming_Lesson4.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;


        public ChatHub(ApplicationDbContext context)
        {
            ChatMessage message = new ChatMessage();
            _context = context;
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            var chatMessage = new ChatMessage();
            if (Context.User.Identity.IsAuthenticated)
            {
                chatMessage.User = Context.User.Identity.Name;
            }
            else
            {
                chatMessage.User = user;
            }
            chatMessage.Message = message;

            _context.Messages.Add(chatMessage);
            await _context.SaveChangesAsync();
        }

    }
}
