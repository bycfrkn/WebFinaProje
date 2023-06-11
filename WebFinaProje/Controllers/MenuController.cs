using Microsoft.AspNetCore.Mvc;

namespace FinalProjesiWeb.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
