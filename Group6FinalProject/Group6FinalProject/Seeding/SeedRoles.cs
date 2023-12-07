using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Group_6_Final_Project.Seeding
{
    public class SeedRoles
    {
        public static async Task AddAllRoles(RoleManager<IdentityRole> roleManager)
        {
            //TODO: Add the needed roles - admin and customer are provided
            //as examples
            //if the manager role doesn't exist, add it
            if (await roleManager.RoleExistsAsync("Manager") == false)
            {
                //this code uses the role manager object to create the manager role
                await roleManager.CreateAsync(new IdentityRole("Manager"));
            }

            //if the employee role doesn't exist, add it
            if (await roleManager.RoleExistsAsync("Employee") == false)
            {
                //this code uses the role manager object to create the employee role
                await roleManager.CreateAsync(new IdentityRole("Employee"));
            }

            if (await roleManager.RoleExistsAsync("Customer") == false)
            {
                //this code uses the role manager object to create the customer role
                await roleManager.CreateAsync(new IdentityRole("Customer"));
            }
        }
    }
}
