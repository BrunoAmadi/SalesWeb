using Microsoft.AspNetCore.Mvc;

namespace SallesWeb.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
