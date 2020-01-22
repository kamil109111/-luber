using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Śluber.Models
{
    public class Wedding : AuditEntity, IHaveAOwner
    {
        public int Id { get; set; }

        public string WifeName { get; set; }

        public string HusbandName { get; set; }

        public DateTime WeddingDate { get; set; }

        public string WeddingPlace { get; set; }

        public string OwnerId { get; set; }

        public ApplicationUser Owner { get; set; }
               
        //public List<Errand> Errands { get; set; }

        //public List<Guest> Guests { get; set; }

        //public List<ServiceProv> ServiceProviders { get; set; }

        public int Budget { get; set; }

        public int Cost { get; set; }
    }
}
