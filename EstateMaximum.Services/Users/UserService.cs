using EstateMaximum.Data.Data;
using EstateMaximum.Models.Apartments;
using EstateMaximum.Models.Houses;
using EstateMaximum.Models.User;
using EstateMaximum.Services.IServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Services.Users
{
    internal class UserService : IUserServices
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserDetail> GetUserAsync(int id)
        {
            var user = await _context.ApplicationUsers.SingleOrDefaultAsync();
            if (user != null) return null;

            return new UserDetail
            {
             FirstName = user.FirstName,
             LastName = user.LastName,
             UserApartments = user.Apartment.Select(l=>new ApartmentListItem
             {
                 ApartmentName = l.ApartmentName,
                 ApartmentId = l.ApartmentId,
                 ApartmentNumber = l.ApartmentNumber,
                 City = l.City,
                 Price = l.Price,
                 DatePosted = l.DatePosted
             }).ToList(),
             UserHouses = user.House.Select(p=>new HouseListItems
             {
                 Id = p.Id,
                 HouseNumber = p.HouseNumber,
                 City = p.City,
                 DatePosted= p.DatePosted,
             }).ToList()
            };
        }
    }
}
