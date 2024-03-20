using System.ComponentModel.DataAnnotations;

namespace EstateMaximum.Models.Apartments
{
    public class ApartmentEdit
    {
        [Key]
        public int ApartmentId { get; set; }

        [Required]
        [MinLength(1), MaxLength(150)]
        public string ApartmentName { get; set; }

        [Required]
        [MinLength(1), MaxLength(150)]
        public string Address { get; set; }

        [Required]
        [MinLength(1), MaxLength(150)]
        public string City { get; set; } = string.Empty;

        [Required]
        public int ApartmentNumber { get; set; }

        [Required]
        [MinLength(1), MaxLength(2000)]
        public string Description { get; set; }

        [Required]
        [MinLength(1), MaxLength(15)]
        public string Size { get; set; }

        [Required]
      
        public double Price { get; set; }

        [Required]
       
        public int Bedrooms { get; set; }

        [Required]
        
        public int Bathrooms { get; set; }

        [Required]
        public bool Gym { get; set; }

        [Required]
        public bool Pool { get; set; }
    }
}
