using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebCards.asb.az.Models;

namespace WebCards.asb.az.Controllers
{
    public class HomeController : Controller
    { 
        private readonly IOrderCardService _orderCardService;

        public HomeController(IOrderCardService orderCardService)
        {
            _orderCardService = orderCardService;
        }

        public IActionResult Index()
        {
            var value=_orderCardService.GetAll();
            return View(value);
        }

        public IActionResult UserInfo()
        {
            return View();
        }
     
    }
}