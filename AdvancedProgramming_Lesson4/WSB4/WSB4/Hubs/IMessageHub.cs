using System.Threading.Tasks;

namespace WSB4.Hubs
{
    public interface IMessageHub
    {
        Task NewMessage();
    }
}
