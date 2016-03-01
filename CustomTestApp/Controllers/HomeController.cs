using CustomTestApp.Models;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomTestApp.Controllers
{
    public class HomeController : Controller
    {
        private IOrderService _orderService;

        public HomeController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public ActionResult Index()
        {
            var orders = _orderService.GetAllOrders();
            var model = orders.Select(order => new OrderViewModel
            {
                Code = order.Code,
                Date = order.Date
            });
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}