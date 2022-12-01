using Microsoft.AspNetCore.Mvc;

namespace DeSoos.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
