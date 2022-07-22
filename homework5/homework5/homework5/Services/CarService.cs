using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework5.Interfaces;
using homework5.Models;

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
            },
        };

        public List<Car> GetAll(int minCost)
        {
            return _cars.Where(c => c.Price >= minCost).ToList();
        }

        public int Create(Car car)
        {
            car.Id = _cars.Count > 0
                ? _cars.Max(c => c.Id) + 1
                : 0;

            _cars.Add(car);
            return car.Id;
        }

        public Car Get(int id)
        {
            var car = _cars.FirstOrDefault(c => c.Id == id);
            return car;
        }


        public bool Update(int id, Car car)
        {
            var carToUpdate = _cars.FirstOrDefault(c => c.Id == id);

            if (carToUpdate == null)
                return false;

            carToUpdate.Brand = car.Brand;
            carToUpdate.Model = car.Model;
            carToUpdate.Price = car.Price;
            return true;
        }

        public bool Delete(int id)
        {
            var carToDelete = _cars.FirstOrDefault(c => c.Id == id);

            if (carToDelete == null)
                return false;

            bool isDeleted = _cars.Remove(carToDelete);
            return isDeleted;

        }

    }
}
