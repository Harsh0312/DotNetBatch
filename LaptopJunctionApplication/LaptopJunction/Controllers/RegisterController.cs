using Microsoft.AspNetCore.Mvc;

namespace LaptopJunction.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
