using Microsoft.AspNetCore.Mvc;

namespace portfolio_site.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
