using Microsoft.AspNetCore.Mvc;

namespace portfolio_site.Controllers
{
    public class MyCareerPathController : Controller
    {
        [Route("my-career-path")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
