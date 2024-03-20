using System.ComponentModel.DataAnnotations;

namespace EstateMaximum.Models.Houses
{
    public class HouseEdit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1), MaxLength(150)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MinLength(1), MaxLength(150)]
        public string City { get; set; } = string.Empty;

        [Required]
        [MinLength(1), MaxLength(150)]
        public string Description { get; set; } = string.Empty;

        [Required]
      
        public int HouseNumber { get; set; }

        [Required]
        
        public double Price { get; set; }

        [Required]
        [MinLength(1), MaxLength(10)]
        public string Size { get; set; }

        [Required]
       
        public int Bedrooms { get; set; }

        [Required]
       
        public int Bathrooms { get; }

        [Required]
      
        public int Stories { get; set; }
    }
}
