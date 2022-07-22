using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework4.Models;
using Microsoft.AspNetCore.Mvc;

namespace homework4.Controllers
{
    public class OrdersController : Controller
    {
        private readonly DataBaseContext _context;

        public OrdersController(DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var orders = _context.Orders.ToList();
            return View(orders);
        }
    }
}
