using Microsoft.AspNetCore.Mvc;

namespace portfolio_site.Controllers
{
    public class ContactController : Controller
    {
        [Route("contact")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
