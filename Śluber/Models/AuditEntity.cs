using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Śluber.Models
{
    public class AuditEntity: BaseEntity
    {
        public DateTime Createdbb { get; set; } = DateTime.Now;

        public string CreatedById { get; set; }

        public ApplicationUser CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public string ModifiedById { get; set; }

        public ApplicationUser ModifiedBy { get; set; }
    }
    
}
