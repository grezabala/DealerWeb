using Microsoft.AspNetCore.Mvc;

namespace DealerWebApp.DealertWeb.Controllers
{
    public class VehiculosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Listados(int id)
        {
            
            return View();
        }
    }
}
