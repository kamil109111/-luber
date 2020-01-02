using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Śluber.Models
{
    public class Errand
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Zadanie")]
        public string Name { get; set; }

        [Display(Name = "Data")]
        public DateTime? ErrandDate { get; set; }

        [Display(Name = "Status")]
        public bool ErrandStatus { get; set; }

        [Display(Name = "Koszt")]
        public int ErrandPrice { get; set; }
    }
}
