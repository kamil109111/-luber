using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Śluber.Models
{
    public class Guest
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Imię i Nazwisko")]
        public string Name { get; set; }

        [Display(Name = "Potwierdzony")]
        public bool Status { get; set; }

        //[Display(Name = "Osoba towarzysząca")]
       // public bool AccompanyingPerson { get; set; }

        [Display(Name = "Nocleg")]
        public bool Accomodation { get; set; }
    }
}
