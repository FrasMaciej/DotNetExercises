using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework5.Interfaces;
using homework5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace homework5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("")]
        [Produces(typeof(List<Car>))]
        public IActionResult GetCars([FromQuery] int minPrice)
        {
            var car = _carService.GetAll(minPrice);
            return Ok(car);
        }

        [HttpGet("{id:int}")]
        [Produces(typeof(Car))]
        public IActionResult GetPizzaById([FromRoute] int id)
        {
            var car = _carService.Get(id);

            if (car == null)
                return NotFound();

            return Ok(car);
        }

        [HttpPost("")]
        public IActionResult CreateCar([FromBody] Car car)
        {
            var id = _carService.Create(car);

            return Created($"api/car/{id}", id);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateCar([FromRoute] int id, [FromBody] Car car)
        {
            bool isUpdated = _carService.Update(id, car);
            if (isUpdated)
                return NoContent();

            return NotFound();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCar([FromRoute] int id)
        {
            bool isDeleted = _carService.Delete(id);
            if (isDeleted)
                return NoContent();
            return NotFound();
        }

    }
}
