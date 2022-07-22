using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework5.Dtos.Car;
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
        [Produces(typeof(GetAllCarsDto))]
        public IActionResult GetCars([FromQuery] int minPrice)
        {
            var car = _carService.GetAll(minPrice);
            return Ok(car);
        }

        [HttpGet("{id:int}")]
        [Produces(typeof(GetCarByIdDto))]
        public IActionResult GetCarById([FromRoute] int id)
        {
            var car = _carService.Get(id);

            if (car == null)
                return NotFound();

            return Ok(car);
        }

        [HttpPost("")]
        public IActionResult CreateCar([FromBody] CreateCarDto car)
        {
            var id = _carService.Create(car);

            return Created($"api/car/{id}", id);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateCar([FromRoute] int id, [FromBody] UpdateCarDto car)
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
