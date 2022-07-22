using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework5.Dtos.Car
{
    public class GetAllCarsDto
    {
        public ICollection<CarForGetAllCarsDto> Cars { get; set; }
        public float TotalPrice => Cars.Sum(p => p.Price);
    }

    public class CarForGetAllCarsDto
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public float Price { get; set; }
    }

}
