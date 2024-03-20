using AutoMapper;
using EstateMaximum.Data.Data;
using EstateMaximum.Models.Apartments;
using EstateMaximum.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Services.Apartments
{
    public class MappedApartmentService : IApartmentServices
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public MappedApartmentService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AddApartmentAsync(ApartmentCreate model)
        {
            await _context.Apartment.AddAsync(_mapper.Map<ApartmentEntity>(model));
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<ApartmentListItem>> ApartmentListItemAsync()
        {
            return _mapper.Map<List<ApartmentListItem>>(await _context.Apartment.ToListAsync());
        }

        public async  Task<bool> DeleteApartmentAsync(int Id)
        {
            var apartment = await _context.House.FindAsync(Id);
            if (apartment == null) return false;

            _context.House.Remove(apartment);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EditApartmentAsync(ApartmentEdit model)
        {
            var apartment = await _context.Apartment.AsNoTracking().FirstOrDefaultAsync(a => a.ApartmentId == model.ApartmentId);

            if(apartment == null) return false;

            var conversion = _mapper.Map(model, apartment);
            _context.Apartment.Update(conversion);
            await _context.SaveChangesAsync();
            return true;
        }

        public async  Task<ApartmentDetail> GetApartmentAsync(int id)
        {
            return _mapper.Map<ApartmentDetail>(await _context.Apartment.FindAsync(id));
        }       

    }
}
