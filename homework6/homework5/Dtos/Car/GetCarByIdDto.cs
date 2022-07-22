using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework5.Dtos.Car
{
    public class GetCarByIdDto
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
    }
}
