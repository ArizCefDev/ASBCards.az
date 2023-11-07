using Microsoft.AspNetCore.Mvc;

namespace WebCards.asb.az.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp() 
        {
            return View();
        }
    }
}
