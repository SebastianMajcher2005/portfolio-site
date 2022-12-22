using Microsoft.AspNetCore.Mvc;

namespace portfolio_site.Controllers
{
    public class NotFoundController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
