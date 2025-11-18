using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CondoLounge.Data.Entities
{
    public class Condo
    {
        public int Id { get; set; }
        [Required]
        public int Condo_Number { get; set; }
        [Key]
        [Required]
        public Building Building { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
        public string Address { get; set; }
    }
}
