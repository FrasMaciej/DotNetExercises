using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework5.Dtos.Car;
using homework5.Models;

namespace homework5.Interfaces
{
    public interface ICarService
    {
        GetAllCarsDto GetAll(int minCost);

        GetCarByIdDto Get(int id);
        int Create(CreateCarDto car);
        bool Update(int id, UpdateCarDto car);
        bool Delete(int id);
    }
}
