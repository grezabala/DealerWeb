using DealerWebApp.DealertWeb.Aplication.Dtos;
using DealerWebApp.DealertWeb.Aplication.Interfaces.Services;
using DealerWebApp.DealertWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace DealerWebApp.DealertWeb.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsService CarsService;
        public CarsController(ICarsService carsService)
        {
            CarsService = carsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var mVehiculos = GetMVehiculos();
            var cars = new MCars();
            cars.MVehiculos = mVehiculos;

            return View(cars);
        }

        [HttpGet]
        public IActionResult Add() 
        {
          return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CarsDto carsDto) 
        {
            if (ModelState.IsValid)
            {
                var add = await CarsService.Add(carsDto);
                return View(carsDto);
            }
            else 
            {
              return RedirectToAction("Index");
            }
        }

        public List<MVehiculos> GetMVehiculos()
        {
            List<MVehiculos> listMVehiculos = new List<MVehiculos>()
            {


            };

            return listMVehiculos;
        }
    }
}
