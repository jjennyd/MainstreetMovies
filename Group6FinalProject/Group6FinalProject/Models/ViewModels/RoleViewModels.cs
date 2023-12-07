using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Group_6_Final_Project.Models
{
    public class RoleEditModel
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<AppUser> RoleMembers { get; set; }
        public IEnumerable<AppUser> RoleNonMembers { get; set; }
    }

    public class RoleModificationModel
    {
        [Required]
        public string RoleName { get; set; }
        public string[] ?IdsToAdd { get; set; }
        public string[] ?IdsToDelete { get; set; }
    }
}