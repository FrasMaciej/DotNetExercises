using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace homework4.Models
{
    public class Order
    {
        [Key]
        [Display(Name = "Numer")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Data wypożyczenia")]
        public DateTime LoanDate { get; set; }

        [Required]
        [Display(Name = "Data zwrotu")]
        public DateTime ReturnDate { get; set; }

    }
}
