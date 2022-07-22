using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork2.Models
{
    public class Film
    {
        public Film(int id, string name, double normalTicketPrice, double reducedTicketPrice, string description, string image, Boolean isAvailable)
        {
            this.id = id;
            this.name = name;
            this.normalTicketPrice = normalTicketPrice;
            this.reducedTicketPrice = reducedTicketPrice;
            this.description = description;
            this.image = image;
            this.isAvailable = isAvailable;
        }

        public int id { get; set; }
        public string name { get; set; }
        public double normalTicketPrice { get; set; }
        public double reducedTicketPrice { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public Boolean isAvailable;

    }
}
