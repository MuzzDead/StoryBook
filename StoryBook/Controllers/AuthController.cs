using Microsoft.AspNetCore.Mvc;

namespace StoryBook.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult UserInfo()
        {
            return View();
        }
    }
}
