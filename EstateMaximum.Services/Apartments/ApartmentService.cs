using EstateMaximum.Data.Data;
using EstateMaximum.Models.Apartments;
using EstateMaximum.Services.IServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Services.Apartments
{
    public class ApartmentService : IApartmentServices

    {
        private readonly ApplicationDbContext _context;

        public ApartmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async  Task<bool> AddApartmentAsync(ApartmentCreate model)
        {
            var apartment = new ApartmentEntity
            {
                ApartmentName = model.ApartmentName,
                Address = model.Address,
                City = model.City,
                Description = model.Description,
                ApartmentNumber = model.ApartmentNumber,
                Price = model.Price,
                Size = model.Size,
                Bedrooms = model.Bedrooms,
                Bathrooms = model.Bathrooms,
                Pool = model.Pool,
                Gym = model.Pool,
                DatePosted = DateTimeOffset.Now
            };


            await _context.Apartment.AddAsync(apartment);
            return await _context.SaveChangesAsync() == 1;

        }

        public async Task<bool> DeleteApartmentAsync(int id)
        {
            var apartment = await _context.Apartment.FindAsync(id);
            if (apartment == null) return false;


            _context.Apartment.Remove(apartment);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EditApartmentAsync(ApartmentEdit model)
        {
            var apartment = await _context.Apartment.FindAsync(model.ApartmentId);
            if (apartment == null) return false;

                apartment.ApartmentName = model.ApartmentName;
            apartment.Address = model.Address;
            apartment.City = model.City;
            apartment.Description = model.Description;
            apartment.ApartmentNumber = model.ApartmentNumber;
            apartment.Price = model.Price;
            apartment.Size = model.Size;
            apartment.Bedrooms = model.Bedrooms;
            apartment.Bathrooms = model.Bathrooms;
            apartment.Pool = model.Pool;
            apartment.Gym = model.Pool;
            apartment.DatePosted = DateTimeOffset.Now;


            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<ApartmentDetail> GetApartmentAsync(int id)
        {
            var apartment = await _context.Apartment.SingleOrDefaultAsync(x=>x.ApartmentId == id);
            if (apartment == null) return null;

            return new ApartmentDetail
            {
                ApartmentId = apartment.ApartmentId,
                ApartmentName = apartment.ApartmentName,
                Address = apartment.Address,
                City = apartment.City,
                Description = apartment.Description,
                ApartmentNumber = apartment.ApartmentNumber,
                Price =  apartment.Price,
                Size = apartment.Size,
                Bedrooms = apartment.Bedrooms,
                Bathrooms = apartment.Bathrooms,
                Pool = apartment.Pool,
                Gym = apartment.Pool,
                DatePosted = DateTimeOffset.Now
            };
        }


         public async Task<List<ApartmentListItem>> ApartmentListItemAsync()
        {
            return await _context.Apartment.Select(a => new ApartmentListItem
                {
                ApartmentId = a.ApartmentId,
                ApartmentNumber=a.ApartmentNumber,
                   Price=a.Price,
                   ApartmentName = a.ApartmentName,
                   City = a.City,
                   DatePosted = DateTimeOffset.Now
                }).ToListAsync();
        }
    }


}
