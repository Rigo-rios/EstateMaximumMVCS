using AutoMapper;
using EstateMaximum.Data.Data;
using EstateMaximum.Models.Houses;
using EstateMaximum.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Services.Houses
{
    public class MappedHouse : IHouseServices
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public MappedHouse(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AddHouseAsync(HouseCreate model)
        {
            //var house = _mapper.Map<HouseEntity>(model);

            await _context.House.AddAsync(_mapper.Map<HouseEntity>(model));
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteHouseAsync(int id)
        {
            var house = await _context.House.FirstOrDefaultAsync(x=>x.Id==id);
            if (house == null) return false;

            _context.House.Remove(house);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<HouseDetail> DetailHouseAsync(int id)
        {
            return _mapper.Map<HouseDetail>(await _context.House.FindAsync(id));
        }
        public async Task<bool> EditHouseAsync(HouseEdit model)
        {
            var house = await 
                    _context
                    .House
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x=>x.Id == model.Id);

            if (house == null) return false;

            var conversion = _mapper.Map(model, house);
            _context.House.Update(house);
            await _context.SaveChangesAsync();
            return true;

        }


        public async Task<List<HouseListItems>> HouseListItemsAsync()
        {
            return _mapper.Map<List<HouseListItems>>(await _context.House.ToListAsync());
        }
    }
}
