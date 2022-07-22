using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace homework4.Models
{
    public class LoanCost
    {
        [Key]
        [Display(Name = "Numer")]

        public int Id { get; set; }

        [Required]
        [Display(Name = "Dzienna opłata")]

        public int PricePerDay { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Klasa samochodu")]

        public string CarQuality { get; set; }

        public ICollection<Car> Cars { get; set; }     // Relacja jeden do wielu - na podstawie PriceListId w tabeli Cars
                                                        // Odnajdowana jest cena samochodu z cennika
    }
}
