using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DataType(DataType.DateTime)]
        public DateTime? ErrandDate { get; set; }

        [Display(Name = "Status")]
        public bool ErrandStatus { get; set; }

        [Display(Name = "Koszt")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ErrandPrice { get; set; }

        [Display(Name = "Notatka")]
        [StringLength(40)]
        public string Note { get; set; }

        

    }
}
