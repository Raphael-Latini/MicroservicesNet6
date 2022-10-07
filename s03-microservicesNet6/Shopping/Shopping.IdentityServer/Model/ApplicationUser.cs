using Microsoft.AspNetCore.Identity;

namespace Shopping.IdentityServer.Model
{
    public class ApplicationUser: IdentityUser
    {
        private string FirstName { get; set; }
        
        private string LastName { get; set; }

    }
}
