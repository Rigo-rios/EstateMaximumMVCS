using EstateMaximum.Models.Apartments;
using EstateMaximum.Models.Houses;
using EstateMaximum.Services.Apartments;
using EstateMaximum.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EstateMaximumMVC.Controllers
{
    public class HousesController : Controller
    {
        private IHouseServices _houseServices;
        

        public HousesController(IHouseServices houseServices)
        {
            _houseServices = houseServices;
            
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var houses = await _houseServices.HouseListItemsAsync();
            return View(houses);
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var house = await _houseServices.DetailHouseAsync(id);
        
            return View(house);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HouseCreate model)
        {
            if (!ModelState.IsValid) return View(ModelState);

            if (await _houseServices.AddHouseAsync(model))
                return RedirectToAction(nameof(Index));

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult>Edit(int id)
        {
            var house = await _houseServices.DetailHouseAsync(id);
            if (house == null) return BadRequest();
            var houseEdit = new HouseEdit
            { 
                Id = house.Id,
                Address = house.Address,
                Bedrooms    = house.Bedrooms,
                HouseNumber = house.HouseNumber,
                City = house.City,
                Description= house.Description,
                Price= house.Price,
                Size= house.Size,
                Stories= house.Stories
            };

            return View(houseEdit);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(HouseEdit model)
        {
            var house = await _houseServices.EditHouseAsync(model);
            if (house == false) return BadRequest();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            var house = await _houseServices.DetailHouseAsync(id.Value);
           
            return View(house);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Delete(int id)
        {
            var house = await _houseServices.DeleteHouseAsync(id);
            if (house == false) return BadRequest();


            return RedirectToAction("Index");
        }
    }
}
