using System.ComponentModel.DataAnnotations;

namespace Shops.Data.Entities
{
    public class Company
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        [Display(Name = "Empresa")]
        public string Name { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        public City City { get; set; }
    }
}
