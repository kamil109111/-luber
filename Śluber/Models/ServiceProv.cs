using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Śluber.Models
{
    public class ServiceProv
    {
        public int Id { get; set; }

        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Typ usługi")]
        public string ServiceType { get; set; }

        [Display(Name = "Koszt")]
        public int Price { get; set; }
    }
}
