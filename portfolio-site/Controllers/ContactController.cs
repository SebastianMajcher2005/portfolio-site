using Microsoft.AspNetCore.Mvc;

namespace portfolio_site.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
