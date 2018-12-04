using Clean.Application.Notifications.Models;
using System.Threading.Tasks;

namespace Clean.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
