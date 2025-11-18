using System.ComponentModel.DataAnnotations;

namespace CondoLounge.Data.Entities
{
    public class Condo
    {
        [Key]
        [Required]
        public int Condo_Number { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
        public string Address { get; set; }
    }
}
