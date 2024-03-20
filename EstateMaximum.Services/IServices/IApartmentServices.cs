using EstateMaximum.Models.Apartments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Services.IServices
{
    public interface IApartmentServices
    {
        Task<bool> AddApartmentAsync(ApartmentCreate model);

        Task<ApartmentDetail> GetApartmentAsync(int id);
        Task<bool> EditApartmentAsync(ApartmentEdit model);
        Task<bool> DeleteApartmentAsync(int Id);
        Task<List<ApartmentListItem>> ApartmentListItemAsync();
    }
}
