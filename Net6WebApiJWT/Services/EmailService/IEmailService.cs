using Net6WebApiJWT.Models;

namespace Net6WebApiJWT.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
