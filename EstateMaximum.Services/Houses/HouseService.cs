using EstateMaximum.Data.Data;
using EstateMaximum.Models.Houses;
using EstateMaximum.Services.IServices;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using EstateMaximum.Models.Apartments;

namespace EstateMaximum.Services.Houses
{
    public class HouseService : IHouseServices
    {
        private readonly ApplicationDbContext _context;

        public HouseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddHouseAsync(HouseCreate model)
        {
            var entity = new HouseEntity
            {
                Address = model.Address,
                City = model.City,
                Description = model.Description,
                HouseNumber = model.HouseNumber,
                Price = model.Price,
                Size = model.Size,
                Bedrooms = model.Bedrooms,
                Bathrooms = model.Bathrooms,
                Stories = model.Stories,
                DatePosted = DateTimeOffset.Now
            };

            await _context.House.AddAsync(entity);
            return await _context.SaveChangesAsync()==1;
        }

        public async Task<bool> DeleteHouseAsync(int id)
        {
            var house = await _context.House.FindAsync(id);
            if (house == null) return false;

            _context.House.Remove(house);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<HouseDetail> DetailHouseAsync(int id)
        {
           var house = await _context.House.SingleOrDefaultAsync(h=>h.Id== id);
            if (house == null) return null;

            return new HouseDetail
            {
                Id= house.Id,
                City = house.City,
                HouseNumber = house.HouseNumber,
                Price = house.Price,
                Size = house.Size,
                Address = house.Address,
                Bathrooms = house.Bathrooms,
                Bedrooms = house.Bedrooms,
                Stories = house.Stories,
                Description = house.Description,
                DatePosted = DateTimeOffset.Now
            };
 
        }

        public async Task<bool> EditHouseAsync(HouseEdit model)
        {
                var house = await _context.House.FindAsync(model.Id);
                if (house == null) return false;

                house.Address = model.Address;
                house.City = model.City;
                house.Description = model.Description;
                house.HouseNumber = model.HouseNumber;
                house.Price = model.Price;
                house.Size = model.Size;
                house.Bedrooms = model.Bedrooms;
                house.Bathrooms = model.Bathrooms;
                house.Stories = model.Stories;

                await _context.SaveChangesAsync();
                return true;
            
        }
        public async Task<List<HouseListItems>> HouseListItemsAsync()
        {
            return await _context.House.Select(h => new HouseListItems
            {
              Id = h.Id,
              HouseNumber = h.HouseNumber,
                City = h.City,
                DatePosted = DateTimeOffset.Now
            }).ToListAsync();
        }
    }
}
