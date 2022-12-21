using Microsoft.AspNetCore.Mvc;

namespace portfolio_site.Controllers
{
    public class NotFound : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
