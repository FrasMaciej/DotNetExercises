﻿using System;
using System.ComponentModel.DataAnnotations;

namespace homework3.Models
{
    public class Order
    { 
        [Required]
        public int PizzaId { get; set; }

        [Required(ErrorMessage = "Miasto jest wymagane")]
        public string City { get; set; }

        [Required(ErrorMessage = "Adres jest wymagany")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email jest wymagany")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [Phone(ErrorMessage = "Niepoprawny nr telefonu")]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
    }
}