using System.ComponentModel.DataAnnotations;

namespace CondoLounge.Data.Entities
{
    public class Building
    {
        public int Id { get; set; }
        [Required]
        public ICollection<Condo> Condos { get; set; }
    }
}
