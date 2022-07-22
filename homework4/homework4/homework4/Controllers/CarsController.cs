using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace homework4.Controllers
{
    public class CarsController : Controller
    {
        private readonly DataBaseContext _context;

        public CarsController(DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cars = _context.Cars.ToList();
            return View(cars);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var car = _context.Cars.FirstOrDefault(m => m.Id.Equals(id));

            if (car == null)
                return NotFound();

            return View(car);
        }

        [HttpPost]
        public IActionResult Edit(Car car)
        {
            if(ModelState.IsValid)
            {
                _context.Cars.Update(car);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        public IActionResult Delete(int id)
        {
            var car = _context.Cars.Include(m => m.PriceList).FirstOrDefault(m => m.Id.Equals(id));

            if (car == null)
                return NotFound();

            return View(car);

        }

        [HttpPost]
        public IActionResult Delete(Car car)
        {
            _context.Cars.Remove(car);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));

        }
    }
}
