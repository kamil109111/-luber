using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Śluber.Models
{
    public class Table
    {
        public Guid Id { get; set; }

        public List<Chair> Chairs { get; set; }
    }
}
