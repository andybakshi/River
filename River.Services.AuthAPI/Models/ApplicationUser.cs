using Microsoft.AspNetCore.Identity;

namespace River.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}