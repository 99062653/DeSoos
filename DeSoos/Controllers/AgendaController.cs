using Microsoft.AspNetCore.Mvc;

namespace DeSoos.Controllers
{
    public class AgendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
