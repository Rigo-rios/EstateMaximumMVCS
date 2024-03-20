using EstateMaximum.Models.Houses;
using EstateMaximum.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaximum.Services.IServices
{
    public interface IUserServices
    {
        Task<UserDetail> GetUserAsync(int id);
    }
}
