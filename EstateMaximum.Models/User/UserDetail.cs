using EstateMaximum.Models.Apartments;
using EstateMaximum.Models.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Models.User
{
    public class UserDetail
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<ApartmentListItem> UserApartments { get; set; } = new List<ApartmentListItem>();
        public List<HouseListItems> UserHouses { get; set; } = new List<HouseListItems>();
    }
}
