using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework4.Models;
using Microsoft.AspNetCore.Mvc;

namespace homework4.Controllers
{
    public class LoanCostsController : Controller
    {
        private readonly DataBaseContext _context;

        public LoanCostsController(DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var costList = _context.LoansCosts.ToList();
            return View(costList);
        }
    }
}
