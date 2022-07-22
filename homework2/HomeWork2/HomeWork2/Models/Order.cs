using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork2.Models
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int filmId, string email, string phone, DateTime filmTermin, DateTime orderDate)
        {
            this.filmId = filmId;
            this.email = email;
            this.phone = phone;
            this.filmTermin = filmTermin;
            this.orderDate = orderDate;
        }

        [Required]
        public int filmId { get; set; }
        [Required(ErrorMessage = "Email jest wymagany")]
        [EmailAddress]
        public String email { get; set; }
        [Required(ErrorMessage = "Nr. tel. jest wymagany")]
        [Phone]
        public string phone { get; set; }
        [Required(ErrorMessage ="Termin senasu jest wymagany")]
        public DateTime filmTermin { get; set; }
        [Required]
        public DateTime orderDate { get; set; }

    }
}
