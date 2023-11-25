using DealerWebApp.DealertWeb.Aplication.Dtos;
using DealerWebApp.DealertWeb.Aplication.Interfaces.Services;
using DealerWebApp.DealertWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace DealerWebApp.DealertWeb.Controllers
{
    public class PortadaController : Controller
    {
        //private IContactosService ContactosService;

        //public PortadaController(IContactosService contactosService) => ContactosService = contactosService;
      

        [HttpGet]
        public IActionResult Index()
        {
            var brand = _GetMBrands();
            var portada = new MPortadas();
            portada.MBrands = brand;
            return View(portada);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ContactosDto contactosDto)
        {
            //if (ModelState.IsValid)
            //{
            //    var addContactos = await ContactosService.Add(contactosDto);
            //    if (addContactos != null)
            //        return View(addContactos);
            //}
            //else
            //{
            //    return BadRequest();
            //}

            return View();
        }

        //METODO LIST
        private List<MBrands> _GetMBrands()
        {
            List<MBrands> _ListMBrands = new List<MBrands>()
            {
                new MBrands
                {
                    BrandId = 1,
                    NameBrand = "HONDA",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/honda-logo-v1.webp"),
                    UrlViewsBrand = Url.Content("~/Brands/Index")
                },

                new MBrands
                {
                    BrandId = 2,
                    NameBrand = "MERCEDES BENZ",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/mersedes-logo.webp"),
                },

                new MBrands()
                {
                    BrandId = 3,
                    NameBrand = "ACURA",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/acura-logo.webp")

                },

                new MBrands
                {
                    BrandId = 4,
                    NameBrand = "VOLKSWAGEN",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/volkswagen-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 5,
                    NameBrand = "PEUGEOT",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/peugeot-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 6,
                    NameBrand = "MAZDA",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/mazda-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 7,
                    NameBrand = "TOYOTA",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/toyota-logos.webp")
                },

                new MBrands()
                {
                    BrandId = 8,
                    NameBrand = "LEXUS",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/lexus-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 9,
                    NameBrand = "FIAT",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/fiat-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 9,
                    NameBrand = "KIA",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/kia-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 10,
                    NameBrand = "AUDI",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/audi-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 11,
                    NameBrand = "INFINITI",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/infiniti-logo-2.webp")
                },

                new MBrands()
                {
                    BrandId = 12,
                    NameBrand = "BMW",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/bmw-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 13,
                    NameBrand = "HYUNDAI",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/hyundai-logo-v1.webp")
                },

                new MBrands()
                {
                    BrandId = 14,
                    NameBrand = "SUZUKI",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/suzuki-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 15,
                    NameBrand = "MINI",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/mini-logo-3d.webp")
                },

                new MBrands()
                {
                    BrandId = 16,
                    NameBrand = "RENAULT",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/renault-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 17,
                    NameBrand = "CHEVROLET",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/chevrolet-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 18,
                    NameBrand = "SUBARU",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/subaru-logo-3d.webp")
                },

                new MBrands()
                {
                    BrandId = 19,
                    NameBrand = "PORSCHE",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/porsche-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 20,
                    NameBrand = "TESLA",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/tesla-logo.webp")
                },

                new MBrands()
                {
                    BrandId = 21,
                    NameBrand = "LAND ROVER",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/land-rover-logo.webp")

                },
                new MBrands()
                {
                    BrandId = 22,
                    NameBrand = "LINCOLN",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/lincoln-logo.webp")

                },

                new MBrands()
                {
                    BrandId = 23,
                    NameBrand = "NISSAN",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/nissan-logo-3d.webp")

                },

                new MBrands()
                {
                    BrandId = 24,
                    NameBrand = "JEEP",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/jeep-logo-3d.webp")

                },

                new MBrands()
                {
                    BrandId = 25,
                    NameBrand = "VOLVO",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/volvo-logo-3d.webp")

                },

                new MBrands()
                {
                    BrandId = 26,
                    NameBrand = "MITSUBISHI",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/mitsubishi-logo-3d1.webp")

                },

                new MBrands()
                {
                    BrandId = 27,
                    NameBrand = "JAC",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/jac-logo.webp")

                },

                new MBrands()
                {
                    BrandId = 28,
                    NameBrand = "FORD",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/ford-logo.webp")

                },

                new MBrands()
                {
                    BrandId = 29,
                    NameBrand = "GMC",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/gmc-logo.webp")

                },

                new MBrands()
                {
                    BrandId = 30,
                    NameBrand = "DODGE",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/dodge-logo.webp")

                },

                new MBrands()
                {
                    BrandId = 31,
                    NameBrand = "DAIHATSU",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/daihatsu-logo-3d.webp")

                },

                new MBrands()
                {
                    BrandId = 32,
                    NameBrand = "CADILLAC",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/cadillac-logo-3d.webp")

                },

                new MBrands()
                {
                    BrandId = 33,
                    NameBrand = "LOTUS",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/lotus-logo.webp")

                },

                new MBrands()
                {
                    BrandId = 34,
                    NameBrand = "MARCK",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/mack-logo-3d.webp")

                },

                new MBrands()
                {
                    BrandId = 35,
                    NameBrand = "MASERATI",
                    UrlImg = Url.Content("~/Tema/imgMarca/Logo/trident-logo-3d-model.webp")
                },

            };

            return _ListMBrands;
        }
    }
}
