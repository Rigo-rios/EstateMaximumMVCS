using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Data.Data
{
    public class HouseEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required] [MinLength(1), MaxLength(150)]
        public string Address { get; set; } = string.Empty;

        [Required] [MinLength(1), MaxLength(150)]
        public string City { get; set; } = string.Empty;
        
        [Required] [MinLength(1), MaxLength(150)]
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
        //public string UserId { get; set; }
        //[ForeignKey(nameof(UserId))]  
        public DateTimeOffset DatePosted { get; set; }
    }
}
