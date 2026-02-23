namespace StudyRoom.Services
{
    public interface IEmailService
    {
        Task SendRegistrationConfirmationEmailAsync(string toEmail, string confirmationLink);

        Task SendAccountCreatedEmailAsync(string toEmail, string loginLink);

        Task SendResendConfirmationEmailAsync(string toEmail, string confirmationLinl);
    }
}