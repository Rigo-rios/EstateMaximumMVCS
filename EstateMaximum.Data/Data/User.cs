using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Data.Data
{
    public class User : IdentityUser
    { 
        [Required]
        [MinLength(1), MaxLength(150)]
        public string FirstName { get; set; } = string.Empty;
        
        [Required]
        [MinLength(1), MaxLength(150)]
        public string LastName { get; set; } = string.Empty;

        public List<HouseEntity> House { get; set; } = new List<HouseEntity>();
        public List<ApartmentEntity> Apartment { get; set; } = new List<ApartmentEntity>();
    }
}
