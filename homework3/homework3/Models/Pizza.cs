using System;
using System.ComponentModel.DataAnnotations;


namespace homework3.Models
{
    public class Pizza
    {
        /*
        public Pizza(int PizzaId, string Name, double Price, string Description, string ImagePath)
        {
            this.PizzaId = PizzaId;
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
            this.ImagePath = ImagePath;
        }
        */

        [Required]
        public int PizzaId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImagePath { get; set; }
    }
}
