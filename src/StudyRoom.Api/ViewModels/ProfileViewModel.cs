namespace StudyRoom.ViewModels
{
    public class ProfileViewModel
    {
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; }
        public Datetime? LastLoggedIn { get; set; }
        public Datetime? CreatedOn { get; set; }
    }
}