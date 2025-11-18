using Microsoft.AspNetCore.Identity;

namespace CondoLounge.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public ICollection<Condo> Condos { get; set; }
        public ICollection<Building> Buildings { get; set; }
    }
}
