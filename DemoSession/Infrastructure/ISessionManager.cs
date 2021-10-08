using DemoSession.Models;

namespace DemoSession.Infrastructure
{
    public interface ISessionManager
    {
        User CurrentUser { get; set; }
    }
}