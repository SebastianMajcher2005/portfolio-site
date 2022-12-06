using Microsoft.AspNetCore.Mvc;

namespace portfolio_site.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
