using Microsoft.AspNetCore.Mvc;

namespace portfolio_site.Controllers
{
    public class CooperationController : Controller
    {
        [Route("cooperation")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
