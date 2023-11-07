using Business.Abstract;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Mvc;

namespace WebCards.asb.az.Controllers
{
    public class OrderCardController : Controller
    {
        private readonly IOrderCardService _orderCardService;

        public OrderCardController(IOrderCardService orderCardService)
        {
            _orderCardService = orderCardService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OrderCardDTO or)
        {
            or.UserId = 1;
            or.CarNo = "****";
            or.Status = "Yeni müştəri";
            or.FillialKodu = "---";
            or.HesabNo = "---";
            or.SubHesab = "---";
            _orderCardService.Insert(or);

            return RedirectToAction("Details");
        }
        
        public IActionResult Details()
        {

            var value=_orderCardService.GetAll();

            return View(value);
        }

        public IActionResult Sistem()
        {

            var value = _orderCardService.GetAll();

            return View(value);
        }

        public IActionResult PlasticCards()
        {

            var value = _orderCardService.GetAll();

            return View(value);
        }

       


    }
}
