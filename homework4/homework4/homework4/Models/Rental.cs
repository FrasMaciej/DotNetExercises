using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace homework4.Models
{
    public class Rental
    {
        [Key]
        [Display(Name = "Numer")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Lokalizacja")]
        public string Localization { get; set; }

        [Required]
        [Display(Name = "Data powstania")]
        public DateTime CreationDate  { get; set; }
    }
}
