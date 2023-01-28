using HealthHub.Shared;

namespace HealthHub.Server.Services.Interfaces
{
    public interface IMailService
    {
        Task<bool> SendAsync(MailData mailData, CancellationToken ct = default);
    }
}
