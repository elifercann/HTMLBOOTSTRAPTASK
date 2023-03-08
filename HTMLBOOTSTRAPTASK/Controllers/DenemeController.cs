using Microsoft.AspNetCore.Mvc;

namespace HTMLBOOTSTRAPTASK.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
