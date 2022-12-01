using Microsoft.AspNetCore.Mvc;

namespace DeSoos.Controllers
{
    public class PhotoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
