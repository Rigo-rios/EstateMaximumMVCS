using EstateMaximum.Models.Apartments;
using EstateMaximum.Models.Houses;
using EstateMaximum.Services.Apartments;
using EstateMaximum.Services.Houses;
using EstateMaximum.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EstateMaximumMVC.Controllers
{
    public class ApartmentController : Controller
    {
        private readonly IApartmentServices _apartmentServices;

        public ApartmentController(IApartmentServices apartmentServices)
        {
            _apartmentServices = apartmentServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var apartments = await _apartmentServices.ApartmentListItemAsync();
            return View(apartments);
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var apartment = await _apartmentServices.GetApartmentAsync(id);
            if (apartment == null) return BadRequest();
            return View(apartment);
        }
        

        [HttpGet]
        public async Task<IActionResult> Create()
        { 

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(ApartmentCreate model)
        {
            if (!ModelState.IsValid) return View(ModelState);

            if (await _apartmentServices.AddApartmentAsync(model))
                return RedirectToAction(nameof(Index));

            return View(model);
        } 
        

        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ApartmentEdit model)
        {
            if (!ModelState.IsValid) return View(ModelState);

            if (await _apartmentServices.EditApartmentAsync(model))
                return RedirectToAction(nameof(Index));

            return View(model);
        } 


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var apartment = await _apartmentServices.GetApartmentAsync(id);
            if (apartment == null) return BadRequest();
            var apartmentEdit = new ApartmentEdit
            {
                ApartmentId = apartment.ApartmentId,
                ApartmentNumber = apartment.ApartmentNumber,
                ApartmentName = apartment.ApartmentName,
                Price = apartment.Price,    
                Address = apartment.Address,
                Bathrooms   = apartment.Bathrooms,
                Bedrooms = apartment.Bedrooms,
                City = apartment.City,
                Description = apartment.Description,
                Gym = apartment.Gym,
                Pool = apartment.Pool,
                Size = apartment.Size,
            };
            return View(apartmentEdit);
        }
        
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var apartment = await _apartmentServices.GetApartmentAsync(id);
            return View(apartment);

        }      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            var apartment = await _apartmentServices.DeleteApartmentAsync(id.Value);
            if (apartment == false) return BadRequest();
            return View();
        }


    }
}
