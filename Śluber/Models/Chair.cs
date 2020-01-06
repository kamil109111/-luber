using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Śluber.Models
{
    public class Chair
    {
        public Guid Id { get; set; }
        public int Position { get; set; }
        public Guid GuestId { get; set; }
        public Guid TableId { get; set; }

        public Guest Guest { get; set; }
    }
}
