using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Śluber.Models
{
    public class Wedding : AuditEntity, IHaveAOwner
    {
        public int Id { get; set; }

        [Display(Name ="Imię Pani Młodej")]
        public string WifeName { get; set; }

        [Display(Name = "Imię Pana Młodego")]
        public string HusbandName { get; set; }

        [Display(Name = "Data ślubu")]
        [DataType(DataType.DateTime)]
        public DateTime WeddingDate { get; set; }

        [Display(Name = "Miejsce ślubu")]
        public string WeddingPlace { get; set; }

        public string OwnerId { get; set; }

        public ApplicationUser Owner { get; set; }
               
        //public List<Errand> Errands { get; set; }

        //public List<Guest> Guests { get; set; }

        //public List<ServiceProv> ServiceProviders { get; set; }

        [Display(Name = "Budżet")]
        [DataType(DataType.Currency)]
        public int Budget { get; set; }

       
        [Display(Name = "Koszty")]
        [DataType(DataType.Currency)]
        public int Cost { get; set; }

        [NotMapped]
        public string Name
        {
            get { return WifeName + " & " + HusbandName; }
        }
    }
}
