using Microsoft.AspNetCore.Mvc;

namespace portfolio_site.Controllers
{
    public class AboutController : Controller
    {
        [Route("about")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
