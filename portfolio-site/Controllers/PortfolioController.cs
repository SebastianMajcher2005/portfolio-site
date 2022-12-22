using Microsoft.AspNetCore.Mvc;

namespace portfolio_site.Controllers
{
    public class PortfolioController : Controller
    {
        [Route("projects")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
