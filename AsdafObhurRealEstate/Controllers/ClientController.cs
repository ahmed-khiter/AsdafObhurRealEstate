using Microsoft.AspNetCore.Mvc;

namespace AsdafObhurRealEstate.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
