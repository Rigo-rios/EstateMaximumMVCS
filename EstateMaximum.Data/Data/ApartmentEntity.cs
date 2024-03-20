using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Data.Data
{
    public class ApartmentEntity
    {
        [Key]
        public int ApartmentId { get; set; }
       
        [Required] [MinLength(1),MaxLength(150)]
        public string ApartmentName { get; set; }
        
        [Required] [MinLength(1), MaxLength(150)]
        public string Address { get; set; }

        [Required] [MinLength(1), MaxLength(150)]
        public string City { get; set; } = string.Empty;

        [Required] [MinLength(1), MaxLength(15)]
        public int ApartmentNumber { get; set; }
        
        [Required] [MinLength(1), MaxLength(2000)]
        public string Description { get; set; }

        [Required]
        public string Size { get; set; }
        
        [Required]
        public double Price { get; set; }
        
        [Required]
        public int Bedrooms { get; set; }

        [Required]
        public int Bathrooms { get; set; }

        public bool Gym { get; set; }
        public bool Pool { get; set; }
        //public string UserId { get; set; }
        //[ForeignKey(nameof(UserId))]
        public DateTimeOffset DatePosted { get; set; }


    }
}
