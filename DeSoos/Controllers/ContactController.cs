using Microsoft.AspNetCore.Mvc;

namespace DeSoos.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
