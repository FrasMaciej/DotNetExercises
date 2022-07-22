using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HomeWork2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeWork2.Controllers
{
    public class HomeController : Controller
    {
        List<Film> filmList;

        public HomeController(ILogger<HomeController> logger)
        {
            filmList = new List<Film>();
            filmList.Add(new Film(1, "Dr Strange", 25.0, 20.0, "Poznaj przygody Dr. Strange-a!", "DoctorStrange.jpg", true));
            filmList.Add(new Film(2, "Uncharted", 25.0, 20.0, "Niesamowita historia na bazie kultowej serii gier!", "Uncharted.jpg", true));
            filmList.Add(new Film(3, "Fantastyczne Zwierzęta", 25.0, 20.0, "Powrót do uniwersum Herrego Pottera!", "FantasticBeasts.jpg", true));

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FilmDetails(int id)
        {
            var film = filmList.FirstOrDefault(x => x.id == id);
            return View(film);
        }

        public IActionResult CreateOrder(int id)
        {
            var film = filmList.FirstOrDefault(x => x.id == id);
            ViewBag.film = film;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrder([Bind("filmId,email,filmTermin,phone")] Order order)
        {
            if(ModelState.IsValid)
            {
                order.orderDate = DateTime.Now;
                var film = filmList.FirstOrDefault(x => x.id == order.filmId);
                ViewBag.orderedFilm = film;
                return View("OrderConfirmation", order);

            }
            else
            {
                var film = filmList.FirstOrDefault(x => x.id == order.filmId);
                ViewBag.film = film;
                return View(order);
            }
        }

        public IActionResult AllFilms()
        {
            return View(filmList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
