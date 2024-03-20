using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Models.Houses
{
    public class HouseCreate
    {

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
        public string Size { get; set; }

        [Required]
        public int Bedrooms { get; set; }

        [Required]
        public int Bathrooms { get; set; }

        [Required]
        public int Stories { get; set; }

    }
}
