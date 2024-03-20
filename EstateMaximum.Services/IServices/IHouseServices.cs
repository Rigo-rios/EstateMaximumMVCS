using EstateMaximum.Models.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Services.IServices
{
    public interface IHouseServices
    {
        Task<bool> AddHouseAsync(HouseCreate model);
        Task<bool> EditHouseAsync(HouseEdit model);
        Task<HouseDetail> DetailHouseAsync(int id);
        Task<bool> DeleteHouseAsync(int id);
        Task<List<HouseListItems>> HouseListItemsAsync();
    }
}
