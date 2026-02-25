namespace StudyRoom.Services
{
    public interface IEmailService
    {
        Task SendRegistrationConfirmationEmailAsync(string toEmail, string FirstName, string confirmationLink);

        Task SendAccountCreatedEmailAsync(string toEmail, string FirstName, string loginLink);

        Task SendResendConfirmationEmailAsync(string toEmail, string FirstName, string confirmationLinl);
    }
}