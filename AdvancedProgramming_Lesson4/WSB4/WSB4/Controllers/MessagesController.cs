using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WSB4.Domain;

namespace WSB4.Controllers
{
    [ApiController]
    [Route("messages")]
    public class MessagesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IMessagesRepository _messagesRepository;

        public MessagesController(IConfiguration configuration, IMessagesRepository messagesRepository)
        {
            _configuration = configuration;
            _messagesRepository = messagesRepository;

        }
        [HttpGet]
        [Route("getMessage")]
        public IActionResult GetMessage()
        {
            var messageDto = new MessageDTO { Author = "Secret", Content = "I don't know" };
            return Ok(messageDto);
        }

        [HttpPost]
        [Route("sendMessage")]
        public IActionResult SendMessage([FromBody] MessageDTO messageDto)
        {
            var messageEntity = new MessageEntity { Content = messageDto.Content };
            var result = _messagesRepository.Add(messageEntity);
            if (result) { return Ok(messageDto); }
            return NotFound();
        }
    }
}
