using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework5.Models;

namespace homework5.Interfaces
{
    public interface ICarService
    {
        List<Car> GetAll(int minCost);

        Car Get(int id);
        int Create(Car car);
        bool Update(int id, Car car);
        bool Delete(int id);
    }
}
