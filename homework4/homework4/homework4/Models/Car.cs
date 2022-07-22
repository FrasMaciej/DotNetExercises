using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace homework4.Models
{
    public class Car
    {
        [Key]
        [Display(Name = "Numer")]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Marka")]
        public string Brand { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Przebieg samochodu")]
        public int Mileage { get; set; }

        [Required]
        [Display(Name = "Czy dostępny?")]
        public string IsAvailable { get; set; }

        [Required]
        [Display(Name = "Numer w cenniku")]
        public int PriceListId { get; set; }

        [ForeignKey("PriceListId")]
        [Display(Name = "Klasa samochodu")]
        public LoanCost PriceList { get; set; }
    }
}
