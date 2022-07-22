﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework4.Models;
using Microsoft.AspNetCore.Mvc;

namespace homework4.Controllers
{
    public class RentalsController : Controller
    {
        private readonly DataBaseContext _context;

        public RentalsController(DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var rentals = _context.Rentals.ToList();
            return View(rentals);
        }
    }
}
