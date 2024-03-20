using EstateMaximum.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EstateMaximumMVC.Controllers
{
    public class UserController : Controller
    {
        private IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }


        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var user = await _userServices.GetUserAsync(id);
            if (user == null) return BadRequest();
             
            return View(user);
        }
    }
}
