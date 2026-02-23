using Microsoft.AspNetCore.Identity;

namespace StudyRoom.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Boolean IsActive { get; set; }
        public DateTime? LastLoggedIn { get; set; }
        public DateTime? CreatedOn { get; set; }

    }
}