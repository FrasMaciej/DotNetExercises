using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using homework5.Dtos.Car;
using homework5.Interfaces;
using homework5.Models;
using Microsoft.Extensions.Logging;

namespace homework5.Services
{
    public class CarService : ICarService
    {
        private List<Car> _cars = new List<Car>
        {
            new Car
            {
                Id = 0,
                Brand = "Mercedes",
                Model = "S klasa",
                Price = 250000
            },
            new Car
            {
                Id = 1,
                Brand = "BMW",
                Model = "M3",
                Price = 200000
            },new Car
            {
                Id = 2,
                Brand = "Toyota",
                Model = "Corolla",
                Price = 120000
            },new Car
            {
                Id = 3,
                Brand = "Honda",
                Model = "Divic",
                Price = 100000
            },new Car
            {
                Id = 4,
                Brand = "Volkswagen",
                Model = "Passat",
                Price = 100000
            },
        };

        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public CarService(IMapper mapper, ILogger<CarService> logger)
        {
            _mapper = mapper;
            _logger = logger;
        }

        public GetAllCarsDto GetAll(int minCost)
        {
            var allCars = _cars.Where(c => c.Price >= minCost).ToList();

            //throw new Exception("My bad exception");

            var dto = new GetAllCarsDto
            {
                Cars = _mapper.Map<List<CarForGetAllCarsDto>>(allCars)
            };

            return dto;
        }

        public int Create(CreateCarDto car)
        {
            var id = _cars.Count > 0
                ? _cars.Max(c => c.Id) + 1
                : 0;

            var carToAdd = _mapper.Map<Car>(car);

            carToAdd.Id = id;

            _cars.Add(carToAdd);
            return id;
        }

        public GetCarByIdDto Get(int id)
        {
            var car = _cars.FirstOrDefault(c => c.Id == id);

            var dto = _mapper.Map<GetCarByIdDto>(car);

            return dto;
        }


        public bool Update(int id, UpdateCarDto car)
        {
            var carToUpdate = _cars.FirstOrDefault(c => c.Id == id);

            if (carToUpdate == null)
                return false;

            _mapper.Map<UpdateCarDto, Car>(car);

            return true;
        }

        public bool Delete(int id)
        {
            var carToDelete = _cars.FirstOrDefault(c => c.Id == id);

            if (carToDelete == null)
                return false;

            bool isDeleted = _cars.Remove(carToDelete);

            if (isDeleted)
                _logger.LogWarning("Deleted car with id: {Id}", carToDelete.Id);

            return isDeleted;

        }

    }
}
