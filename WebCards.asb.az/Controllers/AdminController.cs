using Business.Abstract;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Mvc;

namespace WebCards.asb.az.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserService _userService;

        public AdminController(IUserService userService)
        {
            _userService = userService;
        }
        

        [HttpGet]
        public IActionResult Index()
        {
            var value = _userService.GetAll();
            return View(value);
        }

        
    }
}
