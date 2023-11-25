using Microsoft.AspNetCore.Mvc;
using DealerWebApp.DealertWeb.Models;

namespace DealerWebApp.DealertWeb.Controllers
{
    public class VehiculosController : Controller
    {

        List<MVehiculos> listMvehiculos = new List<MVehiculos>();

        private List<MVehiculos> GetMVehiculos()
        {
            List<MVehiculos> _listmVehiculos = new List<MVehiculos>()
            {
                new MVehiculos
                {
                 VehiculoId= 1,
                 VehiculoName = "HONDA CIVIC",
                 Descripcion = "Color negro, con tracción delantera, turbo integrado, año 2018",
                 Referencia = "Honda Civic, con capacidad para cuatro persona, bolsa de aire delantera y trasera, seis bolsa de aire",
                 VehiculoCode = 01,
                 Year = DateTime.Now,
                 UrlVehiculos = Url.Content("~/Tema/Honda/honda.jpeg")
                },

                new MVehiculos
                {
                 VehiculoId= 2,
                 VehiculoName = "HONDA CRV",
                 Descripcion = "Color rojo, con tracción delantera, turbo integrado",
                 Referencia = "Honda Civic, con capacidad para ocho persona, bolsa de aire delantera y trasera, seis bolsa de aire",
                 VehiculoCode = 02,
                 Year = DateTime.Now,
                 UrlVehiculos = Url.Content("~/Tema/Honda/honda2.jpeg")
                },

                new MVehiculos
                {
                 VehiculoId= 3,
                 VehiculoName = "HONDA CIVIC",
                 Descripcion = "Color gris oscuro, con tracción delantera, turbo integrado",
                 Referencia = "Honda Civic, con capacidad para cuatro persona, bolsa de aire delantera y trasera, seis bolsa de aire",
                 VehiculoCode = 03,
                 Year = DateTime.Now,
                 UrlVehiculos = Url.Content("~/Tema/Honda/honda3.jpeg")
                },

                new MVehiculos
                {
                 VehiculoId= 4,
                 VehiculoName = "HONDA CIVIC",
                 Descripcion = "Color gris, con tracción delantera, turbo integrado, año 2018",
                 Referencia = "Honda Civic, con capacidad para cuatro persona, bolsa de aire delantera y trasera, seis bolsa de aire",
                 VehiculoCode = 04,
                 Year = DateTime.Now,
                 UrlVehiculos = Url.Content("~/Tema/Honda/honda4.jpeg")
                },

                new MVehiculos
                {
                 VehiculoId= 5,
                 VehiculoName = "HONDA CRV",
                 Descripcion = "Color gris plateado, con tracción delantera, sin turbo integrado, año 2018",
                 Referencia = "Honda Civic, con capacidad para seis persona, bolsa de aire delantera y trasera, seis bolsa de aire",
                 VehiculoCode = 05,
                 Year = DateTime.Now,
                 UrlVehiculos = Url.Content("~/Tema/Honda/Honda-Civic.jpg")
                },
            };

            return _listmVehiculos;

        }

        [HttpGet]
        public IActionResult Index(int Id)
        {
            listMvehiculos = GetMVehiculos();
            MVehiculos mVehiculos = listMvehiculos.FirstOrDefault(e => e.VehiculoId == Id)!;
            return View(mVehiculos);
        }

        public IActionResult Listados(int id)
        {

            return View();
        }
    }
}
